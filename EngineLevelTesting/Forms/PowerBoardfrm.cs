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
    public partial class PowerBoardfrm : Form
    {
        public PowerBoardfrm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Saved();
        }
        private async void Saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "ipn_number",cbipn.SelectedItem.ToString()},
                                { "board_serial", txtserial.Text},
                                { "rev",txtrev.Text},
                                { "fw_version",txtfirm.Text},
                                { "tp2",txttp2.Text},
                                { "tp3",txttp3.Text},
                                { "tp4",txttp4.Text},
                                { "tp5",txttp5.Text},
                                { "c_open",cbCopn.SelectedItem.ToString()},
                                { "c_closed",cbCclose.SelectedItem.ToString()},
                                { "voltage_plus",txtvoltagePlus.Text},
                                { "gfci_board",txtpn.Text},
                                { "gfci_sn",txtsn.Text},
                                { "leak_detect",cbleak.SelectedItem.ToString()},
                                { "circuit",cbcircuit.SelectedItem.ToString()},
                                { "duty_cycle",cbduty.SelectedItem.ToString()},
                                { "charge_amp_240",txtamp120.Text},
                                { "charge_amp_120",txtamp120.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
            };
            MySqlDatasupport.ID = 1;
            sql.Append(MySqlDatasupport.GetInsert("afe_table", data));
            await Task.Run(() =>
            {
                MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            });
            MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
