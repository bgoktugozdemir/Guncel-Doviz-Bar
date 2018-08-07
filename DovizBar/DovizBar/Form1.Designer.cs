namespace DovizBar
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDolar = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtLastUpdate = new System.Windows.Forms.Label();
            this.rowDolar = new System.Windows.Forms.Label();
            this.rowEuro = new System.Windows.Forms.Label();
            this.txtClose = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOLAR ($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDolar
            // 
            this.txtDolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDolar.AutoSize = true;
            this.txtDolar.BackColor = System.Drawing.Color.Transparent;
            this.txtDolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtDolar.Font = new System.Drawing.Font("Segoe UI Black", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtDolar.ForeColor = System.Drawing.Color.Gold;
            this.txtDolar.Location = new System.Drawing.Point(23, 30);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(55, 30);
            this.txtDolar.TabIndex = 1;
            this.txtDolar.Text = "null";
            this.txtDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "EURO (€)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.AutoSize = true;
            this.txtLastUpdate.BackColor = System.Drawing.Color.Transparent;
            this.txtLastUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLastUpdate.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastUpdate.Location = new System.Drawing.Point(0, 125);
            this.txtLastUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(28, 17);
            this.txtLastUpdate.TabIndex = 4;
            this.txtLastUpdate.Text = "null";
            this.txtLastUpdate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.txtLastUpdate.Click += new System.EventHandler(this.txtLastUpdate_Click);
            // 
            // rowDolar
            // 
            this.rowDolar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rowDolar.AutoSize = true;
            this.rowDolar.BackColor = System.Drawing.Color.Transparent;
            this.rowDolar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.rowDolar.Location = new System.Drawing.Point(-1, 35);
            this.rowDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rowDolar.Name = "rowDolar";
            this.rowDolar.Size = new System.Drawing.Size(29, 23);
            this.rowDolar.TabIndex = 5;
            this.rowDolar.Text = "▲";
            this.rowDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rowEuro
            // 
            this.rowEuro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rowEuro.AutoSize = true;
            this.rowEuro.BackColor = System.Drawing.Color.Transparent;
            this.rowEuro.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.rowEuro.Location = new System.Drawing.Point(2, 88);
            this.rowEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rowEuro.Name = "rowEuro";
            this.rowEuro.Size = new System.Drawing.Size(26, 28);
            this.rowEuro.TabIndex = 6;
            this.rowEuro.Text = "▼";
            this.rowEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rowEuro.UseCompatibleTextRendering = true;
            // 
            // txtClose
            // 
            this.txtClose.AutoSize = true;
            this.txtClose.BackColor = System.Drawing.Color.Transparent;
            this.txtClose.Location = new System.Drawing.Point(101, 121);
            this.txtClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(19, 21);
            this.txtClose.TabIndex = 7;
            this.txtClose.Text = "x";
            this.txtClose.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            this.txtClose.MouseLeave += new System.EventHandler(this.txtClose_MouseLeave);
            this.txtClose.MouseHover += new System.EventHandler(this.txtClose_MouseHover);
            // 
            // txtEuro
            // 
            this.txtEuro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEuro.AutoSize = true;
            this.txtEuro.BackColor = System.Drawing.Color.Transparent;
            this.txtEuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtEuro.Font = new System.Drawing.Font("Segoe UI Black", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtEuro.ForeColor = System.Drawing.Color.Gold;
            this.txtEuro.Location = new System.Drawing.Point(23, 86);
            this.txtEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(55, 30);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.Text = "null";
            this.txtEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 750;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(120, 142);
            this.ControlBox = false;
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.rowEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.rowDolar);
            this.Controls.Add(this.txtLastUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1800, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(120, 142);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(120, 142);
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtLastUpdate;
        private System.Windows.Forms.Label rowDolar;
        private System.Windows.Forms.Label rowEuro;
        private System.Windows.Forms.Label txtClose;
        private System.Windows.Forms.Label txtEuro;
        private System.Windows.Forms.Timer timer2;
    }
}

