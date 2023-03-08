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
    public partial class XBUfrm : Form
    {
        public XBUfrm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtrev.Text) || string.IsNullOrEmpty(txt1st.Text) || string.IsNullOrEmpty(txt2nd.Text) ||
                string.IsNullOrEmpty(txt3rd.Text) || string.IsNullOrEmpty(cbjudgement.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("Please Input all fields!!!");
            }
            else
                Saved();
        }
        private void Saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "board_serial", txtserial.Text},
                                { "ipn_number",txtipn.Text},
                                { "rev_no",txtrev.Text},
                                { "first",txt1st.Text},
                                { "second",txt2nd.Text},
                                { "third",txt3rd.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
            };
            sql.Append(MySqlDatasupport.GetInsert("xbu_table", data));
            MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clear();

        }
        private void Clear()
        {
            txtserial.Clear();
            txtipn.Clear();
            txtrev.Clear();
            txt1st.Clear();
            txt2nd.Clear();
            txt3rd.Clear();
            txtremarks.Clear();
            txttestby.Clear();

        }
    }
}
