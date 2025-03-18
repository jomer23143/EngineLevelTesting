
namespace EngineLevelTesting.Forms
{
    partial class XBUfrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XBUfrm));
            this.btnsave = new System.Windows.Forms.Button();
            this.txttestby = new System.Windows.Forms.TextBox();
            this.txtremarks = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cbjudgement = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt3rd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt2nd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt1st = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtrev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtipn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtserial = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsupervisor_test = new System.Windows.Forms.TextBox();
            this.txtfail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(370, 386);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 34);
            this.btnsave.TabIndex = 83;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txttestby
            // 
            this.txttestby.BackColor = System.Drawing.Color.SkyBlue;
            this.txttestby.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttestby.Location = new System.Drawing.Point(260, 348);
            this.txttestby.MaxLength = 100;
            this.txttestby.Name = "txttestby";
            this.txttestby.Size = new System.Drawing.Size(219, 22);
            this.txttestby.TabIndex = 80;
            this.txttestby.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtremarks
            // 
            this.txtremarks.BackColor = System.Drawing.Color.SkyBlue;
            this.txtremarks.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtremarks.Location = new System.Drawing.Point(260, 323);
            this.txtremarks.MaxLength = 500;
            this.txtremarks.Name = "txtremarks";
            this.txtremarks.Size = new System.Drawing.Size(219, 22);
            this.txtremarks.TabIndex = 79;
            this.txtremarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(183, 350);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 15);
            this.label22.TabIndex = 82;
            this.label22.Text = "Tested By :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(184, 324);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 15);
            this.label21.TabIndex = 81;
            this.label21.Text = "Remarks :";
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
            this.cbjudgement.Location = new System.Drawing.Point(260, 268);
            this.cbjudgement.Name = "cbjudgement";
            this.cbjudgement.Size = new System.Drawing.Size(97, 22);
            this.cbjudgement.TabIndex = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(175, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 77;
            this.label7.Text = "Judgement :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(62, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 15);
            this.label6.TabIndex = 76;
            this.label6.Text = "3rd Charging (1 min per session):";
            // 
            // txt3rd
            // 
            this.txt3rd.BackColor = System.Drawing.Color.SkyBlue;
            this.txt3rd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3rd.Location = new System.Drawing.Point(261, 210);
            this.txt3rd.MaxLength = 12;
            this.txt3rd.Name = "txt3rd";
            this.txt3rd.Size = new System.Drawing.Size(219, 22);
            this.txt3rd.TabIndex = 75;
            this.txt3rd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(60, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 15);
            this.label5.TabIndex = 74;
            this.label5.Text = "2nd Charging (1 min per session):";
            // 
            // txt2nd
            // 
            this.txt2nd.BackColor = System.Drawing.Color.SkyBlue;
            this.txt2nd.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2nd.Location = new System.Drawing.Point(261, 182);
            this.txt2nd.MaxLength = 12;
            this.txt2nd.Name = "txt2nd";
            this.txt2nd.Size = new System.Drawing.Size(219, 22);
            this.txt2nd.TabIndex = 73;
            this.txt2nd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 15);
            this.label4.TabIndex = 72;
            this.label4.Text = "1st Charging (1 min per session):";
            // 
            // txt1st
            // 
            this.txt1st.BackColor = System.Drawing.Color.SkyBlue;
            this.txt1st.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1st.Location = new System.Drawing.Point(261, 154);
            this.txt1st.MaxLength = 12;
            this.txt1st.Name = "txt1st";
            this.txt1st.Size = new System.Drawing.Size(219, 22);
            this.txt1st.TabIndex = 71;
            this.txt1st.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(210, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 70;
            this.label3.Text = "Rev.  :";
            // 
            // txtrev
            // 
            this.txtrev.BackColor = System.Drawing.Color.SkyBlue;
            this.txtrev.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrev.Location = new System.Drawing.Point(261, 126);
            this.txtrev.MaxLength = 100;
            this.txtrev.Name = "txtrev";
            this.txtrev.Size = new System.Drawing.Size(219, 22);
            this.txtrev.TabIndex = 69;
            this.txtrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(169, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 68;
            this.label1.Text = "IPN Number :";
            // 
            // txtipn
            // 
            this.txtipn.BackColor = System.Drawing.Color.SkyBlue;
            this.txtipn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtipn.Location = new System.Drawing.Point(261, 98);
            this.txtipn.MaxLength = 500;
            this.txtipn.Name = "txtipn";
            this.txtipn.Size = new System.Drawing.Size(219, 22);
            this.txtipn.TabIndex = 67;
            this.txtipn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(120, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Board Serial Number :";
            // 
            // txtserial
            // 
            this.txtserial.BackColor = System.Drawing.Color.SkyBlue;
            this.txtserial.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserial.Location = new System.Drawing.Point(261, 70);
            this.txtserial.MaxLength = 100;
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(219, 22);
            this.txtserial.TabIndex = 65;
            this.txtserial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.LimeGreen;
            this.label23.Dock = System.Windows.Forms.DockStyle.Top;
            this.label23.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(497, 41);
            this.label23.TabIndex = 64;
            this.label23.Text = "XBU Tower Board Test";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(203, 148);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(100, 100);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 192;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 15);
            this.label8.TabIndex = 194;
            this.label8.Text = "Supervisor Test Control Box (Request 60A) :";
            // 
            // txtsupervisor_test
            // 
            this.txtsupervisor_test.BackColor = System.Drawing.Color.SkyBlue;
            this.txtsupervisor_test.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupervisor_test.Location = new System.Drawing.Point(260, 238);
            this.txtsupervisor_test.MaxLength = 12;
            this.txtsupervisor_test.Name = "txtsupervisor_test";
            this.txtsupervisor_test.Size = new System.Drawing.Size(219, 22);
            this.txtsupervisor_test.TabIndex = 193;
            this.txtsupervisor_test.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtfail
            // 
            this.txtfail.BackColor = System.Drawing.Color.SkyBlue;
            this.txtfail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfail.Location = new System.Drawing.Point(260, 295);
            this.txtfail.MaxLength = 40;
            this.txtfail.Name = "txtfail";
            this.txtfail.Size = new System.Drawing.Size(219, 22);
            this.txtfail.TabIndex = 195;
            this.txtfail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(82, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 15);
            this.label9.TabIndex = 196;
            this.label9.Text = "Test Failure Details (IF Fail) :";
            // 
            // XBUfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 434);
            this.Controls.Add(this.txtfail);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtsupervisor_test);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttestby);
            this.Controls.Add(this.txtremarks);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.cbjudgement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt3rd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt2nd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt1st);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtrev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtipn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.label23);
            this.Name = "XBUfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XBUfrm";
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txttestby;
        private System.Windows.Forms.TextBox txtremarks;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbjudgement;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt3rd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt2nd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt1st;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtrev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtipn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtserial;
        private System.Windows.Forms.Label label23;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtsupervisor_test;
        private System.Windows.Forms.TextBox txtfail;
        private System.Windows.Forms.Label label9;
    }
}