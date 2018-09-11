using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using Newtonsoft.Json;
using HtmlDocument = System.Windows.Forms.HtmlDocument;

namespace DovizBar
{
    public partial class Form1 : Form
    {
        #region Variables

        /* DOUBLE */
        private double averageDolar = 0;
        private double averageEuro = 0;

        /* INT */
        private int updateCount = 1; //Thread -> 1, Normal -> 2
        private int position = 0;

        /* STRING */
        private string arrowUp = "▲";
        private string arrowDown = "▼";
        private string oldDolar;
        private string oldEuro;
        private string currentDolar;
        private string currentEuro;
        private string html = String.Empty;

        /* BOOL */
        private bool alert = false;
        private bool funMode = false;

        /* COLOR */
        private Color defaultCurrencyColor = Color.Gold;
        private Color upColor = Color.GreenYellow;
        private Color downColor = Color.Red;
        //private Color RefreshColor = Color.Yellow;
        private Color defaultTimeColor = Color.White;
        private Color dolarColor;
        private Color euroColor;

        /* THREAD */
        private Thread threadPull;

        /* SOUND */
        private SoundPlayer alertSound = new SoundPlayer(Properties.Resources.AlertSound_2);
        private SoundPlayer alertGoalSound = new SoundPlayer(Properties.Resources.AlertSound);

        /* SCREEN */
        private Screen scr;

        //private Uri url = new Uri(@"https://www.widgets.investing.com/single-currency-crosses?theme=darkTheme&currency=9");
        private Uri url = new Uri(
            @"https://www.widgets.investing.com/live-currency-cross-rates?theme=lightTheme&hideTitle=true&pairs=66,18
                                    ""%20width=""100%""%20height=""100%""%20frameborder=""0""%20allowtransparency=""true""%20marginwidth=""0""%20marginheight=""0"">
                                    </iframe><div%20class=""poweredBy""%20style=""font-family:%20Arial,%20Helvetica,%20sans-serif;");

        private HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        private WebClient client;

        #endregion

        public Form1()
        {
            Updater();
            if (CheckVersion())
            {
                Application.Exit();
                this.Close();
            }
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = MinimumSize;
            rowDolar.Text = "";
            rowEuro.Text = "";
            dolarColor = txtDolar.ForeColor;
            euroColor = txtEuro.ForeColor;

            scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);

            PrepareThread();
            threadPull.Start();

            SetRefreshTime();
            timer1.Enabled = true;
            txtDolar.BackColor = Color.Transparent;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            position++;
            ChangePosition();
        }

        private void PrepareThread()
        {
            threadPull = new Thread(PullData);
        }

        private void ChangePosition()
        {
            if (position % 4 == 0)
                this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
            else if (position % 4 == 1)
                this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Bottom - this.Height);
            else if (position % 4 == 2)
                this.Location = new Point(scr.WorkingArea.Left, scr.WorkingArea.Bottom - this.Height);
            else if (position % 4 == 3)
                this.Location = new Point(scr.WorkingArea.Left, scr.WorkingArea.Top);
        }

        private delegate void DelegateUpdateScreen();

        private void UpdateScreen(string dolar, string percentDolar, string minDolar, string maxDolar,
            string euro, string percentEuro, string minEuro, string maxEuro,
            string dolarBuy, string dolarSell, string euroBuy, string euroSell)
        {
            txtDolar.Text = dolar;
            txtEuro.Text = euro;

            txtMinDolar.Text = minDolar;
            txtMaxDolar.Text = maxDolar;
            this.percentDolar.Text = percentDolar;

            txtMinEuro.Text = minEuro;
            txtMaxEuro.Text = maxEuro;
            this.percentEuro.Text = percentEuro;

            if (percentDolar[0] == '+')
            {
                this.percentDolar.ForeColor = upColor;
            }
            else if (percentDolar[0] == '-')
            {
                this.percentDolar.ForeColor = downColor;

            }

            if (percentEuro[0] == '+')
            {
                this.percentEuro.ForeColor = upColor;
            }
            else if (percentEuro[0] == '-')
            {
                this.percentEuro.ForeColor = downColor;

            }

            lblDolarBuy.Text = dolarBuy;
            lblDolarSell.Text = dolarSell;
            lblEuroBuy.Text = euroBuy;
            lblEuroSell.Text = euroSell;

            averageDolar += Convert.ToDouble(dolar.Replace('.', ','));
            averageEuro += Convert.ToDouble(euro.Replace('.', ','));
            txtAverageDolar.Text = (averageDolar / updateCount).ToString(".0000");
            txtAverageEuro.Text = (averageEuro / updateCount).ToString(".0000");

            txtLastUpdate.Text = DateTime.Now.ToLongTimeString();
            timer2.Enabled = true;
        }

        private void UpdateDoviz()
        {
            try
            {
                client = new WebClient();
                client.Headers.Add("User-Agent: Other");
                html = client.DownloadString(url);
                document = new HtmlAgilityPack.HtmlDocument();
                document.LoadHtml(html);
                HtmlNodeCollection Currency =
                    document.DocumentNode.SelectNodes("//div");
                /*
                HtmlNodeCollection dovizler = document.DocumentNode.SelectNodes("//span[@class='menu-row2']");
                UpdateScreen(dovizler[1].InnerText, dovizler[2].InnerText);
                */
                if (Currency.Count < 33)
                {
                    return;
                }

                if (InvokeRequired)
                {
                    BeginInvoke(new DelegateUpdateScreen(() => UpdateScreen(
                        Currency[26].InnerText, Currency[31].InnerText, Currency[29].InnerText, Currency[28].InnerText,
                        Currency[16].InnerText, Currency[21].InnerText, Currency[19].InnerText, Currency[18].InnerText,
                        Currency[24].InnerText, Currency[25].InnerText, Currency[14].InnerText,
                        Currency[15].InnerText)));
                }
                else
                {
                    UpdateScreen(
                        Currency[26].InnerText, Currency[31].InnerText, Currency[29].InnerText, Currency[28].InnerText,
                        Currency[16].InnerText, Currency[21].InnerText, Currency[19].InnerText, Currency[18].InnerText,
                        Currency[24].InnerText, Currency[25].InnerText, Currency[14].InnerText, Currency[15].InnerText);
                }

                txtLastUpdate.ForeColor = defaultTimeColor;
            }
            catch
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new DelegateUpdateScreen(RefreshError));
                }
                else
                {
                    RefreshError();
                }
            }
        }

        private void RefreshError()
        {
            txtLastUpdate.ForeColor = downColor;
            txtLastUpdate.Text = DateTime.Now.ToLongTimeString();
            //timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            threadPull = new Thread(PullData);
            threadPull.Start();
        }

        private void CheckGoal()
        {
            var dolarGoal = Properties.Settings.Default.DolarGoal;
            var euroGoal = Properties.Settings.Default.EuroGoal;
            var isDolarUp = Properties.Settings.Default.DolarGoalBool;
            var isEuroUp = Properties.Settings.Default.EuroGoalBool;
            var currentDolar = Convert.ToDouble(txtDolar.Text.Replace('.', ','));
            var currentEuro = Convert.ToDouble(txtEuro.Text.Replace('.', ','));

            if (dolarGoal != 0)
            {
                if (dolarGoal > currentDolar)
                {
                    if (!isDolarUp)
                    {
                        Form3.ResetGoal("USD");
                        alertGoalSound.Play();
                        MessageBox.Show(
                            $"Dolar beklediğiniz seviyeye düştü. \n{DateTime.Now} => ({dolarGoal.ToString()} ▼ {currentDolar.ToString()})",
                            "▼ DOLAR DÜŞTÜ ▼");
                    }
                }
                else if (dolarGoal < currentDolar)
                {
                    if (isDolarUp)
                    {
                        Form3.ResetGoal("USD");
                        alertGoalSound.Play();
                        MessageBox.Show(
                            $"Dolar beklediğiniz düzeye ulaştı. \n{DateTime.Now} => ({dolarGoal.ToString()} ▲ {currentDolar.ToString()})",
                            "▲ DOLAR YÜKSELDİ ▲");
                    }
                }
            }

            if (euroGoal != 0)
            {
                if (euroGoal > currentEuro)
                {
                    if (!isEuroUp)
                    {
                        Form3.ResetGoal("EURO");
                        alertGoalSound.Play();
                        MessageBox.Show(
                            $"Euro beklediğiniz seviyeye düştü. \n{DateTime.Now} => ({euroGoal.ToString()} - {currentEuro.ToString()})",
                            "▼ EURO DÜŞTÜ ▼");
                    }
                }
                else if (euroGoal < currentEuro)
                {
                    if (isEuroUp)
                    {
                        Form3.ResetGoal("EURO");
                        alertGoalSound.Play();
                        MessageBox.Show(
                            $"Euro beklediğiniz düzeye ulaştı. \n{DateTime.Now} => ({euroGoal.ToString()} - {currentEuro.ToString()})",
                            "▲ EURO YÜKSELDİ ▲");
                    }
                }
            }
        }

        private void PullData()
        {
            if (InvokeRequired)
            {
                BeginInvoke(new DelegateUpdateScreen(UpdateOldCurrency));
            }
            else
            {
                UpdateOldCurrency();
            }

            UpdateDoviz();

            if (oldDolar == "null" || oldEuro == "null")
            {
                PullData();
                return;
            }

            updateCount++;

            currentDolar = txtDolar.Text;
            currentEuro = txtEuro.Text;

            if (InvokeRequired)
            {
                BeginInvoke(new DelegateUpdateScreen(RefreshRow));
            }
            else
            {
                RefreshRow();
            }

            CheckGoal();
        }

        private void UpdateOldCurrency()
        {
            oldDolar = txtDolar.Text;
            oldEuro = txtEuro.Text;
        }

        private void RefreshRow()
        {
            double _oldDolar = Convert.ToDouble(oldDolar);
            double _oldEuro = Convert.ToDouble(oldEuro);
            double _currentDolar = Convert.ToDouble(currentDolar);
            double _currentEuro = Convert.ToDouble(currentEuro);

            if (_oldDolar < _currentDolar)
            {
                rowDolar.Text = arrowUp;
                rowDolar.ForeColor = upColor;
                txtDolar.ForeColor = upColor;
                PlayAlertSound();
            }
            else if (_oldDolar > _currentDolar)
            {
                rowDolar.Text = arrowDown;
                rowDolar.ForeColor = downColor;
                txtDolar.ForeColor = downColor;
                PlayAlertSound();
            }
            else
            {
                rowDolar.Text = "";
            }

            if (_oldEuro < _currentEuro)
            {
                rowEuro.Text = arrowUp;
                rowEuro.ForeColor = upColor;
                txtEuro.ForeColor = upColor;
                PlayAlertSound();
            }
            else if (_oldEuro > _currentEuro)
            {
                rowEuro.Text = arrowDown;
                rowEuro.ForeColor = downColor;
                txtEuro.ForeColor = downColor;
                PlayAlertSound();
            }
            else
            {
                rowEuro.Text = "";
            }
        }

        private void PlayAlertSound()
        {
            if (alert)
            {
                alertSound.Play();
            }
        }

        private void DefaultColor()
        {
            txtDolar.ForeColor = dolarColor;
            txtEuro.ForeColor = euroColor;
        }

        private void txtClose_MouseHover(object sender, EventArgs e)
        {
            txtClose.ForeColor = Color.Red;
        }

        private void txtClose_MouseLeave(object sender, EventArgs e)
        {
            txtClose.ForeColor = Color.White;
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DefaultColor();
            timer2.Enabled = false;
        }

        private void txtLastUpdate_Click(object sender, EventArgs e)
        {
            string notes = String.Empty;
            string notesTarget =
                "https://raw.githubusercontent.com/bgoktugozdemir/VersionChecker/master/DovizBar/Notes.txt";
            using (WebClient client = new WebClient())
            {
                notes = client.DownloadString(notesTarget);
            }

            MessageBox.Show(notes, $"v{Program.Version}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool CheckVersion()
        {
            string parser = string.Empty;
            string versionTarget =
                "https://raw.githubusercontent.com/bgoktugozdemir/VersionChecker/master/version.json";

            try
            {
                using (WebClient client = new WebClient())
                {
                    parser = client.DownloadString(versionTarget);
                }

                var json = JsonConvert.DeserializeObject<JsonDoviz>(parser);
                Version CurrentVersion = Version.Parse(json.version);

                if (CurrentVersion > Program.Version)
                {
                    if (json.imperativeUpdate)
                    {
                        MessageBox.Show(
                            $"Yeni sürüm mevcut! Bu güncellemeyi indirmeniz gerekmekte. \n({Program.Version} => {CurrentVersion})",
                            "Zorunlu Güncelleme Mevcut", MessageBoxButtons.OK);
                        NewDownloader();
                        return true;
                    }
                    else
                    {
                        if (MessageBox.Show(
                                $"Yeni sürüm mevcut! Güncellemek ister misiniz? \n({Program.Version} => {CurrentVersion})",
                                "Güncelleme Mevcut", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            NewDownloader();
                            return true;
                        }
                    }
                }

                return false;
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(
                    "İnternet bağlantısı bulunamadı ya da Sistem başka bir uygulama tarafından kullanılıyor!\n" +
                    e.ToString(), "Bağlantı Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    private void DownloadUpdate()
        {
            var path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/bgoktugozdemir/VersionChecker/raw/master/DovizBar/D%C3%B6viz%20Bar%20Installer.msi", path + @"/Installer.msi");

                Process setupProcess = Process.Start(path + @"/Installer.msi"); //System.AppDomain.CurrentDomain.BaseDirectory
                Thread thread = new Thread(() => setupProcess.Start());
                this.Close();
            }
        }

        private void NewDownloader()
        {
            var path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/bgoktugozdemir/VersionChecker/raw/master/DovizBar/DovizBar.exe", path + @"/temp.exe");

                Process setupProcess = Process.Start(path + @"/temp.exe");
                Thread thread = new Thread(() => setupProcess.Start());
            }
        }

        private void Updater()
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\DovizBar.exe";
            var pathTemp = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + @"\temp.exe";
            if (AppDomain.CurrentDomain.FriendlyName == "temp.exe")
            {
                File.Delete(path);
                File.Copy(pathTemp, path);
                MessageBox.Show("Güncelleme Başarıyla Tamamlandı!");
                Process process = Process.Start(path);
                Environment.Exit(0);
            }
            else if (AppDomain.CurrentDomain.FriendlyName == "DovizBar.exe")
            {
                if (File.Exists(pathTemp))
                    File.Delete(pathTemp);
            }
            else
            {
                NewDownloader();
            }
        }

        private void alertPrefer_Click(object sender, EventArgs e)
        {
            if (alert)
            {
                alertPrefer.ForeColor = Color.Red;
            }
            else
            {
                alertPrefer.ForeColor = Color.LawnGreen;
            }
            alert = !alert;
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            if (btnExtend.Text == "↓")
            {
                btnExtend.Text = "↑";
                this.Height = this.MaximumSize.Height;
                ChangePosition();
            }
            else if (btnExtend.Text == "↑")
            {
                btnExtend.Text = "↓";
                this.Height = this.MinimumSize.Height;
                ChangePosition();
            }
        }

        private void btnSetUpdateTime_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }

        public void SetRefreshTime()
        {
            timer1.Interval = Properties.Settings.Default.RefreshTime;
            //timer2.Interval = 500;
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            if (Width != this.MaximumSize.Width)
            {
                this.Width = this.MaximumSize.Width;
                lblLeft.Text = ">";
            }
            else
            {
                this.Width = this.MinimumSize.Width;
                lblLeft.Text = "<";
            }
            ChangePosition();
        }

        public static void KeyControl(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtCompareDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(sender, e);
            if (e.KeyChar == (char)13)
            {
                if(txtDolar.Text != "null")
                {
                    if (rbGeneral.Checked)
                    {
                        txtCompareTl.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * Convert.ToDouble(txtDolar.Text.Replace('.', ','))).ToString("0.####");
                        txtCompareEuro.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * (Convert.ToDouble(txtDolar.Text.Replace('.', ',')) / Convert.ToDouble(txtEuro.Text.Replace('.', ',')))).ToString("0.####");
                    }
                    else if (rbBuy.Checked)
                    {
                        txtCompareTl.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * Convert.ToDouble(lblDolarBuy.Text.Replace('.', ','))).ToString("0.####");
                        txtCompareEuro.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * (Convert.ToDouble(lblDolarBuy.Text.Replace('.', ',')) / Convert.ToDouble(lblEuroBuy.Text.Replace('.', ',')))).ToString("0.####");
                    }
                    else if (rbSell.Checked)
                    {
                        txtCompareTl.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * Convert.ToDouble(lblDolarSell.Text.Replace('.', ','))).ToString("0.####");
                        txtCompareEuro.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * (Convert.ToDouble(lblDolarSell.Text.Replace('.', ',')) / Convert.ToDouble(lblEuroSell.Text.Replace('.', ',')))).ToString("0.####");
                    }
                }
            }
        }

        private void txtCompareEuro_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(sender, e);
            if (e.KeyChar == (char)13)
            {
                if (txtEuro.Text != "null")
                { 
                    if (rbGeneral.Checked)
                    {
                        txtCompareTl.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * Convert.ToDouble(txtEuro.Text.Replace('.', ','))).ToString("0.####");
                        txtCompareDolar.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * (Convert.ToDouble(txtEuro.Text.Replace('.', ',')) / Convert.ToDouble(txtDolar.Text.Replace('.', ',')))).ToString("0.####");
                    }
                    else if (rbBuy.Checked)
                    {
                        txtCompareTl.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * Convert.ToDouble(lblEuroBuy.Text.Replace('.', ','))).ToString("0.####");
                        txtCompareDolar.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * (Convert.ToDouble(lblEuroBuy.Text.Replace('.', ',')) / Convert.ToDouble(lblDolarBuy.Text.Replace('.', ',')))).ToString("0.####");
                    }
                    else if (rbSell.Checked)
                    {
                        txtCompareTl.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * Convert.ToDouble(lblEuroSell.Text.Replace('.', ','))).ToString("0.####");
                        txtCompareDolar.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * (Convert.ToDouble(lblEuroSell.Text.Replace('.', ',')) / Convert.ToDouble(lblDolarSell.Text.Replace('.', ',')))).ToString("0.####");
                    }
                }
            }
        }

        private void txtCompareTl_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyControl(sender, e);
            if (e.KeyChar == (char)13)
            {
                if (txtDolar.Text != "null" && txtEuro.Text != "null")
                {
                    txtCompareDolar.Text = (Convert.ToDouble(txtCompareTl.Text.Replace('.', ',')) / Convert.ToDouble(txtDolar.Text.Replace('.', ','))).ToString("0.####");
                    txtCompareEuro.Text = (Convert.ToDouble(txtCompareTl.Text.Replace('.', ',')) / Convert.ToDouble(txtEuro.Text.Replace('.', ','))).ToString("0.####");
                }
            }
        }

        private void txtDolar_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("USD", txtDolar.Text);
            form3.Show();
        }

        private void txtEuro_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3("EURO", txtEuro.Text);
            form3.Show();
        }
    }
}
