using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizBar
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
            txtMilisecond.Text = form1.timer1.Interval.ToString();
        }

        private void txtMilisecond_TextChanged(object sender, EventArgs e)
        {
            if (txtMilisecond.Text != "")
            {
                double second = (Convert.ToDouble(txtMilisecond.Text) / 1000);
                txtSecond.Text = second.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RefreshTime = (Convert.ToInt32(txtMilisecond.Text));
            form1.SetRefreshTime();
            this.Close();
        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {
            if (txtSecond.Text != "")
            {
                txtMilisecond.Text = (Convert.ToDouble(txtSecond.Text) * 1000).ToString();
            }
        }
    }
}
