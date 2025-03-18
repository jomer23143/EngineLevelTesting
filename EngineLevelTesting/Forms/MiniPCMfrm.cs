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
    public partial class MiniPCMfrm : Form
    {
        public MiniPCMfrm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtrevno.Text) || string.IsNullOrEmpty(txttestedby.Text))
            {
                MessageBox.Show("Please Fill out all Fields.");
                return;
            }

            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object>()
            {
                {"date_tested",DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") }
                ,{"board_serial",txtserial.Text}
                ,{"ipn_number",txtipn.Text}
                ,{"board_rev_no",txtrevno.Text }
                ,{"d1on",cbd1on.Text }
                ,{"d2on",cbd2on.Text }
                ,{"d5on",cbd5on.Text }
                ,{"d6on",cbd6on.Text }
                ,{"positive_out",cbpositve.Text }
                ,{"negative_out",cbnegative.Text }
                ,{"v_display",txtvdisplay.Text }
                ,{"v_ref",txtvref.Text }
                ,{"i_display",txtidisplay.Text}
                ,{"i_ref",txtiref.Text }
                ,{"judgement",cbjudgement.Text }
                ,{"tok",cbtok.Text }
                ,{"test_fail_details",txttestfail.Text }
                ,{"tested_by",txttestedby.Text }
                ,{"remarks",txtremarks.Text }
                ,{"date_stamp",DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") }
                ,{"date_record",DateTime.Now.ToShortDateString() }
            };
            sql.Append(MySqlDatasupport.GetInsert("mini_pcm", data));
            MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
           
            MessageBox.Show("Successfully Saved");
            ClearField();
        }
        private void ClearField()
        {
            txtserial.Clear();
            txtipn.Clear();
            txtrevno.Clear();
            cbd1on.SelectedIndex = -1;
            cbd2on.SelectedIndex = -1;
            cbd5on.SelectedIndex = -1;
            cbd6on.SelectedIndex = -1;
            cbpositve.SelectedIndex = -1;
            cbnegative.SelectedIndex = -1;
            txtvdisplay.Clear();
            txtvref.Clear();
            txtidisplay.Clear();
            txtiref.Clear();
            cbjudgement.SelectedIndex = -1;
            cbtok.SelectedIndex = -1;
            txttestfail.Clear();
            txttestedby.Clear();
            txtremarks.Clear();
        }
    }
}
