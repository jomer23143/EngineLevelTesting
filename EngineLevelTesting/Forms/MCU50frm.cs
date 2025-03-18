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
    public partial class MCU50frm : Form
    {
        public MCU50frm()
        {
            InitializeComponent();
            rjCircularPictureBox1.Hide();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbipn.Text) || string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(txtrev.Text) || string.IsNullOrEmpty(txtversion.Text) || string.IsNullOrEmpty(cbccs.Text)
                || string.IsNullOrEmpty(cbchademo.Text) || string.IsNullOrEmpty(cbvsense.Text) || string.IsNullOrEmpty(cbisense.Text) || string.IsNullOrEmpty(cbj20.Text) || string.IsNullOrEmpty(cbj22.Text) ||
                string.IsNullOrEmpty(cbj24.Text) || string.IsNullOrEmpty(cbj26.Text) || string.IsNullOrEmpty(cbj11.Text) || string.IsNullOrEmpty(cbj8.Text) || string.IsNullOrEmpty(cbj21.Text) ||
                string.IsNullOrEmpty(cbj7.Text) || string.IsNullOrEmpty(cbj19.Text) || string.IsNullOrEmpty(cbdoor.Text) || string.IsNullOrEmpty(cbbtn1.Text) || string.IsNullOrEmpty(cbbtn2.Text) ||
                string.IsNullOrEmpty(cbbtn3.Text) || string.IsNullOrEmpty(cbstatus.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestedby.Text))
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
                                { "ipn_number",cbipn.Text},
                                { "rev_no",txtrev.Text},
                                { "version",txtversion.Text},
                                { "ccs",cbccs.Text},
                                { "chademo",cbchademo.Text},
                                { "vsense",cbvsense.Text},
                                { "isense",cbisense.Text},
                                { "fault_sim1",cbj20.Text},
                                { "fault_sim2",cbj22.Text},
                                { "fault_sim3",cbj24.Text},
                                { "fault_sim4",cbj26.Text},
                                { "fault_simj11",cbj11.Text},
                                { "fault_simj8",cbj8.Text},
                                { "fault_simj21",cbj21.Text},
                                { "interlock",cbj7.Text},
                                { "ground",cbj19.Text},
                                { "door",cbdoor.Text},
                                { "button1",cbbtn1.Text},
                                { "button2",cbbtn2.Text},
                                { "button3",cbbtn3.Text},
                                { "status",cbstatus.Text},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestedby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("mcu50_table", data));
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
            txtserial.Clear();
            cbipn.SelectedIndex = -1; ;
            txtrev.Clear();
            txtversion.Clear();
            cbccs.SelectedIndex = -1;
            cbchademo.SelectedIndex = -1;
            cbvsense.SelectedIndex = -1;
            cbisense.SelectedIndex = -1;
            cbj20.SelectedIndex = -1;
            cbj22.SelectedIndex = -1;
            cbj24.SelectedIndex = -1;
            cbj26.SelectedIndex = -1;
            cbj11.SelectedIndex = -1;
            cbj8.SelectedIndex = -1;
            cbj21.SelectedIndex = -1;
            cbj7.SelectedIndex = -1;
            cbj19.SelectedIndex = -1;
            cbdoor.SelectedIndex = -1;
            cbbtn1.SelectedIndex = -1;
            cbbtn2.SelectedIndex = -1;
            cbbtn3.SelectedIndex = -1;
            cbstatus.SelectedIndex = -1;
            txtremarks.Clear();
            txttestedby.Clear();
        }

    }
}
