using EngineLevelTesting.Utilities;
using RJCodeAdvance.RJControls;
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
    public partial class Acl2 : Form
    {
        public Acl2()
        {
            InitializeComponent();
            rjCircularPictureBox1.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
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
                                { "product_name", cbproduct_name.Text},
                                { "side_bracket",txtside_bracket.Text},
                                { "port",cbportside.SelectedItem.ToString()},
                                { "current_rating",cbcurrent_rating.SelectedItem.ToString()},
                                { "charge_id",txtcharge_id.Text},
                                { "charge_amp240",cbamp240.SelectedItem.ToString()},
                                { "charge_amp120",cbamp120.SelectedItem.ToString()},
                                { "fw_version",cbfw_version.Text},
                                { "test_contactor",cbtest_contactor.Text},
                                { "test_gfci",cbtest_gfci.Text},
                                { "test_gfci_reset",cbtest_gfci_reset.Text},
                                { "full_auto",cbfull_auto.Text},
                                { "check_pilot",cbcheck_pilot.Text},
                                { "judgement",cbjudge.Text},
                                { "test_technician",txttest_tech.Text},
                                { "remarks",txtremarks.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("acl2_table", data));
                await Task.Run(() =>
                {
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Saved!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            catch (Exception ex)
            {
                rjCircularPictureBox1.Hide();
                MessageBox.Show("Failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Clear()
        {
            cbproduct_name.SelectedIndex = -1;
            txtside_bracket.Clear();
            cbportside.SelectedIndex = -1;
            cbcurrent_rating.SelectedIndex = -1;
            txtcharge_id.Clear();
            cbamp120.SelectedIndex = -1;
            cbamp240.SelectedIndex = -1;
            cbfw_version.SelectedIndex = -1;
            cbtest_contactor.SelectedIndex = -1;
            cbtest_gfci.SelectedIndex = -1;
            cbtest_gfci_reset.SelectedIndex = -1;
            cbfull_auto.SelectedIndex = -1;
            cbjudge.SelectedIndex = -1;
            cbcheck_pilot.SelectedIndex = -1;
            txttest_tech.Clear();
            txtremarks.Clear();
        }
    }
}
