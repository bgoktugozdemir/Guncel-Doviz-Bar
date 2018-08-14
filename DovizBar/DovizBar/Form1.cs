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

namespace DovizBar
{
    public partial class Form1 : Form
    {
        private const double Version = 1.0;
        private double averageDolar = 0;
        private int updateCount = 2; //Thread -> 1, Normal -> 2
        private double averageEuro = 0;
        private string arrowUp = "▲";
        private Color upColor = Color.GreenYellow;
        private string arrowDown = "▼";
        private Color downColor = Color.Red;
        private string oldDolar;
        private string currentDolar;
        private string oldEuro;
        private string currentEuro;
        private Color dolarColor;
        private Color euroColor;
        private Color dolarUpdateColor = Color.Yellow;
        private Color euroUpdateColor = Color.Yellow;
        private Color defaultTimeColor = Color.White;

        Uri url = new Uri(@"https://www.widgets.investing.com/single-currency-crosses?theme=darkTheme&currency=9");
        string html = String.Empty;

        //Uri url = new Uri("https://www.doviz.com");
        private WebClient client;
        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        private int position = 0;
        private Screen scr;
        private bool alert = false;
        SoundPlayer alertSound = new SoundPlayer(Properties.Resources.AlertSound_2);



        public Form1()
        {
            //CheckVersion();
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

            SetRefreshTime();
            timer1.Enabled = true;
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            position++;
            ChangePosition();
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

        private void UpdateScreen(string dolar, string percentDolar, string minDolar, string maxDolar, string euro, string percentEuro, string minEuro, string maxEuro)
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

            averageDolar += Convert.ToDouble(dolar.Replace('.',','));
            averageEuro += Convert.ToDouble(euro.Replace('.',','));
            txtAverageDolar.Text = (averageDolar / updateCount).ToString(".0000");
            txtAverageEuro.Text = (averageEuro / updateCount).ToString(".0000");

            var oldUpdateTime = txtLastUpdate.Text;
            txtLastUpdate.Text = DateTime.Now.ToLongTimeString();
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
                if (InvokeRequired)
                {
                    BeginInvoke(new DelegateUpdateScreen(() => UpdateScreen(
                        Currency[18].InnerText, Currency[23].InnerText, Currency[21].InnerText, Currency[20].InnerText,
                        Currency[28].InnerText, Currency[33].InnerText, Currency[31].InnerText, Currency[30].InnerText)));
                }
                else
                {
                    UpdateScreen(
                        Currency[18].InnerText, Currency[23].InnerText, Currency[21].InnerText, Currency[20].InnerText,
                        Currency[28].InnerText, Currency[33].InnerText, Currency[31].InnerText, Currency[30].InnerText);
                }

                txtLastUpdate.ForeColor = defaultTimeColor;
            }
            catch (Exception e)
            {
                if (InvokeRequired)
                {
                    BeginInvoke(new DelegateUpdateScreen(RefreshError));
                }
                else
                {
                    RefreshError();
                }

                timer1.Enabled = true;
            }
            finally
            {
                timer1.Enabled = true;
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
            PullData();
        }

        private void PullData()
        {
            oldDolar = txtDolar.Text;
            oldEuro = txtEuro.Text;

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

            timer2.Enabled = true;
        }

        private void RefreshRow()
        {
            if (Convert.ToDouble(oldDolar) < Convert.ToDouble(currentDolar))
            {
                rowDolar.Text = arrowUp;
                rowDolar.ForeColor = upColor;
                txtDolar.ForeColor = dolarUpdateColor;
                PlayAlertSound();
            }
            else if (Convert.ToDouble(oldDolar) > Convert.ToDouble(currentDolar))
            {
                rowDolar.Text = arrowDown;
                rowDolar.ForeColor = downColor;
                txtDolar.ForeColor = dolarUpdateColor;
                PlayAlertSound();
            }

            if (Convert.ToDouble(oldEuro) < Convert.ToDouble(currentEuro))
            {
                rowEuro.Text = arrowUp;
                rowEuro.ForeColor = upColor;
                txtEuro.ForeColor = euroUpdateColor;
                PlayAlertSound();
            }
            else if (Convert.ToDouble(oldEuro) > Convert.ToDouble(currentEuro))
            {
                rowEuro.Text = arrowDown;
                rowEuro.ForeColor = downColor;
                txtEuro.ForeColor = euroUpdateColor;
                PlayAlertSound();
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
            MessageBox.Show("Coded with ♥ by bgoktugozdemir", $"v{Version}");
        }

        private void CheckVersion()
        {
            string parser;
            //string currentVersion = string.Empty;
            string versionTarget = "https://raw.githubusercontent.com/bgoktugozdemir/VersionChecker/master/version.json";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(versionTarget);
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    parser = reader.ReadToEnd();
                }

                var json = JsonConvert.DeserializeObject<JsonDoviz>(parser);
                double CurrentVersion = json.version;

                if (CurrentVersion > Version)
                {
                    if (json.imperativeUpdate)
                    {
                        MessageBox.Show($"Yeni sürüm mevcut! Bu güncellemeyi indirmeniz gerekmekte. {Version} => {CurrentVersion}","Zorunlu Güncelleme Mevcut", MessageBoxButtons.OK);
                        DownloadUpdate();
                    }
                    else
                    {
                        if (MessageBox.Show($"Yeni sürüm mevcut! Güncellemek ister misiniz? {Version} => {CurrentVersion}", "Güncelleme Mevcut", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            DownloadUpdate();
                        }
                    }
                }
            }
            catch (System.Net.WebException e)
            {
                MessageBox.Show(e.ToString());
                MessageBox.Show("İnternet bağlantısı bulunamadı!", "Bağlantı Yok", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DownloadUpdate()
        {
            var path = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            using (var client = new WebClient())
            {
                client.DownloadFile("https://github.com/bgoktugozdemir/VersionChecker/raw/master/DovizBar/DovizBar_Updater.exe", path + @"/Installer.exe");

                Process setupProcess = Process.Start(path + @"/Installer.exe"); //System.AppDomain.CurrentDomain.BaseDirectory
                setupProcess.Start();
                Application.Exit();
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
            //SetRefreshTime();
        }

        public void SetRefreshTime()
        {
            timer1.Interval = Properties.Settings.Default.RefreshTime;
            timer2.Interval = 500;
        }

        private void lblLeft_Click(object sender, EventArgs e)
        {
            if (Width != this.MaximumSize.Width)
            {
                this.Width = this.MaximumSize.Width;
                lblLeft.Text = ">";
                timer1.Interval = 10000;
            }
            else
            {
                this.Width = this.MinimumSize.Width;
                lblLeft.Text = "<";
                SetRefreshTime();
            }
            ChangePosition();
        }

        private void KeyControl(object sender, KeyPressEventArgs e)
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
                    txtCompareTl.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * Convert.ToDouble(txtDolar.Text.Replace('.', ','))).ToString("0.####");
                    txtCompareEuro.Text = (Convert.ToDouble(txtCompareDolar.Text.Replace('.', ',')) * (Convert.ToDouble(txtDolar.Text.Replace('.', ',')) / Convert.ToDouble(txtEuro.Text.Replace('.', ',')))).ToString("0.####");
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
                    txtCompareTl.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * Convert.ToDouble(txtEuro.Text.Replace('.', ','))).ToString("0.####");
                    txtCompareDolar.Text = (Convert.ToDouble(txtCompareEuro.Text.Replace('.', ',')) * (Convert.ToDouble(txtEuro.Text.Replace('.', ',')) / Convert.ToDouble(txtDolar.Text.Replace('.', ',')))).ToString("0.####");
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
    }
}
