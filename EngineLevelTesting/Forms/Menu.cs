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
using Utility.ModifyRegistry;

namespace EngineLevelTesting.Forms
{
    public partial class Menu : Form
    {
        private Dictionary<String, Dictionary<String, String>> dbConnectionSettings = new Dictionary<String, Dictionary<String, String>>();
        static int lastHour = DateTime.Now.Hour;
        public static string adminpass = "System@2022";
        public Menu()
        {
            InitializeComponent();
        }

        private void btnDataEntry_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Forms.Reports frm = new Forms.Reports();
            this.Hide();
            frm.Show();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnafe_Click(object sender, EventArgs e)
        {
            Forms.AfeBoard frm = new Forms.AfeBoard();
            frm.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Get_connection();
        }
        private void Get_connection()
        {
            RegistrySupport registry = new RegistrySupport();
            String data = registry.Read(Def.REGKEY_SUB);
            if (data == null)
            {
                data += String.Format($"ENGINELEVELTESTING<limiter>194.163.32.81<limiter>u867954426_board<limiter>System@2023<limiter>u867954426_board<limiter>");
                registry.Write(Def.REGKEY_SUB, data);
            }
            Utils.SetConnectionDetails();
            this.Text =$"{Assembly.GetExecutingAssembly().GetName().Version.ToString()} - {Utils.DBConnection["ENGINELEVELTESTING"]["DBNAME"].ToString()}";
            dbConnectionSettings = Utils.DBConnection;
        }
        private async void InsertCloudHvcombo()
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                DataTable dtCloud = MySqlDatasupport.RunDataTableDapper("Select * from hvcombo_table where date_record = date_format(now(), '%m/%d/%Y')");
                //DataTable dtCloud = MySqlDatasupport.RunDataTableDapper("Select * from hvcombo_table where date_record = date_format(date_sub(curdate(), interval 3 Day),'%m/%d/%Y')", Class.SqlCon.connectionString(0));
                DataTable dtlocal = MySqlDatasupport.RunDataTableDapper($@"Select *,date_format(date_tested,'%Y-%m-%d %h:%m:%s') as dateTested,date_format(date_stamp,'%Y-%m-%d %h:%m:%s') as dateStamp from hvcombo_table where date_record = date_format(now(), '%m/%d/%Y')");
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
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Failed to Insert!!! \n {ex.Message}");
            }
        }
        private async void InsertCloudAFEboard()
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
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Get_connection();
            timer1.Stop();
            //if (lastHour < DateTime.Now.Hour)
            //{
            //    lastHour = DateTime.Now.Hour;
            //    InsertCloudHvcombo();
            //    InsertCloudAFEboard();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.ManualInsert frm = new Forms.ManualInsert();
            frm.Show();
        }

        private void btnSecc_Click(object sender, EventArgs e)
        {
            Forms.SeccFrm frm = new Forms.SeccFrm();
            frm.Show();
        }

        private void btnpower_Click(object sender, EventArgs e)
        {
            Forms.PowerBoardfrm frm = new Forms.PowerBoardfrm();
            frm.Show();
        }

        private void btnpowermeter_Click(object sender, EventArgs e)
        {
            Forms.PowerMeterfrm frm = new Forms.PowerMeterfrm();
            frm.Show();
        }

        private void btnmcu_Click(object sender, EventArgs e)
        {
            Forms.MCUFrm frm = new Forms.MCUFrm();
            frm.Show();
        }

        private void btnxbu_Click(object sender, EventArgs e)
        {
            Forms.XBUfrm frm = new Forms.XBUfrm();
            frm.Show();
        }

        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminFrm frm = new AdminFrm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                ConnectionSettings connect = new ConnectionSettings();
                connect.ShowDialog();
                dbConnectionSettings = connect.dbConnectionSettings;
                timer1.Start();
                timer1.Interval = 1000;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms.MCU50frm frm = new Forms.MCU50frm();
            frm.Show();
        }

        private void btnopto_Click(object sender, EventArgs e)
        {
            Forms.OptoFRM frm = new Forms.OptoFRM();
            frm.Show();
        }

        private void btnL2fsr_Click(object sender, EventArgs e)
        {
            Forms.Acl2 frm = new Forms.Acl2();
            frm.Show();
        }

        private void btnxbutower_Click(object sender, EventArgs e)
        {
            Forms.XBUTowerfrm frm = new Forms.XBUTowerfrm();
            frm.Show();
        }

        private void btnmcu360_Click(object sender, EventArgs e)
        {
            Forms.MCU360frm frm = new Forms.MCU360frm();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms.MiniPCMfrm frm = new Forms.MiniPCMfrm();
            frm.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            Forms.resetBoardfrm frm = new Forms.resetBoardfrm();
            frm.Show();
        }

        private void btnsecc2_Click(object sender, EventArgs e)
        {
            Forms.Secc2Frm frm = new Forms.Secc2Frm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MCU6_4frm frm = new MCU6_4frm();
            frm.Show();
        }
    }
}
