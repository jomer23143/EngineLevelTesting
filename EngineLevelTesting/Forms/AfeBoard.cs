using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineLevelTesting.Utilities;

namespace EngineLevelTesting.Forms
{
    public partial class AfeBoard : Form
    {
        bool status = false;
        static int lastHour = DateTime.Now.Hour;
        // bool add = false;
        DateTime date_tested = new DateTime();
        string date_record = "";
        bool res = false;
        public AfeBoard()
        {
            InitializeComponent();
            txtrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForNumericOnly_KeyPress);
            txtfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtdc25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtdc120.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtdc400.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtdc800.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtafe25.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtdc120.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtafe400.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtafe800.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtswon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtremarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForLettersOnly_KeyPress);
            txttestby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForLettersOnly_KeyPress);
            txtversion.Text = String.Format($" v {Assembly.GetExecutingAssembly().GetName().Version.ToString()}");
        }

        private void AfeBoard_Load(object sender, EventArgs e)
        {
            rjCircularPictureBox1.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //if (status)
            //{
            //    UpdatedData();
            //}
            //else
            Saved();
            txtserial.Focus();
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
                                { "board_rev_no",txtrev.Text},
                                { "j6",cbj6.SelectedItem.ToString()},
                                { "j7",cbj7.SelectedItem.ToString()},
                                { "j4",cbj4 .SelectedItem.ToString()},
                                { "j5",cbj5.SelectedItem.ToString()},
                                { "j2",cbj2.SelectedItem.ToString()},
                                { "j3",cbj3.SelectedItem.ToString()},
                                { "firmware_version",txtfirm.Text},
                                { "dc_25a",txtdc25.Text},
                                { "dc_120a",txtdc120.Text},
                                { "dc_400v",txtdc400.Text},
                                { "dc_800v",txtdc800.Text},
                                { "afe_25a",txtafe25.Text},
                                { "afe_120a",txtafe120.Text},
                                { "afe_400v",txtafe400.Text},
                                { "afe_800v",txtafe800.Text},
                                { "sw_on",txtswon.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("afe_table", data));
                await Task.Run(() =>
                {
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleardata();
            }
            catch (Exception)
            {
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private async void UpdatedData()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($"Select board_serial from afe_table where board_serial ='{txtserial.Text}'", Class.SqlCon.connectionString(0));
                StringBuilder sql = new StringBuilder();
                StringBuilder sqlCould = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                    { "board_serial", txtserial.Text},
                                    { "board_rev_no",txtrev.Text},
                                    { "j6",cbj6.SelectedItem.ToString()},
                                    { "j7",cbj7.SelectedItem.ToString()},
                                    { "j4",cbj4 .SelectedItem.ToString()},
                                    { "j5",cbj5.SelectedItem.ToString()},
                                    { "j2",cbj2.SelectedItem.ToString()},
                                    { "firmware_version",txtfirm.Text},
                                    { "dc_25a",txtdc25.Text},
                                    { "dc_120a",txtdc120.Text},
                                    { "dc_400v",txtdc400.Text},
                                    { "dc_800v",txtdc800.Text},
                                    { "afe_25a",txtafe25.Text},
                                    { "afe_120a",txtafe120.Text},
                                    { "afe_400v",txtafe400.Text},
                                    { "afe_800v",txtafe800.Text},
                                    { "sw_on",txtswon.Text},
                                    { "judgement",cbjudgement.SelectedItem.ToString()},
                                    { "remarks",txtremarks.Text},
                                    { "tested_by",txttestby.Text},
                                    { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}
                    };

                sql.Append(MySqlDatasupport.GetUpdate("afe_table", data, new List<string> { "board_serial" }));
                MySqlDatasupport.ID = 1;
                MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                if (dt.Rows.Count == 0 || dt.Rows[0][0].ToString() == "")
                {
                    data.Add("date_tested", date_tested.ToString("yyyy-MM-dd H:mm:ss"));
                    data.Add("date_record", date_record);
                    sqlCould.Append(MySqlDatasupport.GetInsert("afe_table", data));
                }
                else
                {
                    sqlCould.Append(MySqlDatasupport.GetUpdate("afe_table", data, new List<string> { "board_serial" }));
                }
                await Task.Run(() =>
                {
                    MySqlDatasupport.ID = 0;
                    MySqlDatasupport.RunNonQuery(sqlCould.ToString(), IsolationLevel.ReadCommitted);
                });
                MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleardata();
                status = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Save !!!\n{ex.Message}");
            }
        }
        private string GetScanSerial()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($@"Select * from afe_table where board_serial = '{txtserial.Text}'");
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("You are about to overwrite record!!!\nAre you sure want to edit record?\n\nIf viewing purposes please go to report!!!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        res = false;
                        status = true;
                        foreach (DataRow item in dt.Rows)
                        {
                            txtrev.Text = item["board_rev_no"].ToString();
                            cbj6.Text = item["j6"].ToString();
                            cbj7.Text = item["j7"].ToString();
                            cbj4.Text = item["j4"].ToString();
                            cbj5.Text = item["j5"].ToString();
                            cbj2.Text = item["j2"].ToString();
                            cbj3.Text = item["j3"].ToString();
                            txtfirm.Text = item["firmware_version"].ToString();
                            txtdc25.Text = item["dc_25a"].ToString();
                            txtdc120.Text = item["dc_120a"].ToString();
                            txtdc400.Text = item["dc_400v"].ToString();
                            txtdc800.Text = item["dc_800v"].ToString();
                            txtafe25.Text = item["afe_25a"].ToString();
                            txtafe120.Text = item["afe_120a"].ToString();
                            txtafe400.Text = item["afe_400v"].ToString();
                            txtafe800.Text = item["afe_800v"].ToString();
                            txtswon.Text = item["sw_on"].ToString();
                            cbjudgement.Text = item["judgement"].ToString();
                            txtremarks.Text = item["remarks"].ToString();
                            txttestby.Text = item["tested_by"].ToString();
                            date_tested = Convert.ToDateTime(item["date_tested"].ToString());
                            date_record = item["date_record"].ToString();
                        }
                        return "Success";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        res = true;
                        status = false;
                        return "Success";
                    }
                }
                else
                {
                    res = false;
                }
                return "Success";
            }
            catch (Exception)
            {

                return "Failed";
            }
        }

        private void txtserial_TextChanged(object sender, EventArgs e)
        {
            //GetScanSerial();
        }
        private async void InsertCloud()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                DataTable dtCloud = MySqlDatasupport.RunDataTableDapper("Select * from afe_table where date_record = date_format(now(), '%m/%d/%Y')");
                //DataTable dtCloud = MySqlDatasupport.RunDataTableDapper("Select * from hvcombo_table where date_record = date_format(date_sub(curdate(), interval 3 Day),'%m/%d/%Y')", Class.SqlCon.connectionString(0));
                DataTable dtlocal = MySqlDatasupport.RunDataTableDapper($@"Select *,date_format(date_tested,'%Y-%m-%d %h:%m:%s') as dateTested,date_format(date_stamp,'%Y-%m-%d %h:%m:%s') as dateStamp from afe_table where date_record = date_format(now(), '%m/%d/%Y')");
                //DataTable dtlocal = MySqlDatasupport.RunDataTableDapper($@"Select *,date_format(date_tested,'%Y-%m-%d %h:%m:%s') as dateTested,date_format(date_stamp,'%Y-%m-%d %h:%m:%s') as dateStamp from hvcombo_table where date_record = date_format(date_sub(curdate(), interval 3 Day),'%m/%d/%Y')", Class.SqlCon.connectionString(1));
                foreach (DataRow itemCloud in dtCloud.Rows)
                {
                    DataRow[] row = dtlocal.Select($"board_serial = '{itemCloud["board_serial"].ToString()}'");
                    foreach (DataRow item in row)
                    {
                        dtlocal.Rows.Remove(item);
                    }
                    dtlocal.AcceptChanges();
                }
                if (dtlocal.Rows.Count == 0)
                { return; }

                foreach (DataRow datainsert in dtlocal.Rows)
                {
                    Dictionary<string, object> data = new Dictionary<string, object> {
                                    { "date_tested", datainsert["dateTested"].ToString()},
                                    { "board_serial", datainsert["board_serial"].ToString()},
                                    { "board_rev_no",datainsert["board_rev_no"].ToString()},
                                    { "j6",datainsert["j6"].ToString()},
                                    { "j7",datainsert["j7"].ToString()},
                                    { "j4",datainsert["j4"].ToString()},
                                    { "j5",datainsert["j5"].ToString()},
                                    { "j2",datainsert["j17"].ToString()},
                                    { "j3",datainsert["j17"].ToString()},
                                    { "firmware_version",datainsert["firmware_version"].ToString()},
                                    { "dc_25a",datainsert["dc_25a"].ToString()},
                                    { "dc_120a",datainsert["dc_120a"].ToString()},
                                    { "dc_400v",datainsert["dc_400v"].ToString()},
                                    { "dc_800v",datainsert["dc_800v"].ToString()},
                                    { "afe_25a",datainsert["afe_25a"].ToString()},
                                    { "afe_120a",datainsert["afe_120a"].ToString()},
                                    { "afe_400v",datainsert["afe_400v"].ToString()},
                                    { "afe_800v",datainsert["afe_800v"].ToString()},
                                    { "sw_on",datainsert["sw_on"].ToString()},
                                    { "judgement",datainsert["judgement"].ToString()},
                                    { "remarks",datainsert["remarks"].ToString()},
                                    { "tested_by",datainsert["tested_by"].ToString()},
                                    { "date_stamp", datainsert["dateStamp"].ToString()},
                                    { "date_record", datainsert["date_record"].ToString()}
                    };
                    sql.Append(MySqlDatasupport.GetInsert("afe_table", data));
                }
                await Task.Run(() =>
                {
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to Insert!!! \n {ex.Message}");
            }
            panel1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (lastHour < DateTime.Now.Hour)
            //{
            //    lastHour = DateTime.Now.Hour;
            //    InsertCloud();
            //}
        }
        private void Cleardata()
        {
            txtserial.Clear();
            txtrev.Clear();
            cbj6.SelectedIndex = -1;
            cbj7.SelectedIndex = -1;
            cbj4.SelectedIndex = -1;
            cbj5.SelectedIndex = -1;
            cbj2.SelectedIndex = -1;
            cbj3.SelectedIndex = -1;
            txtfirm.Clear();
            txtdc25.Clear();
            txtdc120.Clear();
            txtdc400.Clear();
            txtdc800.Clear();
            txtafe25.Clear();
            txtafe120.Clear();
            txtafe400.Clear();
            txtafe800.Clear();
            txtswon.Clear();
            cbjudgement.SelectedIndex = -1;
            txtremarks.Clear();
            txttestby.Clear();
        }

        private void txtserial_Validating(object sender, CancelEventArgs e)
        {
            //if (res)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(txtserial, "Already Exist!!!");
            //}
            //else
            //{
            //    e.Cancel = false;
            //    errorProvider1.SetError(txtserial, "");
            //}
        }
    }
}
