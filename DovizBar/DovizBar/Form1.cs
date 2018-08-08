using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace DovizBar
{
    public partial class Form1 : Form
    {
        private string arrowUp = "▲";
        private string arrowDown = "▼";
        private string oldDolar;
        private string currentDolar;
        private string oldEuro;
        private string currentEuro;
        private Color dolarColor;
        private Color euroColor;
        private Color dolarUpdateColor = Color.Yellow;
        private Color euroUpdateColor = Color.Yellow;
        Uri url = new Uri("https://www.doviz.com");
        private WebClient client;
        HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
        private int position = 1;
        private Screen scr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rowDolar.Text = "";
            rowEuro.Text = "";
            dolarColor = txtDolar.ForeColor;
            euroColor = txtEuro.ForeColor;
            UpdateDoviz();
            scr = Screen.FromPoint(this.Location);
            this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            if (position % 4 == 0)
            {
                this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Top);
                position++;
            }
            else if (position % 4 == 1)
            {
                this.Location = new Point(scr.WorkingArea.Right - this.Width, scr.WorkingArea.Bottom - this.Height);
                position++;
            }
            else if (position % 4 == 2)
            {
                this.Location = new Point(scr.WorkingArea.Left, scr.WorkingArea.Bottom - this.Height);
                position++;
            }
            else if (position % 4 == 3)
            {
                this.Location = new Point(scr.WorkingArea.Left, scr.WorkingArea.Top);
                position++;
            }
        }

        private void UpdateScreen(string dolar, string euro)
        {
            txtDolar.Text = dolar;
            txtEuro.Text = euro;
            txtLastUpdate.Text = DateTime.Now.ToLongTimeString();
        }

        private void UpdateDoviz()
        {
            client = new WebClient();
            string html = client.DownloadString(url);
            document = new HtmlAgilityPack.HtmlDocument();
            document.LoadHtml(html);

            HtmlNodeCollection dovizler = document.DocumentNode.SelectNodes("//span[@class='menu-row2']");
            UpdateScreen(dovizler[1].InnerText, dovizler[2].InnerText);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            oldDolar = txtDolar.Text;
            oldEuro = txtEuro.Text;
            url = new Uri("https://www.doviz.com");
            UpdateDoviz();
            currentDolar = txtDolar.Text;
            currentEuro = txtEuro.Text;
            if (Convert.ToDouble(oldDolar) < Convert.ToDouble(currentDolar))
            {
                rowDolar.Text = arrowUp;
                rowDolar.ForeColor = Color.GreenYellow;
                txtDolar.ForeColor = dolarUpdateColor;
            }
            else if (Convert.ToDouble(oldDolar) > Convert.ToDouble(currentDolar))
            {
                rowDolar.Text = arrowDown;
                rowDolar.ForeColor = Color.Red;
                txtDolar.ForeColor = dolarUpdateColor;
            }

            if (Convert.ToDouble(oldEuro) < Convert.ToDouble(currentEuro))
            {
                rowEuro.Text = arrowUp;
                rowEuro.ForeColor = Color.GreenYellow;
                txtEuro.ForeColor = euroUpdateColor;
            }
            else if (Convert.ToDouble(oldEuro) > Convert.ToDouble(currentEuro))
            {
                rowEuro.Text = arrowDown;
                rowEuro.ForeColor = Color.Red;
                txtEuro.ForeColor = euroUpdateColor;
            }

            timer2.Enabled = true;
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
            MessageBox.Show("Coded with ♥ by bgoktugozdemir", "♥");
        }
    }
}
