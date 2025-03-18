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
            txtrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txttp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txttp3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txttp4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txttp5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtvoltagePlus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtamp240.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtamp120.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txttempRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txtserial.ReadOnly = true;
            txtrev.ReadOnly = true;
            txtfirm.ReadOnly = true;
            txttp2.ReadOnly = true;
            txttp3.ReadOnly = true;
            txttp4.ReadOnly = true;
            txttp5.ReadOnly = true;
            txtvoltagePlus.ReadOnly = true;
            //txtpn.ReadOnly = true;
            txtsn.ReadOnly = true;
            txtamp240.ReadOnly = true;
            txtamp120.ReadOnly = true;
            txtremarks.ReadOnly = true;
            txttestby.ReadOnly = true;
            //this.MaximizeBox = false;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtrev.Text) || string.IsNullOrEmpty(txtfirm.Text) || string.IsNullOrEmpty(txttp3.Text) || string.IsNullOrEmpty(txttp4.Text)
                || string.IsNullOrEmpty(txttp5.Text) || string.IsNullOrEmpty(cbCopn.Text) || string.IsNullOrEmpty(cbCclose.Text) || string.IsNullOrEmpty(txtvoltagePlus.Text) || string.IsNullOrEmpty(txttempRead.Text)
                || string.IsNullOrEmpty(txtgfci.Text) || string.IsNullOrEmpty(txtsn.Text) || string.IsNullOrEmpty(cbleak.Text) || string.IsNullOrEmpty(cbcircuit.Text) || string.IsNullOrEmpty(cbduty.Text) || 
                string.IsNullOrEmpty(txtamp240.Text) || string.IsNullOrEmpty(txtamp120.Text) || string.IsNullOrEmpty(cbjudgement.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("Please Input Fields");
            }
            else
                Saved();

        }
        private async void Saved()
        {
            rjCircularPictureBox1.Show();
            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "ipn_number",txtipn.Text},
                                { "board_serial", txtserial.Text},
                                { "version_ul", cbul.Text},
                                { "rev",txtrev.Text},
                                { "fw_version",txtfirm.Text},
                                { "tp2",txttp2.Text},
                                { "tp3",txttp3.Text},
                                { "tp4",txttp4.Text},
                                { "tp5",txttp5.Text},
                                { "c_open",cbCopn.SelectedItem.ToString()},
                                { "c_closed",cbCclose.SelectedItem.ToString()},
                                { "voltage_plus",txtvoltagePlus.Text},
                                { "temp_read",txttempRead.Text},
                                { "gfci_board",txtgfci.Text},
                                { "gfci_sn",txtsn.Text},
                                { "gfci_rev",txtgfci_rev.Text},
                                { "leak_detect",cbleak.SelectedItem.ToString()},
                                { "circuit",cbcircuit.SelectedItem.ToString()},
                                { "duty_cycle",cbduty.SelectedItem.ToString()},
                                { "charge_amp_240",txtamp240.Text},
                                { "charge_amp_120",txtamp120.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
            };
            sql.Append(MySqlDatasupport.GetInsert("powerboard_table", data));
            await Task.Run(() =>
            {
                MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            });
            rjCircularPictureBox1.Hide();
            MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();
        }

        private void PowerBoardfrm_Load(object sender, EventArgs e)
        {
            rjCircularPictureBox1.Hide();
        }

        private void txtserial_TextChanged(object sender, EventArgs e)
        {
            ///GetScanSerial();
        }
        private string GetScanSerial()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($@"Select * from powerboard_table where board_serial = '{txtserial.Text}' and ipn_number ='{txtipn.Text}'");
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
                            txtgfci.Text = item["gfci_board"].ToString();
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
        private void Clear()
        {
            txtserial.Clear();
            txtrev.Clear();
            txtfirm.Clear();
            txttp2.Clear();
            txttp3.Clear();
            txttp4.Clear();
            txttp5.Clear();
            cbCopn.SelectedIndex = -1;
            cbCclose.SelectedIndex = -1;
            txtvoltagePlus.Clear();
            txttempRead.Clear();
            //txtpn.Clear();
            txtgfci_rev.Clear();
            txtsn.Clear();
            cbleak.SelectedIndex = -1;
            cbcircuit.SelectedIndex = -1;
            cbduty.SelectedIndex = -1;
            txtamp240.Clear();
            txtamp120.Clear();
            cbjudgement.SelectedIndex = -1;
            txtremarks.Clear();
            txttestby.Clear();
        }

        private void cbipn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtipn.Text))
            {
                txtserial.ReadOnly = false;
                txtrev.ReadOnly = false;
                txtfirm.ReadOnly = false;
                txttp2.ReadOnly = false;
                txttp3.ReadOnly = false;
                txttp4.ReadOnly = false;
                txttp5.ReadOnly = false;
                txtvoltagePlus.ReadOnly = false;
                //txtpn.ReadOnly = false;
                txtsn.ReadOnly = false;
                txtamp240.ReadOnly = false;
                txtamp120.ReadOnly = false;
                txtremarks.ReadOnly = false;
                txttestby.ReadOnly = false;

            }
            else
            {
                txtserial.ReadOnly = true;
                txtrev.ReadOnly = true;
                txtfirm.ReadOnly = true;
                txttp2.ReadOnly = true;
                txttp3.ReadOnly = true;
                txttp4.ReadOnly = true;
                txttp5.ReadOnly = true;
                txtvoltagePlus.ReadOnly = true;
                //txtpn.ReadOnly = true;
                txtsn.ReadOnly = true;
                txtamp240.ReadOnly = true;
                txtamp120.ReadOnly = true;
                txtremarks.ReadOnly = true;
                txttestby.ReadOnly = true;
            }
        }

        private void txtipn_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtipn.Text))
            {
                txtserial.ReadOnly = false;
                txtrev.ReadOnly = false;
                txtfirm.ReadOnly = false;
                txttp2.ReadOnly = false;
                txttp3.ReadOnly = false;
                txttp4.ReadOnly = false;
                txttp5.ReadOnly = false;
                txtvoltagePlus.ReadOnly = false;
                //txtpn.ReadOnly = false;
                txtsn.ReadOnly = false;
                txtamp240.ReadOnly = false;
                txtamp120.ReadOnly = false;
                txtremarks.ReadOnly = false;
                txttestby.ReadOnly = false;

            }
            else
            {
                txtserial.ReadOnly = true;
                txtrev.ReadOnly = true;
                txtfirm.ReadOnly = true;
                txttp2.ReadOnly = true;
                txttp3.ReadOnly = true;
                txttp4.ReadOnly = true;
                txttp5.ReadOnly = true;
                txtvoltagePlus.ReadOnly = true;
                //txtpn.ReadOnly = true;
                txtsn.ReadOnly = true;
                txtamp240.ReadOnly = true;
                txtamp120.ReadOnly = true;
                txtremarks.ReadOnly = true;
                txttestby.ReadOnly = true;
            }
        }
    }
}
