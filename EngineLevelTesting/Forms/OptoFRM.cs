using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineLevelTesting.Utilities;

namespace EngineLevelTesting.Forms
{
    public partial class OptoFRM : Form
    {
        public OptoFRM()
        {
            InitializeComponent();
            rjCircularPictureBox1.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Saved();
        }
        private async void Saved()
        {
            try
            {
                rjCircularPictureBox1.Show();
                StringBuilder sql = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                    { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                    { "board_serial", txtserial.Text},
                                    { "ipn",cbpn.Text},
                                    { "rev_no",cbrev.Text},
                                    { "tp5v",cb5v.Text},
                                    { "com1",cbcom1.Text},
                                    { "com2",cbcom2.Text},
                                    { "charger_id",cbcharger.Text},
                                    { "readout",cbreadout.Text},
                                    { "log_data",cblogdata.Text},
                                    { "contactor_closes",cbcloses.Text},
                                    { "contactor_opens",cbopens.Text},
                                    { "gfci_leak",cbgfci.Text},
                                    { "status",cbstatus.Text},
                                    { "test_by",txttest.Text},
                                    { "remarks",txtremarks.Text},
                                    { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                    { "date_record", DateTime.Now.ToShortDateString()}
                    };
                sql.Append(MySqlDatasupport.GetInsert("opto_isolator_table", data));
                await Task.Run(() =>
                {
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
            }
            catch (Exception)
            {
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ClearData()
        {
            txtserial.Clear();
            cbpn.SelectedIndex = -1;
            cb5v.SelectedIndex = -1;
            cbrev.SelectedIndex = 1;
            cbcom1.SelectedIndex = -1;
            cbcom2.SelectedIndex = -1;
            cbcharger.SelectedIndex = -1;
            cbreadout.SelectedIndex = -1;
            cblogdata.SelectedIndex = -1;
            cbcloses.SelectedIndex = -1;
            cbopens.SelectedIndex = -1;
            cbgfci.SelectedIndex = -1;
            cbstatus.SelectedIndex = -1;
            txttest.Clear();
            txtremarks.Clear();

        }
    }
}
