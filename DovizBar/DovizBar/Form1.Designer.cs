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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.alertPrefer = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.txtMinDolar = new System.Windows.Forms.Label();
            this.txtMaxDolar = new System.Windows.Forms.Label();
            this.txtMaxEuro = new System.Windows.Forms.Label();
            this.txtMinEuro = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.btnExtend = new System.Windows.Forms.Label();
            this.txtAverageEuro = new System.Windows.Forms.Label();
            this.txtAverageDolar = new System.Windows.Forms.Label();
            this.percentDolar = new System.Windows.Forms.Label();
            this.percentEuro = new System.Windows.Forms.Label();
            this.btnSetUpdateTime = new System.Windows.Forms.Label();
            this.lblLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCompareEuro = new System.Windows.Forms.TextBox();
            this.txtCompareTl = new System.Windows.Forms.TextBox();
            this.txtCompareDolar = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lblDolarBuy = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDolarSell = new System.Windows.Forms.Label();
            this.lblEuroSell = new System.Windows.Forms.Label();
            this.lblEuroBuy = new System.Windows.Forms.Label();
            this.rbBuy = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbGeneral = new System.Windows.Forms.RadioButton();
            this.rbSell = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(144, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOLAR ($)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDolar
            // 
            this.txtDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDolar.AutoSize = true;
            this.txtDolar.BackColor = System.Drawing.Color.Transparent;
            this.txtDolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtDolar.Font = new System.Drawing.Font("Segoe UI Black", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtDolar.ForeColor = System.Drawing.Color.Gold;
            this.txtDolar.Location = new System.Drawing.Point(143, 126);
            this.txtDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(55, 30);
            this.txtDolar.TabIndex = 1;
            this.txtDolar.Text = "null";
            this.txtDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtDolar.Click += new System.EventHandler(this.txtDolar_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(144, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "EURO (€)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtLastUpdate
            // 
            this.txtLastUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLastUpdate.AutoSize = true;
            this.txtLastUpdate.BackColor = System.Drawing.Color.Transparent;
            this.txtLastUpdate.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLastUpdate.Location = new System.Drawing.Point(120, 224);
            this.txtLastUpdate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtLastUpdate.Name = "txtLastUpdate";
            this.txtLastUpdate.Size = new System.Drawing.Size(19, 12);
            this.txtLastUpdate.TabIndex = 4;
            this.txtLastUpdate.Text = "null";
            this.txtLastUpdate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.txtLastUpdate.Click += new System.EventHandler(this.txtLastUpdate_Click);
            // 
            // rowDolar
            // 
            this.rowDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rowDolar.AutoSize = true;
            this.rowDolar.BackColor = System.Drawing.Color.Transparent;
            this.rowDolar.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.rowDolar.Location = new System.Drawing.Point(119, 131);
            this.rowDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.rowDolar.Name = "rowDolar";
            this.rowDolar.Size = new System.Drawing.Size(29, 23);
            this.rowDolar.TabIndex = 5;
            this.rowDolar.Text = "▲";
            this.rowDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rowEuro
            // 
            this.rowEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rowEuro.AutoSize = true;
            this.rowEuro.BackColor = System.Drawing.Color.Transparent;
            this.rowEuro.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.rowEuro.Location = new System.Drawing.Point(122, 184);
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
            this.txtClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClose.AutoSize = true;
            this.txtClose.BackColor = System.Drawing.Color.Transparent;
            this.txtClose.Location = new System.Drawing.Point(221, 217);
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
            this.txtEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEuro.AutoSize = true;
            this.txtEuro.BackColor = System.Drawing.Color.Transparent;
            this.txtEuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtEuro.Font = new System.Drawing.Font("Segoe UI Black", 16.25F, System.Drawing.FontStyle.Bold);
            this.txtEuro.ForeColor = System.Drawing.Color.Gold;
            this.txtEuro.Location = new System.Drawing.Point(143, 182);
            this.txtEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(55, 30);
            this.txtEuro.TabIndex = 3;
            this.txtEuro.Text = "null";
            this.txtEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtEuro.Click += new System.EventHandler(this.txtEuro_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 750;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // alertPrefer
            // 
            this.alertPrefer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alertPrefer.AutoSize = true;
            this.alertPrefer.BackColor = System.Drawing.Color.Transparent;
            this.alertPrefer.ForeColor = System.Drawing.Color.Red;
            this.alertPrefer.Location = new System.Drawing.Point(195, 218);
            this.alertPrefer.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.alertPrefer.Name = "alertPrefer";
            this.alertPrefer.Size = new System.Drawing.Size(27, 21);
            this.alertPrefer.TabIndex = 8;
            this.alertPrefer.Text = "👂";
            this.alertPrefer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.alertPrefer.Click += new System.EventHandler(this.alertPrefer_Click);
            // 
            // lblDolar
            // 
            this.lblDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolar.AutoSize = true;
            this.lblDolar.BackColor = System.Drawing.Color.Transparent;
            this.lblDolar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDolar.Location = new System.Drawing.Point(119, 6);
            this.lblDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(56, 19);
            this.lblDolar.TabIndex = 9;
            this.lblDolar.Text = "DOLAR";
            this.lblDolar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtMinDolar
            // 
            this.txtMinDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinDolar.AutoSize = true;
            this.txtMinDolar.BackColor = System.Drawing.Color.Transparent;
            this.txtMinDolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtMinDolar.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtMinDolar.ForeColor = System.Drawing.Color.Gold;
            this.txtMinDolar.Location = new System.Drawing.Point(120, 25);
            this.txtMinDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtMinDolar.Name = "txtMinDolar";
            this.txtMinDolar.Size = new System.Drawing.Size(46, 19);
            this.txtMinDolar.TabIndex = 10;
            this.txtMinDolar.Text = "NULL";
            this.txtMinDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxDolar
            // 
            this.txtMaxDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxDolar.AutoSize = true;
            this.txtMaxDolar.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxDolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtMaxDolar.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtMaxDolar.ForeColor = System.Drawing.Color.Gold;
            this.txtMaxDolar.Location = new System.Drawing.Point(120, 63);
            this.txtMaxDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtMaxDolar.Name = "txtMaxDolar";
            this.txtMaxDolar.Size = new System.Drawing.Size(46, 19);
            this.txtMaxDolar.TabIndex = 11;
            this.txtMaxDolar.Text = "NULL";
            this.txtMaxDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxEuro
            // 
            this.txtMaxEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaxEuro.AutoSize = true;
            this.txtMaxEuro.BackColor = System.Drawing.Color.Transparent;
            this.txtMaxEuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtMaxEuro.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtMaxEuro.ForeColor = System.Drawing.Color.Gold;
            this.txtMaxEuro.Location = new System.Drawing.Point(187, 63);
            this.txtMaxEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtMaxEuro.Name = "txtMaxEuro";
            this.txtMaxEuro.Size = new System.Drawing.Size(46, 19);
            this.txtMaxEuro.TabIndex = 14;
            this.txtMaxEuro.Text = "NULL";
            this.txtMaxEuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMinEuro
            // 
            this.txtMinEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinEuro.AutoSize = true;
            this.txtMinEuro.BackColor = System.Drawing.Color.Transparent;
            this.txtMinEuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtMinEuro.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtMinEuro.ForeColor = System.Drawing.Color.Gold;
            this.txtMinEuro.Location = new System.Drawing.Point(187, 25);
            this.txtMinEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtMinEuro.Name = "txtMinEuro";
            this.txtMinEuro.Size = new System.Drawing.Size(46, 19);
            this.txtMinEuro.TabIndex = 13;
            this.txtMinEuro.Text = "NULL";
            this.txtMinEuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEuro
            // 
            this.lblEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEuro.AutoSize = true;
            this.lblEuro.BackColor = System.Drawing.Color.Transparent;
            this.lblEuro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEuro.Location = new System.Drawing.Point(187, 6);
            this.lblEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(46, 19);
            this.lblEuro.TabIndex = 12;
            this.lblEuro.Text = "EURO";
            this.lblEuro.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnExtend
            // 
            this.btnExtend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExtend.AutoSize = true;
            this.btnExtend.BackColor = System.Drawing.Color.Transparent;
            this.btnExtend.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExtend.ForeColor = System.Drawing.Color.MediumOrchid;
            this.btnExtend.Location = new System.Drawing.Point(180, 217);
            this.btnExtend.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(18, 21);
            this.btnExtend.TabIndex = 15;
            this.btnExtend.Text = "↓";
            this.btnExtend.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // txtAverageEuro
            // 
            this.txtAverageEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAverageEuro.AutoSize = true;
            this.txtAverageEuro.BackColor = System.Drawing.Color.Transparent;
            this.txtAverageEuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtAverageEuro.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtAverageEuro.ForeColor = System.Drawing.Color.Gold;
            this.txtAverageEuro.Location = new System.Drawing.Point(187, 44);
            this.txtAverageEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtAverageEuro.Name = "txtAverageEuro";
            this.txtAverageEuro.Size = new System.Drawing.Size(46, 19);
            this.txtAverageEuro.TabIndex = 17;
            this.txtAverageEuro.Text = "NULL";
            this.txtAverageEuro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAverageDolar
            // 
            this.txtAverageDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAverageDolar.AutoSize = true;
            this.txtAverageDolar.BackColor = System.Drawing.Color.Transparent;
            this.txtAverageDolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtAverageDolar.Font = new System.Drawing.Font("Segoe UI Black", 10.25F, System.Drawing.FontStyle.Bold);
            this.txtAverageDolar.ForeColor = System.Drawing.Color.Gold;
            this.txtAverageDolar.Location = new System.Drawing.Point(120, 44);
            this.txtAverageDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txtAverageDolar.Name = "txtAverageDolar";
            this.txtAverageDolar.Size = new System.Drawing.Size(46, 19);
            this.txtAverageDolar.TabIndex = 16;
            this.txtAverageDolar.Text = "NULL";
            this.txtAverageDolar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // percentDolar
            // 
            this.percentDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.percentDolar.AutoSize = true;
            this.percentDolar.BackColor = System.Drawing.Color.Transparent;
            this.percentDolar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percentDolar.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.percentDolar.ForeColor = System.Drawing.Color.Gold;
            this.percentDolar.Location = new System.Drawing.Point(121, 82);
            this.percentDolar.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.percentDolar.Name = "percentDolar";
            this.percentDolar.Size = new System.Drawing.Size(28, 17);
            this.percentDolar.TabIndex = 18;
            this.percentDolar.Text = "null";
            this.percentDolar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // percentEuro
            // 
            this.percentEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.percentEuro.AutoSize = true;
            this.percentEuro.BackColor = System.Drawing.Color.Transparent;
            this.percentEuro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.percentEuro.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.percentEuro.ForeColor = System.Drawing.Color.Gold;
            this.percentEuro.Location = new System.Drawing.Point(188, 82);
            this.percentEuro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.percentEuro.Name = "percentEuro";
            this.percentEuro.Size = new System.Drawing.Size(28, 17);
            this.percentEuro.TabIndex = 19;
            this.percentEuro.Text = "null";
            this.percentEuro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSetUpdateTime
            // 
            this.btnSetUpdateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetUpdateTime.AutoSize = true;
            this.btnSetUpdateTime.BackColor = System.Drawing.Color.Transparent;
            this.btnSetUpdateTime.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSetUpdateTime.ForeColor = System.Drawing.Color.Orange;
            this.btnSetUpdateTime.Location = new System.Drawing.Point(162, 219);
            this.btnSetUpdateTime.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSetUpdateTime.Name = "btnSetUpdateTime";
            this.btnSetUpdateTime.Size = new System.Drawing.Size(22, 17);
            this.btnSetUpdateTime.TabIndex = 20;
            this.btnSetUpdateTime.Text = "⏰";
            this.btnSetUpdateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSetUpdateTime.Click += new System.EventHandler(this.btnSetUpdateTime_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLeft.AutoSize = true;
            this.lblLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblLeft.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLeft.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblLeft.Location = new System.Drawing.Point(120, 105);
            this.lblLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(21, 21);
            this.lblLeft.TabIndex = 21;
            this.lblLeft.Text = "<";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLeft.Click += new System.EventHandler(this.lblLeft_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(2, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "DOLAR";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(2, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "EURO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(2, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "TL";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCompareEuro
            // 
            this.txtCompareEuro.AccessibleDescription = "Elinizdeki parayı buraya girebilirsiniz.";
            this.txtCompareEuro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompareEuro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.txtCompareEuro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompareEuro.ForeColor = System.Drawing.Color.Gold;
            this.txtCompareEuro.Location = new System.Drawing.Point(6, 163);
            this.txtCompareEuro.Name = "txtCompareEuro";
            this.txtCompareEuro.Size = new System.Drawing.Size(93, 25);
            this.txtCompareEuro.TabIndex = 27;
            this.txtCompareEuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompareEuro_KeyPress);
            // 
            // txtCompareTl
            // 
            this.txtCompareTl.AccessibleDescription = "Elinizdeki parayı buraya girebilirsiniz.";
            this.txtCompareTl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompareTl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.txtCompareTl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompareTl.ForeColor = System.Drawing.Color.Gold;
            this.txtCompareTl.Location = new System.Drawing.Point(6, 205);
            this.txtCompareTl.Name = "txtCompareTl";
            this.txtCompareTl.Size = new System.Drawing.Size(93, 25);
            this.txtCompareTl.TabIndex = 28;
            this.txtCompareTl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompareTl_KeyPress);
            // 
            // txtCompareDolar
            // 
            this.txtCompareDolar.AccessibleDescription = "Elinizdeki parayı buraya girebilirsiniz.";
            this.txtCompareDolar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompareDolar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.txtCompareDolar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCompareDolar.ForeColor = System.Drawing.Color.Gold;
            this.txtCompareDolar.Location = new System.Drawing.Point(6, 120);
            this.txtCompareDolar.Name = "txtCompareDolar";
            this.txtCompareDolar.Size = new System.Drawing.Size(93, 25);
            this.txtCompareDolar.TabIndex = 26;
            this.txtCompareDolar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCompareDolar_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(35, 57);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "EURO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolarBuy
            // 
            this.lblDolarBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolarBuy.AutoSize = true;
            this.lblDolarBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDolarBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolarBuy.ForeColor = System.Drawing.Color.Gold;
            this.lblDolarBuy.Location = new System.Drawing.Point(3, 40);
            this.lblDolarBuy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDolarBuy.Name = "lblDolarBuy";
            this.lblDolarBuy.Size = new System.Drawing.Size(39, 17);
            this.lblDolarBuy.TabIndex = 30;
            this.lblDolarBuy.Text = "NULL";
            this.lblDolarBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(30, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "DOLAR";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDolarSell
            // 
            this.lblDolarSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDolarSell.AutoSize = true;
            this.lblDolarSell.BackColor = System.Drawing.Color.Transparent;
            this.lblDolarSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDolarSell.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDolarSell.ForeColor = System.Drawing.Color.Gold;
            this.lblDolarSell.Location = new System.Drawing.Point(75, 40);
            this.lblDolarSell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDolarSell.Name = "lblDolarSell";
            this.lblDolarSell.Size = new System.Drawing.Size(39, 17);
            this.lblDolarSell.TabIndex = 33;
            this.lblDolarSell.Text = "NULL";
            this.lblDolarSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEuroSell
            // 
            this.lblEuroSell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEuroSell.AutoSize = true;
            this.lblEuroSell.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroSell.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEuroSell.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroSell.ForeColor = System.Drawing.Color.Gold;
            this.lblEuroSell.Location = new System.Drawing.Point(75, 76);
            this.lblEuroSell.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEuroSell.Name = "lblEuroSell";
            this.lblEuroSell.Size = new System.Drawing.Size(39, 17);
            this.lblEuroSell.TabIndex = 35;
            this.lblEuroSell.Text = "NULL";
            this.lblEuroSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEuroBuy
            // 
            this.lblEuroBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEuroBuy.AutoSize = true;
            this.lblEuroBuy.BackColor = System.Drawing.Color.Transparent;
            this.lblEuroBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEuroBuy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuroBuy.ForeColor = System.Drawing.Color.Gold;
            this.lblEuroBuy.Location = new System.Drawing.Point(3, 76);
            this.lblEuroBuy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEuroBuy.Name = "lblEuroBuy";
            this.lblEuroBuy.Size = new System.Drawing.Size(39, 17);
            this.lblEuroBuy.TabIndex = 34;
            this.lblEuroBuy.Text = "NULL";
            this.lblEuroBuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rbBuy
            // 
            this.rbBuy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbBuy.AutoSize = true;
            this.rbBuy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbBuy.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbBuy.Location = new System.Drawing.Point(16, 3);
            this.rbBuy.Name = "rbBuy";
            this.rbBuy.Size = new System.Drawing.Size(45, 21);
            this.rbBuy.TabIndex = 36;
            this.rbBuy.Text = "Alış";
            this.rbBuy.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.rbGeneral);
            this.panel1.Controls.Add(this.rbSell);
            this.panel1.Controls.Add(this.rbBuy);
            this.panel1.Location = new System.Drawing.Point(50, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(64, 109);
            this.panel1.TabIndex = 37;
            // 
            // rbGeneral
            // 
            this.rbGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbGeneral.AutoSize = true;
            this.rbGeneral.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbGeneral.Checked = true;
            this.rbGeneral.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbGeneral.Location = new System.Drawing.Point(2, 88);
            this.rbGeneral.Name = "rbGeneral";
            this.rbGeneral.Size = new System.Drawing.Size(59, 21);
            this.rbGeneral.TabIndex = 38;
            this.rbGeneral.TabStop = true;
            this.rbGeneral.Text = "Genel";
            this.rbGeneral.UseVisualStyleBackColor = true;
            // 
            // rbSell
            // 
            this.rbSell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rbSell.AutoSize = true;
            this.rbSell.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbSell.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbSell.Location = new System.Drawing.Point(9, 48);
            this.rbSell.Name = "rbSell";
            this.rbSell.Size = new System.Drawing.Size(52, 21);
            this.rbSell.TabIndex = 37;
            this.rbSell.Text = "Satış";
            this.rbSell.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lavender;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "ALIŞ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Lavender;
            this.label8.Location = new System.Drawing.Point(71, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "SATIŞ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(97)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 238);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblEuroSell);
            this.Controls.Add(this.lblEuroBuy);
            this.Controls.Add(this.lblDolarSell);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDolarBuy);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCompareTl);
            this.Controls.Add(this.txtCompareEuro);
            this.Controls.Add(this.txtCompareDolar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.btnSetUpdateTime);
            this.Controls.Add(this.percentEuro);
            this.Controls.Add(this.percentDolar);
            this.Controls.Add(this.txtAverageEuro);
            this.Controls.Add(this.txtAverageDolar);
            this.Controls.Add(this.btnExtend);
            this.Controls.Add(this.alertPrefer);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.rowEuro);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.rowDolar);
            this.Controls.Add(this.txtLastUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaxEuro);
            this.Controls.Add(this.txtMinEuro);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.txtMaxDolar);
            this.Controls.Add(this.txtMinDolar);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1800, 0);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(240, 238);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(120, 142);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Döviz Bar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDolar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtLastUpdate;
        private System.Windows.Forms.Label rowDolar;
        private System.Windows.Forms.Label rowEuro;
        private System.Windows.Forms.Label txtClose;
        private System.Windows.Forms.Label txtEuro;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label alertPrefer;
        private System.Windows.Forms.Label lblDolar;
        private System.Windows.Forms.Label txtMinDolar;
        private System.Windows.Forms.Label txtMaxDolar;
        private System.Windows.Forms.Label txtMaxEuro;
        private System.Windows.Forms.Label txtMinEuro;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label btnExtend;
        private System.Windows.Forms.Label txtAverageEuro;
        private System.Windows.Forms.Label txtAverageDolar;
        private System.Windows.Forms.Label percentDolar;
        private System.Windows.Forms.Label percentEuro;
        private System.Windows.Forms.Label btnSetUpdateTime;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompareEuro;
        private System.Windows.Forms.TextBox txtCompareTl;
        private System.Windows.Forms.TextBox txtCompareDolar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDolarBuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDolarSell;
        private System.Windows.Forms.Label lblEuroSell;
        private System.Windows.Forms.Label lblEuroBuy;
        private System.Windows.Forms.RadioButton rbBuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSell;
        private System.Windows.Forms.RadioButton rbGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
    }
} 