
namespace EngineLevelTesting.Forms
{
    partial class ConnectionSettings
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
            this.programsGrid = new System.Windows.Forms.DataGridView();
            this.gridcolName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridcolserver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridcoluser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridcolpassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridcoldbname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.programsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // programsGrid
            // 
            this.programsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.programsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.programsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.programsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gridcolName,
            this.gridcolserver,
            this.gridcoluser,
            this.gridcolpassword,
            this.gridcoldbname});
            this.programsGrid.Location = new System.Drawing.Point(8, 8);
            this.programsGrid.Name = "programsGrid";
            this.programsGrid.RowTemplate.Height = 24;
            this.programsGrid.Size = new System.Drawing.Size(704, 307);
            this.programsGrid.TabIndex = 5;
            this.programsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.programsGrid_CellFormatting);
            // 
            // gridcolName
            // 
            this.gridcolName.HeaderText = "Name";
            this.gridcolName.Name = "gridcolName";
            this.gridcolName.Width = 126;
            // 
            // gridcolserver
            // 
            this.gridcolserver.HeaderText = "Server";
            this.gridcolserver.Name = "gridcolserver";
            this.gridcolserver.Width = 127;
            // 
            // gridcoluser
            // 
            this.gridcoluser.HeaderText = "UserName";
            this.gridcoluser.Name = "gridcoluser";
            this.gridcoluser.Width = 126;
            // 
            // gridcolpassword
            // 
            this.gridcolpassword.HeaderText = "Password";
            this.gridcolpassword.Name = "gridcolpassword";
            this.gridcolpassword.Width = 127;
            // 
            // gridcoldbname
            // 
            this.gridcoldbname.HeaderText = "DB Name";
            this.gridcoldbname.Name = "gridcoldbname";
            this.gridcoldbname.Width = 126;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(477, 321);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(138, 32);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "&Test Connection";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(621, 321);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 32);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ConnectionSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 359);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.programsGrid);
            this.Name = "ConnectionSettings";
            this.Text = "ConnectionSettings";
            this.Load += new System.EventHandler(this.ConnectionSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.programsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView programsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridcolName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridcolserver;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridcoluser;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridcolpassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn gridcoldbname;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnSave;
    }
}