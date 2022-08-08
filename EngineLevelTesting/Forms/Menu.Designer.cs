
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnDataEntry = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnafe = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnSecc = new System.Windows.Forms.Button();
            this.btnpower = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDataEntry
            // 
            this.btnDataEntry.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataEntry.Location = new System.Drawing.Point(53, 28);
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
            this.btnReport.Location = new System.Drawing.Point(339, 28);
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
            this.btnafe.Location = new System.Drawing.Point(53, 99);
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
            this.button1.Location = new System.Drawing.Point(339, 99);
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
            this.btnSecc.Location = new System.Drawing.Point(53, 171);
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
            this.btnpower.Location = new System.Drawing.Point(339, 171);
            this.btnpower.Name = "btnpower";
            this.btnpower.Size = new System.Drawing.Size(244, 52);
            this.btnpower.TabIndex = 5;
            this.btnpower.Text = "L2 Powerboard Checklist";
            this.btnpower.UseVisualStyleBackColor = true;
            this.btnpower.Click += new System.EventHandler(this.btnpower_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 257);
            this.Controls.Add(this.btnpower);
            this.Controls.Add(this.btnSecc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnafe);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnDataEntry);
            this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDataEntry;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnafe;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSecc;
        private System.Windows.Forms.Button btnpower;
    }
}