
namespace EngineLevelTesting.Forms
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuV2));
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnafe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSecc = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.btnpowermeter = new System.Windows.Forms.Button();
            this.btnmcu = new System.Windows.Forms.Button();
            this.btnxbu = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.btnopto = new System.Windows.Forms.Button();
            this.btnL2fsr = new System.Windows.Forms.Button();
            this.btnxbutower = new System.Windows.Forms.Button();
            this.btnmcu360 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnsecc2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataEntry.Location = new System.Drawing.Point(42, 73);
            this.btnDataEntry.Name = "btnDataEntry";
            this.btnDataEntry.Size = new System.Drawing.Size(244, 52);
            this.btnDataEntry.TabIndex = 0;
            this.btnDataEntry.Text = "HvCombo Checklist";
            this.btnDataEntry.UseVisualStyleBackColor = true;
            this.btnDataEntry.Click += new System.EventHandler(this.btnDataEntry_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(980, 140);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(244, 52);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "Reports";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnafe
            // 
            this.btnafe.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafe.Location = new System.Drawing.Point(42, 140);
            this.btnafe.Name = "btnafe";
            this.btnafe.Size = new System.Drawing.Size(244, 52);
            this.btnafe.TabIndex = 2;
            this.btnafe.Text = "AFE Board Checklist";
            this.btnafe.UseVisualStyleBackColor = true;
            this.btnafe.Click += new System.EventHandler(this.btnafe_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(980, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Manual Insert to Cloud";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSecc
            // 
            this.btnSecc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecc.Location = new System.Drawing.Point(339, 73);
            this.btnSecc.Name = "btnSecc";
            this.btnSecc.Size = new System.Drawing.Size(244, 52);
            this.btnSecc.TabIndex = 4;
            this.btnSecc.Text = "SECC Board Checklist";
            this.btnSecc.UseVisualStyleBackColor = true;
            this.btnSecc.Click += new System.EventHandler(this.btnSecc_Click);
            // 
            // btnpower
            // 
            this.btnpower.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpower.Location = new System.Drawing.Point(668, 140);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(244, 52);
            this.btnpower.TabIndex = 5;
            this.btnpower.Text = "L2 Powerboard Checklist";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // btnpowermeter
            // 
            this.btnpowermeter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpowermeter.Location = new System.Drawing.Point(668, 73);
            this.btnpowermeter.Name = "btnpowermeter";
            this.btnpowermeter.Size = new System.Drawing.Size(244, 52);
            this.btnpowermeter.TabIndex = 6;
            this.btnpowermeter.Text = "L2 Power Meter Board Checklist";
            this.btnpowermeter.UseVisualStyleBackColor = true;
            this.btnpowermeter.Click += new System.EventHandler(this.btnpowermeter_Click);
            // 
            // btnmcu
            // 
            this.btnmcu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmcu.Location = new System.Drawing.Point(339, 351);
            this.btnmcu.Name = "btnmcu";
            this.btnmcu.Size = new System.Drawing.Size(244, 52);
            this.btnmcu.TabIndex = 7;
            this.btnmcu.Text = "MCU 6 Series Board Checklist";
            this.btnmcu.UseVisualStyleBackColor = true;
            this.btnmcu.Click += new System.EventHandler(this.btnmcu_Click);
            // 
            // btnxbu
            // 
            this.btnxbu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxbu.Location = new System.Drawing.Point(339, 140);
            this.btnxbu.Name = "btnxbu";
            this.btnxbu.Size = new System.Drawing.Size(244, 52);
            this.btnxbu.TabIndex = 8;
            this.btnxbu.Text = "XBU AIO Board ELT Checklist";
            this.btnxbu.UseVisualStyleBackColor = true;
            this.btnxbu.Click += new System.EventHandler(this.btnxbu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1289, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(42, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 52);
            this.button2.TabIndex = 10;
            this.button2.Text = "MCU 5.0 & 5.1 Board Checklist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnopto
            // 
            this.btnopto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnopto.Location = new System.Drawing.Point(668, 208);
            this.btnopto.Name = "btnopto";
            this.btnopto.Size = new System.Drawing.Size(244, 52);
            this.btnopto.TabIndex = 11;
            this.btnopto.Text = "Opto-Isolator Board Checklist";
            this.btnopto.UseVisualStyleBackColor = true;
            this.btnopto.Click += new System.EventHandler(this.btnopto_Click);
            // 
            // btnL2fsr
            // 
            this.btnL2fsr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnL2fsr.Location = new System.Drawing.Point(668, 281);
            this.btnL2fsr.Name = "btnL2fsr";
            this.btnL2fsr.Size = new System.Drawing.Size(244, 52);
            this.btnL2fsr.TabIndex = 12;
            this.btnL2fsr.Text = "AC L2 FSR SIDE BRACKET SUB-ASSEMBLY";
            this.btnL2fsr.UseVisualStyleBackColor = true;
            this.btnL2fsr.Click += new System.EventHandler(this.btnL2fsr_Click);
            // 
            // btnxbutower
            // 
            this.btnxbutower.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxbutower.Location = new System.Drawing.Point(339, 208);
            this.btnxbutower.Name = "btnxbutower";
            this.btnxbutower.Size = new System.Drawing.Size(244, 52);
            this.btnxbutower.TabIndex = 13;
            this.btnxbutower.Text = "XBU TOWER BOARD CHECKLIST";
            this.btnxbutower.UseVisualStyleBackColor = true;
            this.btnxbutower.Click += new System.EventHandler(this.btnxbutower_Click);
            // 
            // btnmcu360
            // 
            this.btnmcu360.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmcu360.Location = new System.Drawing.Point(339, 281);
            this.btnmcu360.Name = "btnmcu360";
            this.btnmcu360.Size = new System.Drawing.Size(244, 52);
            this.btnmcu360.TabIndex = 14;
            this.btnmcu360.Text = "MCU 360 BOARD CHECKLIST";
            this.btnmcu360.UseVisualStyleBackColor = true;
            this.btnmcu360.Click += new System.EventHandler(this.btnmcu360_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(82, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "GEN 2 BOARDS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(378, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "GEN 4 BOARDS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(695, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "L2 BOARDS";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(42, 281);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 52);
            this.button3.TabIndex = 18;
            this.button3.Text = "MINI PCM 1 AND 2 BOARD CHECKLIST";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(339, 416);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(244, 52);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "Reset Board Checklist";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnsecc2
            // 
            this.btnsecc2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsecc2.Location = new System.Drawing.Point(339, 483);
            this.btnsecc2.Name = "btnsecc2";
            this.btnsecc2.Size = new System.Drawing.Size(244, 52);
            this.btnsecc2.TabIndex = 20;
            this.btnsecc2.Text = "SECC 2.0 Board Checklist";
            this.btnsecc2.UseVisualStyleBackColor = true;
            this.btnsecc2.Click += new System.EventHandler(this.btnsecc2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(339, 541);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 52);
            this.button4.TabIndex = 21;
            this.button4.Text = "MCU 6.4 Board Checklist";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 607);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnsecc2);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmcu360);
            this.Controls.Add(this.btnxbutower);
            this.Controls.Add(this.btnL2fsr);
            this.Controls.Add(this.btnopto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnxbu);
            this.Controls.Add(this.btnmcu);
            this.Controls.Add(this.btnpowermeter);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.btnSecc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnafe);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDataEntry);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnafe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSecc;
        private System.Windows.Forms.Button btnpower;
        private System.Windows.Forms.Button btnpowermeter;
        private System.Windows.Forms.Button btnmcu;
        private System.Windows.Forms.Button btnxbu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnopto;
        private System.Windows.Forms.Button btnL2fsr;
        private System.Windows.Forms.Button btnxbutower;
        private System.Windows.Forms.Button btnmcu360;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnsecc2;
        private System.Windows.Forms.Button button4;
    }
}