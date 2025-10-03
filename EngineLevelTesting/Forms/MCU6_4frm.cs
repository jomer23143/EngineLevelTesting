using EngineLevelTesting.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngineLevelTesting.Forms
{
    public partial class MCU6_4frm: Form
    {
        public MCU6_4frm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Saved();
        }
        private async void Saved()
        {
            try
            {
                rjCircularPictureBox1.BringToFront();
                rjCircularPictureBox1.Show();
                StringBuilder sql = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "board_serial", txtserial.Text},
                                { "series_no",txtseriesno.Text},
                                { "ipn_number",txtipn.Text},
                                { "rev_no",txtrev.Text},
                                { "otp_s2",cb_otps2.Text.ToUpper()},
                                { "otp_s",cb_otpS.Text.ToUpper()},
                                { "otp_s7",cb_otpS7.Text.ToUpper()},
                                { "otp_s435",cb_otpS435.Text.ToUpper()},
                                { "otp_s_",cb_otpS_.Text.ToUpper()},
                                { "setting_off",cb_d52_off.Text.ToUpper()},
                                { "setting_on",cb_d52_on.Text.ToUpper()},
                                { "setting_should_off",cb_d52_shouldOff.Text.ToUpper()},
                                { "setting_r375",cb_r375.Text.ToUpper()},
                                { "mcu_type","MCU 6.4"},
                                { "ccr_900",cb900.Text.ToUpper()},
                                { "ccr_1000",cb1000.Text.ToUpper()},
                                { "ccr_1090",cb1090.Text.ToUpper()},
                                { "ccr_1200",cb1200.Text.ToUpper()},
                                { "ccr_1290",cb1290.Text.ToUpper()},
                                { "ccr_1380",cb1380.Text.ToUpper()},
                                { "programming",cbprogramming.Text},
                                { "s2",cbs2.Text},
                                { "s7",cbs7.Text},
                                { "s8",cbs8.Text},
                                { "s3_s4_s5",cbs3s4s5.Text},
                                { "firmware_load",cbfirmload.Text},
                                { "charging1",cbchargingstatus1.Text},
                                { "low_c1_t1",txtlow_c1_t1.Text},
                                { "low_c1_t2",txtlow_c1_t2.Text},
                                { "low_c1_t3",txtlow_c1_t3.Text},
                                { "low_c1_t4",txtlow_c1_t4.Text},
                                { "low_c2_t1",txtlow_c2_t1.Text},
                                { "low_c2_t2",txtlow_c2_t2.Text},
                                { "low_c2_t3",txtlow_c2_t3.Text},
                                { "low_c2_t4",txtlow_c2_t4.Text},
                                { "low_in_t1",txtlow_in_t1.Text},
                                { "low_in_t2",txtlow_in_t2.Text},
                                { "low_out_t1",txtlow_out_t1.Text},
                                { "power_led_on",cbpowerled.Text},
                                { "charging2",cbchargingstatus2.Text},
                                { "high_c1_t1",txthigh_c1_t1.Text},
                                { "high_c1_t2",txthigh_c1_t2.Text},
                                { "high_c1_t3",txthigh_c1_t3.Text},
                                { "high_c1_t4",txthigh_c1_t4.Text},
                                { "high_c2_t1",txthigh_c2_t1.Text},
                                { "high_c2_t2",txthigh_c2_t2.Text},
                                { "high_c2_t3",txthigh_c2_t3.Text},
                                { "high_c2_t4",txthigh_c2_t4.Text},
                                { "high_in_t1",txthigh_in_t1.Text},
                                { "high_in_t2",txthigh_in_t2.Text},
                                { "high_out_t1",txthigh_out_t1.Text},
                                { "power_led_high",cbhighpowerled.Text},
                                { "tok",cbtok.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "test_failure",txttestfail.Text},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("mcu6_series_table", data));
                await Task.Run(() =>
                {
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception)
            {
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Clear()
        {
            txtserial.Clear();
            txtseriesno.Clear();
            txtipn.Clear();
            txtrev.Clear();
            cbprogramming.SelectedIndex = -1;
            cbs2.SelectedIndex = -1;
            cbs7.SelectedIndex = -1;
            cbs8.SelectedIndex = -1;
            cbs3s4s5.SelectedIndex = -1;
            cbfirmload.SelectedIndex = -1;
            cbchargingstatus1.SelectedIndex = -1;
            txtlow_c1_t1.Clear();
            txtlow_c1_t2.Clear();
            txtlow_c1_t3.Clear();
            txtlow_c1_t4.Clear();
            txtlow_c2_t1.Clear();
            txtlow_c2_t2.Clear();
            txtlow_c2_t3.Clear();
            txtlow_c2_t4.Clear();
            txtlow_in_t1.Clear();
            txtlow_in_t2.Clear();
            txtlow_out_t1.Clear();
            cbpowerled.SelectedIndex = -1;
            cbchargingstatus2.SelectedIndex = -1;
            txthigh_c1_t1.Clear();
            txthigh_c1_t2.Clear();
            txthigh_c1_t3.Clear();
            txthigh_c1_t4.Clear();
            txthigh_c2_t1.Clear();
            txthigh_c2_t2.Clear();
            txthigh_c2_t3.Clear();
            txthigh_c2_t4.Clear();
            txthigh_in_t1.Clear();
            txthigh_in_t2.Clear();
            txthigh_out_t1.Clear();
            cbhighpowerled.SelectedIndex = -1;
            cbjudgement.SelectedIndex = -1;
            cbtok.SelectedIndex = -1;
            txtlow_c1_t1.Clear();
            txttestfail.Clear();
            txtremarks.Clear();
            txttestby.Clear();
            cb900.SelectedIndex = -1;
            cb1000.SelectedIndex = -1;
            cb1090.SelectedIndex = -1;
            cb1200.SelectedIndex = -1;
            cb1290.SelectedIndex = -1;
            cb1380.SelectedIndex = -1;
            cb_otpS.SelectedIndex = -1;
            cb_otps2.SelectedIndex = -1;
            cb_otpS435.SelectedIndex = -1;
            cb_otpS7.SelectedIndex = -1;
            cb_otpS_.SelectedIndex = -1;
            cb_d52_off.SelectedIndex = -1;
            cb_d52_on.SelectedIndex = -1;
            cb_d52_shouldOff.SelectedIndex = -1;
            cb_r375.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void MCU6_4frm_Load(object sender, EventArgs e)
        {
            rjCircularPictureBox1.Hide();
        }
    }
}
