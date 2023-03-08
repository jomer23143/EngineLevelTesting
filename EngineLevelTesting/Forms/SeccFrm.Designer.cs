
namespace EngineLevelTesting.Forms
{
    partial class SeccFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SeccFrm));
            this.label23 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtfirm = new System.Windows.Forms.TextBox();
            this.txttestby = new System.Windows.Forms.TextBox();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.cbjudgement = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbsession3 = new System.Windows.Forms.ComboBox();
            this.cbsession2 = new System.Windows.Forms.ComboBox();
            this.cbsession1 = new System.Windows.Forms.ComboBox();
            this.txtserial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtipn = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Lime;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(486, 43);
            this.label23.TabIndex = 44;
            this.label23.Text = "SECC Board Function Test Data (Engine Level Testing)";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtipn);
            this.groupBox1.Controls.Add(this.txtfirm);
            this.groupBox1.Controls.Add(this.txttestby);
            this.groupBox1.Controls.Add(this.txtremarks);
            this.groupBox1.Controls.Add(this.cbjudgement);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbsession3);
            this.groupBox1.Controls.Add(this.cbsession2);
            this.groupBox1.Controls.Add(this.cbsession1);
            this.groupBox1.Controls.Add(this.txtserial);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 365);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IPN: 110-0085-01";
            // 
            // txtfirm
            // 
            this.txtfirm.BackColor = System.Drawing.Color.SkyBlue;
            this.txtfirm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfirm.Location = new System.Drawing.Point(175, 99);
            this.txtfirm.MaxLength = 10;
            this.txtfirm.Name = "txtfirm";
            this.txtfirm.Size = new System.Drawing.Size(164, 22);
            this.txtfirm.TabIndex = 2;
            this.txtfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txttestby
            // 
            this.txttestby.BackColor = System.Drawing.Color.SkyBlue;
            this.txttestby.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttestby.Location = new System.Drawing.Point(174, 287);
            this.txttestby.MaxLength = 20;
            this.txttestby.Name = "txttestby";
            this.txttestby.Size = new System.Drawing.Size(164, 22);
            this.txttestby.TabIndex = 8;
            this.txttestby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.Color.SkyBlue;
            this.txtremarks.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremarks.Location = new System.Drawing.Point(174, 260);
            this.txtremarks.MaxLength = 40;
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(164, 22);
            this.txtremarks.TabIndex = 7;
            this.txtremarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbjudgement
            // 
            this.cbjudgement.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbjudgement.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbjudgement.BackColor = System.Drawing.Color.SkyBlue;
            this.cbjudgement.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbjudgement.FormattingEnabled = true;
            this.cbjudgement.Items.AddRange(new object[] {
            "PASS",
            "FAIL"});
            this.cbjudgement.Location = new System.Drawing.Point(174, 233);
            this.cbjudgement.Name = "cbjudgement";
            this.cbjudgement.Size = new System.Drawing.Size(97, 22);
            this.cbjudgement.TabIndex = 6;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(359, 318);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(85, 36);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(94, 289);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 15);
            this.label22.TabIndex = 117;
            this.label22.Text = "Tested By :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(96, 261);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 15);
            this.label21.TabIndex = 116;
            this.label21.Text = "Remarks :";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(87, 234);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 15);
            this.label20.TabIndex = 115;
            this.label20.Text = "Judgement :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 105;
            this.label2.Text = "Serial Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(92, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 106;
            this.label3.Text = "Firmware :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 18);
            this.label4.TabIndex = 107;
            this.label4.Text = "Changing Status (1 minute per session)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(81, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 15);
            this.label5.TabIndex = 108;
            this.label5.Text = "1st Session :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(76, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 15);
            this.label6.TabIndex = 109;
            this.label6.Text = "2nd Session :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(78, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 110;
            this.label7.Text = "3rd Session :";
            // 
            // cbsession3
            // 
            this.cbsession3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbsession3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbsession3.BackColor = System.Drawing.Color.SkyBlue;
            this.cbsession3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsession3.FormattingEnabled = true;
            this.cbsession3.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.cbsession3.Location = new System.Drawing.Point(174, 203);
            this.cbsession3.Name = "cbsession3";
            this.cbsession3.Size = new System.Drawing.Size(97, 22);
            this.cbsession3.TabIndex = 5;
            // 
            // cbsession2
            // 
            this.cbsession2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbsession2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbsession2.BackColor = System.Drawing.Color.SkyBlue;
            this.cbsession2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsession2.FormattingEnabled = true;
            this.cbsession2.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.cbsession2.Location = new System.Drawing.Point(174, 176);
            this.cbsession2.Name = "cbsession2";
            this.cbsession2.Size = new System.Drawing.Size(97, 22);
            this.cbsession2.TabIndex = 4;
            // 
            // cbsession1
            // 
            this.cbsession1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbsession1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbsession1.BackColor = System.Drawing.Color.SkyBlue;
            this.cbsession1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbsession1.FormattingEnabled = true;
            this.cbsession1.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.cbsession1.Location = new System.Drawing.Point(174, 149);
            this.cbsession1.Name = "cbsession1";
            this.cbsession1.Size = new System.Drawing.Size(97, 22);
            this.cbsession1.TabIndex = 3;
            // 
            // txtserial
            // 
            this.txtserial.BackColor = System.Drawing.Color.SkyBlue;
            this.txtserial.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.Location = new System.Drawing.Point(175, 72);
            this.txtserial.MaxLength = 12;
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(164, 22);
            this.txtserial.TabIndex = 1;
            this.txtserial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtserial.TextChanged += new System.EventHandler(this.txtserial_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 120;
            this.label1.Text = "IPN Rev. No :";
            // 
            // txtipn
            // 
            this.txtipn.BackColor = System.Drawing.Color.SkyBlue;
            this.txtipn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtipn.Location = new System.Drawing.Point(174, 44);
            this.txtipn.MaxLength = 12;
            this.txtipn.Name = "txtipn";
            this.txtipn.Size = new System.Drawing.Size(164, 22);
            this.txtipn.TabIndex = 0;
            this.txtipn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SeccFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 433);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label23);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SeccFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SeccFrm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txttestby;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.ComboBox cbjudgement;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbsession3;
        private System.Windows.Forms.ComboBox cbsession2;
        private System.Windows.Forms.ComboBox cbsession1;
        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.TextBox txtfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtipn;
    }
}