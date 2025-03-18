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
    public partial class MCUFrm : Form
    {
        public MCUFrm()
        {
            InitializeComponent();
            rjCircularPictureBox1.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtrev.Text) ||
                string.IsNullOrEmpty(txtlow_c1_t1.Text) || string.IsNullOrEmpty(cbjudgement.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("Please Input all fields!!!");
            }
            else
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

        }

        private void MCUFrm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }
    }
}
