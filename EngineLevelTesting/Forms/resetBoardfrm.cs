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
    public partial class resetBoardfrm : Form
    {
        public resetBoardfrm()
        {
            InitializeComponent();
            rjCircularPictureBox1.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtrev.Text) || string.IsNullOrEmpty(cbsw1.Text) || string.IsNullOrEmpty(cbsw2.Text) ||
               string.IsNullOrEmpty(txttestTechnician.Text) || string.IsNullOrEmpty(cbjudgement.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(cbtestjig.Text))
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
               rjCircularPictureBox1.Show();
                StringBuilder sql = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "board_serial", txtserial.Text},
                                { "ipn",txtipn.Text},
                                { "board_rev_no",txtrev.Text},
                                { "test_jig_status",cbtestjig.Text},
                                { "sw1",cbsw1.Text},
                                { "sw2",cbsw2.Text},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "tok",cbtok.Text},
                                { "test_failure_details",txttestfailure.Text},
                                { "tested_by",txttestTechnician.Text},
                                { "remarks",txtremarks.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("reset_table", data));
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
            cbtestjig.SelectedIndex = -1;
            txtserial.Clear();
            txtipn.Clear();
            txtrev.Clear();
            cbsw1.SelectedIndex = -1;
            cbsw2.SelectedIndex = -1;
            cbjudgement.SelectedIndex = -1;
            cbtok.SelectedIndex = -1;
            txttestfailure.Clear();
            txtremarks.Clear();
            txttestTechnician.Clear();

        }
    }
}
