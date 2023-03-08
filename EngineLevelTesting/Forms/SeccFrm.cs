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
    public partial class SeccFrm : Form
    {
        public SeccFrm()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtipn.Text) || string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtfirm.Text) || string.IsNullOrEmpty(cbsession1.Text) || string.IsNullOrEmpty(cbsession2.Text)
                || string.IsNullOrEmpty(cbsession3.Text) || string.IsNullOrEmpty(cbjudgement.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("Please input all Fields");
            }
            else
                Saved();
        }
        private void Saved()
        {
            StringBuilder sql = new StringBuilder();
            Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "ipn_number", txtipn.Text},
                                { "serial_number", txtserial.Text},
                                { "firmware",txtfirm.Text},
                                { "session1",cbsession1.SelectedItem.ToString()},
                                { "session2",cbsession2.SelectedItem.ToString()},
                                { "session3",cbsession3.SelectedItem.ToString()},
                                { "judgement",cbjudgement.SelectedItem.ToString()},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
            };
            MySqlDatasupport.ID = 1;
            sql.Append(MySqlDatasupport.GetInsert("secc_table", data));
            MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
            MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Cleardata();
        }
        private void Cleardata()
        {
            txtserial.Clear();
            txtfirm.Clear();
            cbsession1.SelectedIndex = -1;
            cbsession2.SelectedIndex = -1;
            cbsession3.SelectedIndex = -1;
            cbjudgement.SelectedIndex = -1;
            txtremarks.Clear();
            txttestby.Clear();
        }
        private string GetScanSerial()
        {
            try
            {
                DataTable dt = MySqlDatasupport.RunDataTableDapper($@"Select * from secc_table where serial_number = '{txtserial.Text}'");
                if (dt.Rows.Count > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("You are about to overwrite record!!!\nAre you sure want to edit record?\n\nIf viewing purposes please go to report!!!", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //res = false;
                        //status = true;
                        foreach (DataRow item in dt.Rows)
                        {
                            cbsession1.Text = item["session1"].ToString();
                            cbsession2.Text = item["session2"].ToString();
                            cbsession3.Text = item["session3"].ToString();
                            txtfirm.Text = item["firmware"].ToString();
                            cbjudgement.Text = item["judgement"].ToString();
                            txtremarks.Text = item["remarks"].ToString();
                            txttestby.Text = item["tested_by"].ToString();

                        }
                        return "Success";
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //res = true;
                        //status = false;
                        return "Success";
                    }
                }
                else
                {
                    //res = false;
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
            GetScanSerial();
        }
    }
}
