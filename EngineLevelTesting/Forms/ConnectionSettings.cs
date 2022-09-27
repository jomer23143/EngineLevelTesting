using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineLevelTesting.Class;
using EngineLevelTesting.Utilities;
using Utility.ModifyRegistry;

namespace EngineLevelTesting.Forms
{
    public partial class ConnectionSettings : Form
    {
        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (programsGrid.Rows.Count != 1)
            {
                SaveData();
                Utils.SetConnectionDetails();
            }
        }
        private void SaveData()
        {
            String data = "";
            foreach (DataGridViewRow row in programsGrid.Rows)
            {
                // Ignore last row
                if (row.Index == programsGrid.Rows.Count - 1)
                    break;
                String name = row.Cells["gridcolname"].Value.ToString();
                String server = row.Cells["gridcolserver"].Value.ToString();
                String user = row.Cells["gridcoluser"].Value.ToString();
                String password = row.Cells["gridcolpassword"].Value.ToString();
                String dbname = row.Cells["gridcoldbname"].Value.ToString();
                data += String.Format("{0}<limiter>{1}<limiter>{2}<limiter>{3}<limiter>{4}<limiter>", name, server, user, password, dbname);
            }
            RegistrySupport registry = new RegistrySupport();
            if (registry.Write(Def.REGKEY_SUB, data))
            {
                MessageBox.Show("Settings Saved");
                Close();
            }
        }
        private void LoadData()
        {
            try
            {
                RegistrySupport registry = new RegistrySupport();
                String data = registry.Read(Def.REGKEY_SUB);
                if (data == null)
                {
                    data += String.Format($"ATTENDANCEDEPARTMENT<limiter>192.168.0.197<limiter>root<limiter>System@2022<limiter>icehrm<limiter>");
                    registry.Write(Def.REGKEY_SUB, data);
                }
                String[] programs = data.Split(new String[] { "<limiter1>" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (String program in programs)
                {
                    String[] records = program.Split(new String[] { "<limiter>" }, StringSplitOptions.RemoveEmptyEntries);
                    programsGrid.Rows.Add(records);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            LoadData();
            Utils.SetConnectionDetails();
        }

        private void programsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            programsGrid.Rows[e.RowIndex].Tag = e.Value;
            if (programsGrid.Columns[e.ColumnIndex].Name == "gridcolpassword" && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            Class.SqlCon.connections(EngineLevelTesting.Connection.GetConnectionStringReg);
        }
    }
}
