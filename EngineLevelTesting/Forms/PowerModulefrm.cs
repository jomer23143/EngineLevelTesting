using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EngineLevelTesting.Utilities;

namespace EngineLevelTesting.Forms
{
    public partial class PowerModulefrm : Form
    {
        public PowerModulefrm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
            this.StartPosition = FormStartPosition.CenterScreen;
            rjCircularPictureBox1.Visible = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // WS_EX_COMPOSITED
                return cp;
            }
        }

        private void PowerModulefrm_Load(object sender, System.EventArgs e)
        {
            // Smooth fade-in
            this.Opacity = 0;
            Timer t = new Timer { Interval = 20 };
            t.Tick += (s, ev) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    t.Stop();
            };
            t.Start();

            txt_no.Enabled = false;
            txt_no.Text = "1";
            txt_datetested.Enabled = false;
        }




        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void text_serial_number_Leave(object sender, System.EventArgs e)
        {

            DateTime currentTime = DateTime.Now;


            string formattedDateTime = currentTime.ToString("MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);


            txt_datetested.Text = formattedDateTime;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ipn.Text) || string.IsNullOrEmpty(text_serial_number.Text) || string.IsNullOrEmpty(cmb_visual_ispection.Text) || string.IsNullOrEmpty(text_vrms_l1.Text) ||
                string.IsNullOrEmpty(text_vrms_l2.Text) || string.IsNullOrEmpty(text_vrms_l3.Text) || string.IsNullOrEmpty(text_arms_l1.Text) || string.IsNullOrEmpty(text_arms_l2.Text) ||
                string.IsNullOrEmpty(text_arms_l3.Text) || string.IsNullOrEmpty(text_voltagemode_500v_display.Text) || string.IsNullOrEmpty(text_voltagemode_500v_actual.Text) ||
                string.IsNullOrEmpty(text_voltagemode_100v_display.Text) || string.IsNullOrEmpty(text_voltagemode_100v_actual.Text) || string.IsNullOrEmpty(text_currentmode_15A_display.Text) ||
                string.IsNullOrEmpty(text_currentmode_15A_actual.Text) || string.IsNullOrEmpty(text_currentmode_30A_display.Text) || string.IsNullOrEmpty(text_currentmode_30A_actual.Text) ||
                string.IsNullOrEmpty(txt_inhibit_function_12V.Text) || string.IsNullOrEmpty(txt_standby_power.Text) || string.IsNullOrEmpty(txt_input_power.Text) || string.IsNullOrEmpty(txt_output_voltage.Text) ||
                string.IsNullOrEmpty(txt_Output_current.Text) || string.IsNullOrEmpty(txt_output_power.Text) || string.IsNullOrEmpty(txt_efficiency.Text) || string.IsNullOrEmpty(txt_powerfactor.Text) ||
                string.IsNullOrEmpty(cmb_status_burn_in_1hr.Text) || string.IsNullOrEmpty(txtfirmware.Text) || string.IsNullOrEmpty(cmb_button_function.Text) ||
                string.IsNullOrEmpty(cmb_led_display.Text) || string.IsNullOrEmpty(cmb_judgement.Text) || string.IsNullOrEmpty(txt_tok_sticker_attached.Text) || string.IsNullOrEmpty(txt_testfailuredetails.Text) ||
                string.IsNullOrEmpty(txt_test_technician.Text) || string.IsNullOrEmpty(txt_remarks.Text))
            {
                MessageBox.Show("Please Input all fields!!!");
            }
            else
            {
                SubmitData();
            }


        }


        private async void SubmitData()
        {
            try
            {
                rjCircularPictureBox1.Show();
                StringBuilder sql = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "serial_number", text_serial_number.Text},
                                { "visual_inspection",cmb_visual_ispection.Text},
                                { "v_l1",text_vrms_l1.Text},
                                { "v_l2",text_vrms_l2.Text},
                                { "v_l3",text_vrms_l3.Text},
                                { "a_l1",text_arms_l1.Text},
                                { "a_l2",text_arms_l2.Text},
                                { "a_l3",text_arms_l3.Text},
                                { "voltage_500_display",text_voltagemode_500v_display.Text},
                                { "voltage_500_act",text_voltagemode_500v_actual.Text},
                                { "voltage_1000_display",text_voltagemode_100v_display.Text},
                                { "voltage_1000_act",text_voltagemode_100v_actual.Text},
                                { "current_15a_display",text_currentmode_15A_display.Text},
                                { "current_15a_act",text_currentmode_15A_actual.Text},
                                { "current_30a_display",text_currentmode_30A_display.Text},
                                { "current_30a_act",text_currentmode_30A_actual.Text},
                                { "inhibit_function",txt_inhibit_function_12V.Text},
                                { "standby_power",txt_standby_power.Text},
                                { "input_power",txt_input_power.Text},
                                { "output_voltage",txt_output_voltage.Text},
                                { "output_current",txt_Output_current.Text},
                                { "output_power",txt_output_power.Text},
                                { "effciency",txt_efficiency.Text},
                                { "power_factor",txt_powerfactor.Text},
                                { "status_after_born_in",cmb_status_burn_in_1hr.Text},
                                { "firmware",txtfirmware.Text},
                                { "button_function",cmb_button_function.Text},
                                { "led_display_function",cmb_led_display.Text},
                                { "judgement",cmb_judgement.Text},
                                { "tok_sticker_attached",txt_tok_sticker_attached.Text},
                                { "test_failure_details",txt_testfailuredetails.Text},
                                { "test_technician",txt_test_technician.Text},
                                { "remarks",txt_remarks.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record", DateTime.Now.ToShortDateString()}
                };
                sql.Append(MySqlDatasupport.GetInsert("power_module_table", data));
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
            text_serial_number.Clear();
            txt_ipn.Clear();
            cmb_visual_ispection.SelectedIndex = -1; ;
            text_vrms_l1.Clear();
            text_vrms_l2.Clear();
            text_vrms_l3.Clear();
            text_arms_l1.Clear();
            text_arms_l2.Clear();
            text_arms_l3.Clear();
            text_voltagemode_500v_display.Clear();
            text_voltagemode_500v_actual.Clear();
            text_voltagemode_100v_display.Clear();
            text_voltagemode_100v_actual.Clear();
            text_currentmode_15A_display.Clear();
            text_currentmode_15A_actual.Clear();
            text_currentmode_30A_display.Clear();
            text_currentmode_30A_actual.Clear();
            txt_inhibit_function_12V.Clear();
            txt_standby_power.Clear();
            txt_input_power.Clear();
            txt_output_voltage.Clear();
            txt_Output_current.Clear();
            txt_output_power.Clear();
            txt_efficiency.Clear();
            txt_powerfactor.Clear();
            cmb_status_burn_in_1hr.SelectedIndex = -1; ;
            txtfirmware.Clear();
            cmb_button_function.SelectedIndex = -1; ;
            cmb_led_display.SelectedIndex = -1; ;
            cmb_judgement.SelectedIndex = -1; ;
            txt_tok_sticker_attached.Clear();
            txt_testfailuredetails.Clear();
            txt_test_technician.Clear();
            txt_remarks.Clear();
            int currentNo = int.Parse(txt_no.Text);
            // Increment the number by 1
            currentNo++;
            txt_no.Text = currentNo.ToString();

        }
    }


}
