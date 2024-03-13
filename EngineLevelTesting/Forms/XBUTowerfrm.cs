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
    public partial class XBUTowerfrm : Form
    {
        public XBUTowerfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtrevno.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("Please input all fields");
                return;
            }

            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"date_tested",DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") }
                ,{"board_serial",txtserial.Text}
                ,{"ipn_number",txtipn.Text}
                ,{"rev_no",txtrevno.Text }
                ,{"dip_switch_set",cbswitch.Text }
                ,{"programming",cbprogramming.Text }
                ,{"rail_a_voltage",cbraila.Text }
                ,{"stat_d529",cbd529.Text }
                ,{"stat_d579",cbd579.Text }
                ,{"stat_d629",cbd629.Text }
                ,{"stat_d679",cbd679.Text }
                ,{"stat_a1_plus",cba1plus.Text }
                ,{"stat_a1_minus",cba1minus.Text}
                ,{"stat_a2_plus",cba2plus.Text }
                ,{"stat_a2_minus",cba2minus.Text }
                ,{"stat_a3_plus",cba3plus.Text }
                ,{"stat_a3_minus",cba3minus.Text }
                ,{"stat_a4_plus",cba4plus.Text }
                ,{"stat_a4_minus",cba4minus.Text }
                ,{"rail_b_voltage",cbrailb.Text }
                ,{"stat_d539",cbd539.Text }
                ,{"stat_d589",cbd589.Text }
                ,{"stat_d639",cbd639.Text }
                ,{"stat_d689",cbd689.Text }
                ,{"stat_b1_plus",cbb1plus.Text }
                ,{"stat_b1_minus",cbb1minus.Text }
                ,{"stat_b2_plus",cbb2plus.Text}
                ,{"stat_b2_minus",cbb2minus.Text }
                ,{"stat_b3_plus",cbb3plus.Text }
                ,{"stat_b3_minus",cbb3minus.Text }
                ,{"stat_b4_plus",cbb4plus.Text }
                ,{"stat_b4_minus",cbb4minus.Text }
                ,{"chrg_stat_inter_dip",cbchargingstat.Text }
                ,{"dispenser_rail_a",cbdispensera.Text }
                ,{"dispenser_rail_b",cbdispenserb.Text }
                ,{"judgement",cbjudgement.Text }
                ,{"sticker_att",cbtok.Text }
                ,{"test_by",txttestby.Text }
                ,{"remarks",txtremarks.Text }
                ,{"date_stamp",DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") }
                ,{"date_record",DateTime.Now.ToShortDateString() }
            };
            sql.Append(MySqlDatasupport.GetInsert("xbu_tower_table", data));
            MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            ClearField();
            MessageBox.Show("Successfully Saved");
        }
        private void ClearField()
        {
            txtserial.Clear();
            txtipn.Clear();
            txtrevno.Clear();
            cbswitch.SelectedIndex = -1;
            cbprogramming.SelectedIndex = -1;
            cbraila.SelectedIndex = -1;
            cbd529.SelectedIndex = -1;
            cbd579.SelectedIndex = -1;
            cbd629.SelectedIndex = -1;
            cbd679.SelectedIndex = -1;
            cba1plus.SelectedIndex = -1;
            cba1minus.SelectedIndex = -1;
            cba2plus.SelectedIndex = -1;
            cba2minus.SelectedIndex = -1;
            cba3plus.SelectedIndex = -1;
            cba3minus.SelectedIndex = -1;
            cba4plus.SelectedIndex = -1;
            cba4minus.SelectedIndex = -1;
            cbrailb.SelectedIndex = -1;
            cbd539.SelectedIndex = -1;
            cbd589.SelectedIndex = -1;
            cbd639.SelectedIndex = -1;
            cbd689.SelectedIndex = -1;
            cbb1plus.SelectedIndex = -1;
            cbb1minus.SelectedIndex = -1;
            cbb2plus.SelectedIndex = -1;
            cbb2minus.SelectedIndex = -1;
            cbb3plus.SelectedIndex = -1;
            cbb3minus.SelectedIndex = -1;
            cbb4plus.SelectedIndex = -1;
            cbb4minus.SelectedIndex = -1;
            cbchargingstat.SelectedIndex = -1;
            cbdispensera.SelectedIndex = -1;
            cbdispenserb.SelectedIndex = -1;
            cbjudgement.SelectedIndex = -1;
            cbtok.SelectedIndex = -1;
            txttestby.Clear();
            txtremarks.Clear();
        }
    }
}
