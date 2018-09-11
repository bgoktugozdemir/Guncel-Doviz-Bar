using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static DovizBar.Properties.Settings;
using System.Windows.Forms;

namespace DovizBar
{
    public partial class Form3 : Form
    {
        private static string Type;
        private double currentValue;
        public Form3(string cType, string currentValue)
        {
            Type = cType;
            this.currentValue = Convert.ToDouble(currentValue.Replace('.',','));
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (Type == "USD")
            {
                txtGoal.Text = Default.DolarGoal.ToString();
            }
            else if (Type == "EURO")
            {
                txtGoal.Text = Default.EuroGoal.ToString();
            }
        }

        private void txtGoal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Form1.KeyControl(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Type == "USD")
            {
                Default.DolarGoal = Convert.ToDouble(Convert.ToDouble(txtGoal.Text.Replace('.',',')).ToString("#.0000"));

                if (currentValue > Default.DolarGoal)
                    Default.DolarGoalBool = false;
                else if (currentValue < Default.DolarGoal)
                    Default.DolarGoalBool = true;
            }
            else if (Type == "EURO")
            {
                Default.EuroGoal = Convert.ToDouble(txtGoal.Text.ToString().Replace('.',','));

                if (currentValue > Default.EuroGoal)
                    Default.EuroGoalBool = false;
                else if (currentValue < Default.EuroGoal)
                    Default.EuroGoalBool = true;
            }
            btnClose_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNoGoal_Click(object sender, EventArgs e)
        {
            ResetGoal(Type);   
            btnClose_Click(sender, e);
        }

        public static void ResetGoal(string type)
        {
            if (type == "USD")
            {
                Default.DolarGoal = 0;
                Default.DolarGoalBool = false;
            }
            else if (type == "EURO")
            {
                Default.EuroGoal = 0;
                Default.EuroGoalBool = false;
            }
        }
    }
}
