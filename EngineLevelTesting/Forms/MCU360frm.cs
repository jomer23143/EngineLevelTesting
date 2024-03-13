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
    public partial class MCU360frm : Form
    {
        public MCU360frm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtrev.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("No empty fields plss...");
                return;
            }
            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                { "date_tested",DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}
                ,{ "board_serial",txtserial.Text}
                ,{ "ipn_number",txtipn.Text}
                ,{ "rev_no",txtrev.Text}
                ,{ "programming",cbprogramming.Text}
                ,{ "board_d10",cbstat_d10.Text}
                ,{ "board_d13",cbstat_d13.Text}
                ,{ "board_d29",cbstat_d29.Text}
                ,{ "board_d36",cbstat_d36.Text}
                ,{ "jig_d38",cbstat_d38.Text}
                ,{ "jig_d28",cbstat_d28.Text}
                ,{ "jig_d2",cbstat_d2.Text}
                ,{ "jig_d7",cbstat_d7.Text}
                ,{ "jig_d1",cbstat_d1.Text}
                ,{ "charge_stat",cbcharge_stat.Text}
                ,{ "judgement",cbjudge.Text}
                ,{ "stick_attc",cbstick_attc.Text}
                ,{ "test_fail",txttest_fail.Text}
                ,{ "testby",txttestby.Text}
                ,{ "remarks",txtremarks.Text}
                ,{ "date_stamp",DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")}
                ,{ "date_record",DateTime.Now.ToShortDateString() }
            };

            sql.Append(MySqlDatasupport.GetInsert("mcu_360_table", data));
            MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            ClearField();
            MessageBox.Show("Successfully Saved");
        }
        private void ClearField()
        {
            txtserial.Clear();
            txtipn.Clear();
            txtrev.Clear();
            cbprogramming.SelectedIndex = -1;
            cbstat_d10.SelectedIndex = -1;
            cbstat_d13.SelectedIndex = -1;
            cbstat_d29.SelectedIndex = -1;
            cbstat_d36.SelectedIndex = -1;
            cbstat_d38.SelectedIndex = -1;
            cbstat_d28.SelectedIndex = -1;
            cbstat_d2.SelectedIndex = -1;
            cbstat_d7.SelectedIndex = -1;
            cbstat_d1.SelectedIndex = -1;
            cbcharge_stat.SelectedIndex = -1;
            cbjudge.SelectedIndex = -1;
            cbstick_attc.SelectedIndex = -1;
            txttest_fail.Clear();
            txttestby.Clear();
            txtremarks.Clear();

        }
    }
   

}
