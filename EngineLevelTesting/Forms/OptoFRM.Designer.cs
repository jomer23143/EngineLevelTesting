
namespace EngineLevelTesting.Forms
{
    partial class OptoFRM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptoFRM));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtserial = new System.Windows.Forms.TextBox();
            this.cbpn = new System.Windows.Forms.ComboBox();
            this.cbrev = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbcharger = new System.Windows.Forms.ComboBox();
            this.cbcom2 = new System.Windows.Forms.ComboBox();
            this.cbcom1 = new System.Windows.Forms.ComboBox();
            this.cb5v = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbreadout = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cblogdata = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbcloses = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbopens = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbgfci = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbstatus = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttest = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LimeGreen;
            this.panel1.Controls.Add(this.label23);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 42);
            this.panel1.TabIndex = 93;
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(503, 42);
            this.label23.TabIndex = 43;
            this.label23.Text = "Opto-Isolator Board Level Test Data";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(171, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 96;
            this.label2.Text = "Board Serial No. :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(190, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 15);
            this.label3.TabIndex = 97;
            this.label3.Text = "Board P/N No:";
            // 
            // txtserial
            // 
            this.txtserial.BackColor = System.Drawing.Color.SkyBlue;
            this.txtserial.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.Location = new System.Drawing.Point(283, 73);
            this.txtserial.MaxLength = 10;
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(164, 22);
            this.txtserial.TabIndex = 94;
            this.txtserial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbpn
            // 
            this.cbpn.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbpn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbpn.BackColor = System.Drawing.Color.SkyBlue;
            this.cbpn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbpn.FormattingEnabled = true;
            this.cbpn.Items.AddRange(new object[] {
            "110-0234-01"});
            this.cbpn.Location = new System.Drawing.Point(283, 101);
            this.cbpn.Name = "cbpn";
            this.cbpn.Size = new System.Drawing.Size(164, 22);
            this.cbpn.TabIndex = 98;
            // 
            // cbrev
            // 
            this.cbrev.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbrev.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbrev.BackColor = System.Drawing.Color.SkyBlue;
            this.cbrev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbrev.FormattingEnabled = true;
            this.cbrev.Items.AddRange(new object[] {
            "Rev. 00"});
            this.cbrev.Location = new System.Drawing.Point(283, 129);
            this.cbrev.Name = "cbrev";
            this.cbrev.Size = new System.Drawing.Size(164, 22);
            this.cbrev.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(184, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "Board Rev. No.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(129, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 105;
            this.label5.Text = "5V TP Specs: (4.9-5.1)Vdc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(61, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 15);
            this.label6.TabIndex = 106;
            this.label6.Text = "COM1 (Rx Signal) Specs : (4.9-5.1)Vdc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(60, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 15);
            this.label7.TabIndex = 107;
            this.label7.Text = "COM2 (Rx Signal) Specs : (4.9-5.1)Vdc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(110, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 108;
            this.label8.Text = "Charger ID PB S/N (readout):";
            // 
            // cbcharger
            // 
            this.cbcharger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcharger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcharger.BackColor = System.Drawing.Color.SkyBlue;
            this.cbcharger.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcharger.FormattingEnabled = true;
            this.cbcharger.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbcharger.Location = new System.Drawing.Point(281, 232);
            this.cbcharger.Name = "cbcharger";
            this.cbcharger.Size = new System.Drawing.Size(97, 22);
            this.cbcharger.TabIndex = 104;
            // 
            // cbcom2
            // 
            this.cbcom2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcom2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcom2.BackColor = System.Drawing.Color.SkyBlue;
            this.cbcom2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcom2.FormattingEnabled = true;
            this.cbcom2.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.cbcom2.Location = new System.Drawing.Point(281, 207);
            this.cbcom2.Name = "cbcom2";
            this.cbcom2.Size = new System.Drawing.Size(97, 22);
            this.cbcom2.TabIndex = 103;
            // 
            // cbcom1
            // 
            this.cbcom1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcom1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcom1.BackColor = System.Drawing.Color.SkyBlue;
            this.cbcom1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcom1.FormattingEnabled = true;
            this.cbcom1.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.cbcom1.Location = new System.Drawing.Point(281, 182);
            this.cbcom1.Name = "cbcom1";
            this.cbcom1.Size = new System.Drawing.Size(97, 22);
            this.cbcom1.TabIndex = 102;
            // 
            // cb5v
            // 
            this.cb5v.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb5v.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb5v.BackColor = System.Drawing.Color.SkyBlue;
            this.cb5v.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5v.FormattingEnabled = true;
            this.cb5v.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.cb5v.Location = new System.Drawing.Point(281, 157);
            this.cb5v.Name = "cb5v";
            this.cb5v.Size = new System.Drawing.Size(97, 22);
            this.cb5v.TabIndex = 101;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 15);
            this.label4.TabIndex = 110;
            this.label4.Text = "Readout FW Version 6.05 HV Comm? (YES/NO)";
            // 
            // cbreadout
            // 
            this.cbreadout.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbreadout.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbreadout.BackColor = System.Drawing.Color.SkyBlue;
            this.cbreadout.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbreadout.FormattingEnabled = true;
            this.cbreadout.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbreadout.Location = new System.Drawing.Point(281, 258);
            this.cbreadout.Name = "cbreadout";
            this.cbreadout.Size = new System.Drawing.Size(97, 22);
            this.cbreadout.TabIndex = 109;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 15);
            this.label9.TabIndex = 112;
            this.label9.Text = "Log Data Status (readout)\"Online...\"?(YES/NO)";
            // 
            // cblogdata
            // 
            this.cblogdata.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cblogdata.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cblogdata.BackColor = System.Drawing.Color.SkyBlue;
            this.cblogdata.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblogdata.FormattingEnabled = true;
            this.cblogdata.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cblogdata.Location = new System.Drawing.Point(281, 284);
            this.cblogdata.Name = "cblogdata";
            this.cblogdata.Size = new System.Drawing.Size(97, 22);
            this.cblogdata.TabIndex = 111;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(18, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 15);
            this.label10.TabIndex = 114;
            this.label10.Text = "Contactor Closes (ACOut Present=1)?(YES/NO)";
            // 
            // cbcloses
            // 
            this.cbcloses.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcloses.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcloses.BackColor = System.Drawing.Color.SkyBlue;
            this.cbcloses.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcloses.FormattingEnabled = true;
            this.cbcloses.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbcloses.Location = new System.Drawing.Point(282, 308);
            this.cbcloses.Name = "cbcloses";
            this.cbcloses.Size = new System.Drawing.Size(97, 22);
            this.cbcloses.TabIndex = 113;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(18, 334);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 15);
            this.label11.TabIndex = 116;
            this.label11.Text = "Contactor Opens (ACOut Present=1)?(YES/NO)";
            // 
            // cbopens
            // 
            this.cbopens.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbopens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbopens.BackColor = System.Drawing.Color.SkyBlue;
            this.cbopens.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbopens.FormattingEnabled = true;
            this.cbopens.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbopens.Location = new System.Drawing.Point(282, 333);
            this.cbopens.Name = "cbopens";
            this.cbopens.Size = new System.Drawing.Size(97, 22);
            this.cbopens.TabIndex = 115;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(59, 359);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 15);
            this.label12.TabIndex = 118;
            this.label12.Text = "GFCI Leak Detect=1?(readout)(YES/NO)";
            // 
            // cbgfci
            // 
            this.cbgfci.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbgfci.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbgfci.BackColor = System.Drawing.Color.SkyBlue;
            this.cbgfci.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgfci.FormattingEnabled = true;
            this.cbgfci.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cbgfci.Location = new System.Drawing.Point(283, 358);
            this.cbgfci.Name = "cbgfci";
            this.cbgfci.Size = new System.Drawing.Size(97, 22);
            this.cbgfci.TabIndex = 117;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(172, 385);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 15);
            this.label13.TabIndex = 120;
            this.label13.Text = "Status : PASS/FAIL";
            // 
            // cbstatus
            // 
            this.cbstatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbstatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbstatus.BackColor = System.Drawing.Color.SkyBlue;
            this.cbstatus.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbstatus.FormattingEnabled = true;
            this.cbstatus.Items.AddRange(new object[] {
            "PASS",
            "FAIL"});
            this.cbstatus.Location = new System.Drawing.Point(283, 384);
            this.cbstatus.Name = "cbstatus";
            this.cbstatus.Size = new System.Drawing.Size(97, 22);
            this.cbstatus.TabIndex = 119;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(224, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 15);
            this.label14.TabIndex = 122;
            this.label14.Text = "Test by :";
            // 
            // txttest
            // 
            this.txttest.BackColor = System.Drawing.Color.SkyBlue;
            this.txttest.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttest.Location = new System.Drawing.Point(284, 409);
            this.txttest.MaxLength = 100;
            this.txttest.Name = "txttest";
            this.txttest.Size = new System.Drawing.Size(164, 22);
            this.txttest.TabIndex = 121;
            this.txttest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(215, 437);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 15);
            this.label15.TabIndex = 124;
            this.label15.Text = "Remarks :";
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.Color.SkyBlue;
            this.txtremarks.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremarks.Location = new System.Drawing.Point(285, 434);
            this.txtremarks.MaxLength = 500;
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(164, 22);
            this.txtremarks.TabIndex = 123;
            this.txtremarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(364, 462);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 33);
            this.btnsave.TabIndex = 125;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.Transparent;
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.Transparent;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 2;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.Image")));
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(201, 205);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 161;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // OptoFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 510);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txttest);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbstatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cbgfci);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbopens);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbcloses);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cblogdata);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbreadout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbcharger);
            this.Controls.Add(this.cbcom2);
            this.Controls.Add(this.cbcom1);
            this.Controls.Add(this.cb5v);
            this.Controls.Add(this.cbrev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbpn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.panel1);
            this.Name = "OptoFRM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OptoFRM";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.ComboBox cbpn;
        private System.Windows.Forms.ComboBox cbrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbcharger;
        private System.Windows.Forms.ComboBox cbcom2;
        private System.Windows.Forms.ComboBox cbcom1;
        private System.Windows.Forms.ComboBox cb5v;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbreadout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cblogdata;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbcloses;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbopens;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbgfci;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbstatus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttest;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Button btnsave;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
    }
}