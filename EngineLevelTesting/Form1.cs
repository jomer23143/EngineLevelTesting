using EngineLevelTesting.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace EngineLevelTesting
{
    public partial class Form1 : Form
    {
        Class.Connection conn = new Class.Connection();
        bool status = false;
        static int lastHour = DateTime.Now.Hour;
        // bool add = false;
        DateTime date_tested  = new DateTime();
        string date_record = "";
        bool res = false;
        public Form1()
        {
            InitializeComponent();
            txtrev.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForNumericOnly_KeyPress);
            //txtfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            ///txtactualv.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
           /// txtpwm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            ///txt120a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txt25a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txtvoltagepwm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txt400v.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txt800v.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txtafeDC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txt120a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            //txtdclink.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtremarks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForLettersOnly_KeyPress);
            txttestby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForLettersOnly_KeyPress);
            txtversion.Text =String.Format($" v {Assembly.GetExecutingAssembly().GetName().Version.ToString()}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //conn.connections();
            //if (status)
            //{
            //    UpdatedData();
            //}
            //else
            Saved();
            txtserial.Focus();
        }
        private void Saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "board_serial", txtserial.Text},
                                { "board_rev_no",txtrev.Text},
                                { "j13",cbj13.SelectedItem.ToString()},
                                { "j22",cb22.SelectedItem.ToString()},
                                { "j14",cb14.SelectedItem.ToString()},
                                { "j17",cb17.SelectedItem.ToString()},
                                { "firmware_version",txtfirm.Text},
                                { "bc_actual_current",txtactualc.Text},
                                { "bc_actual_voltage",txtactualv.Text},
                                { "current_pwm_multiplier",txtpwm.Text},
                                { "12a_request",txt120a.Text},
                                { "25a_request",txt25a.Text},
                                { "voltage_pwm_multiplier",txtvoltagepwm.Text},
                                { "400voltage",txt400v.Text},
                                { "800voltage",txt800v.Text},
                                { "afe_dc_link_voltage",txtafeDC.Text},
                                { "dc_voltage_resistor",txtdclink.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
            };
            MySqlDatasupport.ID = 1;
            sql.Append(MySqlDatasupport.GetInsert("hvcombo_table", data));
            MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearData();
        }
        private async void UpdatedData()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($"Select board_serial from hvcombo_table where board_serial ='{txtserial.Text}'", Class.SqlCon.connectionString(0));
                StringBuilder sql = new StringBuilder();
                StringBuilder sqlCould = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                    { "board_serial", txtserial.Text},
                                    { "board_rev_no",txtrev.Text},
                                    { "j13",cbj13.SelectedItem.ToString()},
                                    { "j22",cb22.SelectedItem.ToString()},
                                    { "j14",cb14.SelectedItem.ToString()},
                                    { "j17",cb17.SelectedItem.ToString()},
                                    { "firmware_version",txtfirm.Text},
                                    { "bc_actual_current",txtactualc.Text},
                                    { "bc_actual_voltage",txtactualv.Text},
                                    { "current_pwm_multiplier",txtpwm.Text},
                                    { "12a_request",txt120a.Text},
                                    { "25a_request",txt25a.Text},
                                    { "voltage_pwm_multiplier",txtvoltagepwm.Text},
                                    { "400voltage",txt400v.Text},
                                    { "800voltage",txt800v.Text},
                                    { "afe_dc_link_voltage",txtafeDC.Text},
                                    { "dc_voltage_resistor",txtdclink.Text},
                                    { "judgement",cbjudgement.SelectedItem.ToString()},
                                    { "remarks",txtremarks.Text},
                                    { "tested_by",txttestby.Text},
                                    { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}
                    };

                    sql.Append(MySqlDatasupport.GetUpdate("hvcombo_table", data, new List<string> { "board_serial" }));
                    MySqlDatasupport.ID = 1;
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                if (dt.Rows.Count == 0 || dt.Rows[0][0].ToString() == "")
                {
                    data.Add("date_tested", date_tested.ToString("yyyy-MM-dd H:mm:ss"));
                    data.Add("date_record", date_record);
                    sqlCould.Append(MySqlDatasupport.GetInsert("hvcombo_table", data));
                }
                else
                {
                    sqlCould.Append(MySqlDatasupport.GetUpdate("hvcombo_table", data, new List<string> { "board_serial" }));
                }
                await Task.Run(() =>
                {
                    MySqlDatasupport.ID = 0;
                    MySqlDatasupport.RunNonQuery(sqlCould.ToString(), IsolationLevel.ReadCommitted);
                });
                MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearData();
                status = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to Save !!!\n{ex.Message}");
            }
        }
        private async void InsertCloud()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                DataTable dtCloud = MySqlDatasupport.RunDataTableDapper("Select * from hvcombo_table where date_record = date_format(now(), '%m/%d/%Y')", Class.SqlCon.connectionString(0));
                //DataTable dtCloud = MySqlDatasupport.RunDataTableDapper("Select * from hvcombo_table where date_record = date_format(date_sub(curdate(), interval 3 Day),'%m/%d/%Y')", Class.SqlCon.connectionString(0));
                DataTable dtlocal = MySqlDatasupport.RunDataTableDapper($@"Select *,date_format(date_tested,'%Y-%m-%d %h:%m:%s') as dateTested,date_format(date_stamp,'%Y-%m-%d %h:%m:%s') as dateStamp from hvcombo_table where date_record = date_format(now(), '%m/%d/%Y')", Class.SqlCon.connectionString(1));
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
                                    { "j13",datainsert["j13"].ToString()},
                                    { "j22",datainsert["j22"].ToString()},
                                    { "j14",datainsert["j14"].ToString()},
                                    { "j17",datainsert["j17"].ToString()},
                                    { "firmware_version",datainsert["firmware_version"].ToString()},
                                    { "bc_actual_current",datainsert["bc_actual_current"].ToString()},
                                    { "bc_actual_voltage",datainsert["bc_actual_voltage"].ToString()},
                                    { "current_pwm_multiplier",datainsert["current_pwm_multiplier"].ToString()},
                                    { "12a_request",datainsert["12a_request"].ToString()},
                                    { "25a_request",datainsert["25a_request"].ToString()},
                                    { "voltage_pwm_multiplier",datainsert["voltage_pwm_multiplier"].ToString()},
                                    { "400voltage",datainsert["400voltage"].ToString()},
                                    { "800voltage",datainsert["800voltage"].ToString()},
                                    { "afe_dc_link_voltage",datainsert["afe_dc_link_voltage"].ToString()},
                                    { "dc_voltage_resistor",datainsert["dc_voltage_resistor"].ToString()},
                                    { "judgement",datainsert["judgement"].ToString()},
                                    { "remarks",datainsert["remarks"].ToString()},
                                    { "tested_by",datainsert["tested_by"].ToString()},
                                    { "date_stamp", datainsert["dateStamp"].ToString()},
                                    { "date_record", datainsert["date_record"].ToString()}
                    };
                    sql.Append(MySqlDatasupport.GetInsert("hvcombo_table", data));
                }
                await Task.Run(() => 
                { 
                    MySqlDatasupport.ID = 0;
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to Insert!!! \n {ex.Message}");
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region scratch
            //string[] array = length.Split('.');
            //if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            //{
            //    e.Handled = true;
            //}
            //if (array.Length == 2)
            //{
            //    if (e.KeyChar == (char)8)
            //    {
            //        e.Handled = false;
            //        return;
            //    }
            //    //if (array[1].Length == 2)
            //    //{
            //    //    ///char lastCharacter = array[1][array[1].Length - 1];
            //    //    e.Handled = true;
            //    //}
            //}
            //if (Convert.ToInt32(e.KeyChar) == 8) 
            //    return;
            //int result = ".0123456789".IndexOf(s.ToUpper());
            //if (result == -1) e.Handled = true;
            #endregion
            string length = txtfirm.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (length.Length == 7)
            {
                if (e.KeyChar == '.' || e.KeyChar == (char)8)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;

        }

        private void txtfirm_Leave(object sender, EventArgs e)
        {
            ///OnlyTwoDecimal(txtfirm);
        }
        #region Scratch
        //private void OnlyTwoDecimal(TextBox txt)
        //{
        //    string[] array = txt.Text.ToString().Split('.');
        //    if (array.Length > 1)
        //    {
        //        if (array[1].Length > 2)
        //        {
        //            string res = array[1].Substring(0, 2);
        //            txt.Text = array[0] + "." + res;
        //        }
        //    }
        //    if(array.Length == 1)
        //    {
        //        txt.Text = array[0].Substring(0, array[0].Length -2)+"."+array[0].Substring(array[0].Length -2);
        //    }
        //}
        //private void OnlyOneDecimal(TextBox txt)
        //{
        //    string[] array = txt.Text.ToString().Split('.');
        //    if (array.Length > 1)
        //    {
        //        if (array[1].Length + 1 > 2)
        //        {
        //            string res = array[1].Substring(0, 1);
        //            txt.Text = array[0] + "." + res;
        //        }
        //    }
        //    if (!string.IsNullOrEmpty(array[0].ToString()))
        //    {
        //        txt.MaxLength = 6;
        //        txt.Text = array[0].Substring(0, array[0].Length - 1) + "." + array[0].Substring(array[0].Length - 1);
        //    }
        //}
        #endregion
        private void txtactualc_Leave(object sender, EventArgs e)
        {
            ///OnlyOneDecimal(txtactualc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtserial.Focus();
            //System.Timers.Timer aTimer = new System.Timers.Timer(1000); //One second, (use less to add precision, use more to consume less processor time
            //aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            //aTimer.Start();
            timer1.Start();

        }
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            if (lastHour < DateTime.Now.Hour)
            {
                lastHour = DateTime.Now.Hour;
                //InsertCloud();
            }

        }

        private void txtactualc_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txtactualc.Text;
            string s = e.KeyChar.ToString();
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 3)
            {
                //e.Handled = true;
            }
            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;

        }

        private void txtactualv_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txtactualv.Text;
            string s = e.KeyChar.ToString();
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 3)
            {
                ///e.Handled = true;
            }


            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txtpwm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txtpwm.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 1)
            {
                ///e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txt120a_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txt120a.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 3)
            {
               /// e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txt25a_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txt25a.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 2)
            {
                /// e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txtvoltagepwm_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txtvoltagepwm.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 1)
            {
                 ///e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txt400v_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txt400v.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 3)
            {
               /// e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txt800v_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txt800v.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 3)
            {
               /// e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txtafeDC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txtafeDC.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 3)
            {
                 ///e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }

        private void txtdclink_KeyPress(object sender, KeyPressEventArgs e)
        {
            string length = txtdclink.Text;
            string s = e.KeyChar.ToString();
            if (e.KeyChar == '.' && length.IndexOf('.') > -1)
            {
                e.Handled = true;
                return;
            }
            if (Convert.ToInt32(e.KeyChar) == 8) return;
            if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (length.Length == 2)
            {
                ///e.Handled = true;
            }

            int result = ".0123456789".IndexOf(s.ToUpper());
            if (result == -1) e.Handled = true;
        }
        private void ClearData()
        {
            txtserial.Clear();
            txtrev.Clear();
            cbj13.SelectedIndex = -1;
            cb22.SelectedIndex = -1;
            cb14.SelectedIndex = -1;
            cb17.SelectedIndex = -1;
            txtfirm.Clear();
            txtactualc.Clear();
            txtactualv.Clear();
            txtpwm.Clear();
            txt120a.Clear();
            txt25a.Clear();
            txtvoltagepwm.Clear();
            txt400v.Clear();
            txt800v.Clear();
            txtafeDC.Clear();
            txtdclink.Clear();
            cbjudgement.SelectedIndex = -1;
            txtremarks.Clear();
            txttestby.Clear();
        }

        private void txtserial_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private  void txtserial_TextChanged(object sender, EventArgs e)
        {
           GetScanSerial();
        }
        private string GetScanSerial()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($@"Select * from hvcombo_table where board_serial = '{txtserial.Text}'", Class.SqlCon.connectionString(1));
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
                            cbj13.Text = item["j13"].ToString();
                            cb22.Text = item["j22"].ToString();
                            cb14.Text = item["j14"].ToString();
                            cb17.Text = item["j17"].ToString();
                            txtfirm.Text = item["firmware_version"].ToString();
                            txtactualc.Text = item["bc_actual_current"].ToString();
                            txtactualv.Text = item["bc_actual_voltage"].ToString();
                            txtpwm.Text = item["current_pwm_multiplier"].ToString();
                            txt120a.Text = item["12a_request"].ToString();
                            txt25a.Text = item["25a_request"].ToString();
                            txtvoltagepwm.Text = item["voltage_pwm_multiplier"].ToString();
                            txt400v.Text = item["400voltage"].ToString();
                            txt800v.Text = item["800voltage"].ToString();
                            txtafeDC.Text = item["afe_dc_link_voltage"].ToString();
                            txtdclink.Text = item["dc_voltage_resistor"].ToString();
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
                        status = false;
                        res = true;
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

        private void cbj13_Leave(object sender, EventArgs e)
        {
            cbj13.Text = OK_NG(cbj13.Text.ToUpper());
        }
        private string OK_NG(string param)
        {
            if(param.Equals("OK"))
            {
                return param;
            }
            if (param.Equals("NG"))
            {
                return param;
            }
            return "";
        }

        private void cb22_Leave(object sender, EventArgs e)
        {
            cb22.Text = OK_NG(cb22.Text.ToUpper()); ;
        }

        private void cb14_Leave(object sender, EventArgs e)
        {
            cb14.Text = OK_NG(cb14.Text.ToUpper()); ;
        }

        private void cb17_Leave(object sender, EventArgs e)
        {
            cb17.Text = OK_NG(cb17.Text.ToUpper()); ;
        }

        private void cbjudgement_Leave(object sender, EventArgs e)
        {
            if (cbjudgement.Text.ToUpper().Equals("PASS"))
            { }
            else if (cbjudgement.Text.ToUpper().Equals("FAIL"))
            { }
            else
                cbjudgement.Text = "";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.Menu frm = new Forms.Menu();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (lastHour < DateTime.Now.Hour)
            //{
            //    lastHour = DateTime.Now.Hour;
            //    InsertCloud();
            //}
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void txtserial_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtserial_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtserial_Validating(object sender, CancelEventArgs e)
        {
            if (res)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtserial, "Already Exist!!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtserial, "");
            }
        }
    }
}
