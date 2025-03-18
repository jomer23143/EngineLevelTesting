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
    public partial class PowerMeterfrm : Form
    {
        public PowerMeterfrm()
        {
            InitializeComponent();
            rjCircularPictureBox1.Hide();
            //txtfirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtvref.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtvphasea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtvphaseb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtiref.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtiphasea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtiphaseb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtpref.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtactivea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);
            txtactiveb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(KeyBoardSupport.ForCurrencyOnly_Keypress);

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtserial.Text) || string.IsNullOrEmpty(cbrev.Text) || String.IsNullOrEmpty(txtfirm.Text) || string.IsNullOrEmpty(cbledd26.Text) || string.IsNullOrEmpty(txtvref.Text)
                || string.IsNullOrEmpty(txtvphasea.Text) || string.IsNullOrEmpty(txtvphaseb.Text) || string.IsNullOrEmpty(txtiref.Text) || string.IsNullOrEmpty(txtiphasea.Text) || string.IsNullOrEmpty(txtiphaseb.Text)
                || string.IsNullOrEmpty(txtpref.Text) || string.IsNullOrEmpty(txtactivea.Text) || string.IsNullOrEmpty(txtactiveb.Text) || string.IsNullOrEmpty(txteref.Text) || string.IsNullOrEmpty(txteuiref.Text)
                || string.IsNullOrEmpty(cbresult.Text) || string.IsNullOrEmpty(txtremarks.Text) || string.IsNullOrEmpty(txttestby.Text))
            {
                MessageBox.Show("There is empty fields!!");
            }
            else
                Saved();
        }
        private async void Saved()
        {
            rjCircularPictureBox1.Show();
            StringBuilder sql = new StringBuilder();
            try
            {
                Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "board_serial", txtserial.Text},
                                { "rev_no",cbrev.Text},
                                { "fw_version",txtfirm.Text},
                                { "led_dg26",cbledd26.Text},
                                { "v_ref",txtvref.Text},
                                { "v_phase_a",txtvphasea.Text},
                                { "v_phase_b",txtvphaseb.Text},
                                { "i_ref",txtiref.Text},
                                { "i_phase_a",txtiphasea.Text},
                                { "i_phase_b",txtiphaseb.Text},
                                { "p_ref",txtpref.Text},
                                { "active_phase_a",txtactivea.Text},
                                { "active_phase_b",txtactiveb.Text},
                                { "e_ref",txteref.Text},
                                { "e_ui",txteuiref.Text},
                                { "result",cbresult.Text},
                                { "remarks",txtremarks.Text},
                                { "tested_by",txttestby.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("powermeter_table", data));
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
                MessageBox.Show("Please Contact Developer!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Clear()
        {
            txtserial.Clear();
            //txtfirm.Clear();
            txtvref.Clear();
            txtvphasea.Clear();
            txtvphaseb.Clear();
            txtiref.Clear();
            txtiphasea.Clear();
            txtiphaseb.Clear();
            txtpref.Clear();
            txtactivea.Clear();
            txtactiveb.Clear();
            txteref.Clear();
            txteuiref.Clear();
            txtremarks.Clear();
            txttestby.Clear();
        }
    }
}
