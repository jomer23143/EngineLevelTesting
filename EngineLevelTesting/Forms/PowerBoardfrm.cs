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
            rjCircularPictureBox1.Show();
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
            rjCircularPictureBox1.Hide();
            MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PowerBoardfrm_Load(object sender, EventArgs e)
        {
            rjCircularPictureBox1.Hide();
        }

        private void txtserial_TextChanged(object sender, EventArgs e)
        {
            GetScanSerial();
        }
        private string GetScanSerial()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($@"Select * from powertable where board_serial = '{txtserial.Text}' and ipn_number ='{cbipn.SelectedItem.ToString()}'", Class.SqlCon.connectionString(1));
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("You are about to overwrite record!!!\nAre you sure want to edit record?\n\nIf viewing purposes please go to report!!!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //res = false;
                        //status = true;
                        foreach (DataRow item in dt.Rows)
                        {
                            txtrev.Text = item["rev"].ToString();
                            txtfirm.Text = item["fw_version"].ToString();
                            txttp2.Text = item["tp2"].ToString();
                            txttp3.Text = item["tp3"].ToString();
                            txttp4.Text = item["tp4"].ToString();
                            txttp5.Text = item["tp5"].ToString();
                            cbCopn.Text = item["c_open"].ToString();
                            cbCclose.Text = item["c_closed"].ToString();
                            txtvoltagePlus.Text = item["voltage_plus"].ToString();
                            txtpn.Text = item["gfci_board"].ToString();
                            txtsn.Text = item["gfci_sn"].ToString();
                            cbleak.Text = item["leak_detect"].ToString();
                            cbcircuit.Text = item["circuit"].ToString();
                            cbduty.Text = item["duty_cycle"].ToString();
                            txtamp240.Text = item["charge_amp_240"].ToString();
                            txtamp120.Text = item["charge_amp_120"].ToString();
                            cbjudgement.Text = item["judgement"].ToString();
                            txtremarks.Text = item["remarks"].ToString();
                            txttestby.Text = item["tested_by"].ToString();
                        }
                        return "Success";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //res = true;
                        //status = false;
                        return "Success";
                    }
                }
                else
                {
                    //res = false;
                }
                return "Success";
            }
            catch (Exception)
            {

                return "Failed";
            }
        }
    }
}
