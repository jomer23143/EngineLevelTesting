using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms;
using EngineLevelTesting.Utilities;
using EngineLevelTesting.Class;
namespace EngineLevelTesting.Forms
{
    public partial class Secc2Frm : Form
    {
        #region Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private string dt = DateTime.Now.ToString("MM-dd-yyyy");
        private MyCorners myCorners = new MyCorners();

        private Dictionary<BunifuTextBox, BunifuCheckBox> textBoxCheckBoxMap;
        private Dictionary<BunifuDropdown, BunifuCheckBox> dropdownCheckBoxMap1;

        public Secc2Frm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            myCorners.RoundedFormsDocker(this);
            myCorners.RoundedPanelModuleName(panel_headerText);
            pictureBox3.Hide();
        }

        private void Secc2Frm_Load(object sender, EventArgs e)
        {
            Txt_datetested.Text = dt;
            Txt_no.Select();
            chckController();
        }

        private void chckController()
        {
            textBoxCheckBoxMap = new Dictionary<BunifuTextBox, BunifuCheckBox>();
            dropdownCheckBoxMap1 = new Dictionary<BunifuDropdown, BunifuCheckBox>();

            //Map Tetxboxes with CheckBoxes
            if (Txt_no != null && c1 != null)
                textBoxCheckBoxMap.Add(Txt_no, c1);

            if (Txt_datetested != null && c2 != null)
                textBoxCheckBoxMap.Add(Txt_datetested, c2);

            if (Txt_serial_number != null && c3 != null)
                textBoxCheckBoxMap.Add(Txt_serial_number, c3);

            if (Txt_ipn != null && c4 != null)
                textBoxCheckBoxMap.Add(Txt_ipn, c4);

            if (Txt_revno != null && c5 != null)
                textBoxCheckBoxMap.Add(Txt_revno, c5);

            if (Txt_emmc != null && c6 != null)
                textBoxCheckBoxMap.Add(Txt_emmc, c6);

            if (Txt_load_test != null && c9 != null)
                textBoxCheckBoxMap.Add(Txt_load_test, c9);

            if (Txt_keysight_attenuation != null && c16 != null)
                textBoxCheckBoxMap.Add(Txt_keysight_attenuation, c16);

            if (Txt_failure_details != null && c22 != null)
                textBoxCheckBoxMap.Add(Txt_failure_details, c22);

            if (Txt_test_technician != null && c23 != null)
                textBoxCheckBoxMap.Add(Txt_test_technician, c23);

            if (Txt_remarks != null && c24 != null)
                textBoxCheckBoxMap.Add(Txt_remarks, c24);


            // Map Dropdowns with CheckBoxes
            if (Cmb_board_selection != null && c7 != null)
                dropdownCheckBoxMap1.Add(Cmb_board_selection, c7);

            if (Cmb_boardtype != null & c8 != null)
                dropdownCheckBoxMap1.Add(Cmb_boardtype, c8);
           
            if (Cmb_usb_type_a_test != null && c10 != null)
                dropdownCheckBoxMap1.Add(Cmb_usb_type_a_test, c10);

            if (Cmb_usb_type_c_test != null && c11 != null)

                dropdownCheckBoxMap1.Add(Cmb_usb_type_c_test, c11);

            if (Cmb_cm_set_key_test != null && c12 != null)
                dropdownCheckBoxMap1.Add(Cmb_cm_set_key_test, c12);

            if (Cmb_succesfully != null && c13 != null)
                dropdownCheckBoxMap1.Add(Cmb_succesfully, c13);

            if (Cmb_Load_production_binaries != null && c14 != null)
                dropdownCheckBoxMap1.Add(Cmb_Load_production_binaries, c14);

            if (Cmb_charging_sessions != null && c15 != null)
                dropdownCheckBoxMap1.Add(Cmb_charging_sessions, c15);

            if (Cmb_charging_session1 != null && c17 != null)
                dropdownCheckBoxMap1.Add(Cmb_charging_session1, c17);

            if (Cmb_charging_session2 != null && c18 != null)
                dropdownCheckBoxMap1.Add(Cmb_charging_session2, c18);

            if (Cmb_charging_session3 != null && c19 != null)
                dropdownCheckBoxMap1.Add(Cmb_charging_session3, c19);

            if (Cmb_judgement != null && c20 != null)
                dropdownCheckBoxMap1.Add(Cmb_judgement, c20);

            if (Cmb_tok != null && c21 != null)
                dropdownCheckBoxMap1.Add(Cmb_tok, c21);



            // Attach TextChanged event handler for all TextBoxes
            foreach (var textBox in textBoxCheckBoxMap.Keys)
            {
                textBox.TextChanged += TextBox_TextChanged;
            }

            // Attach SelectedIndexChanged event handler for all Dropdowns
            foreach (var dropdown in dropdownCheckBoxMap1.Keys)
            {
                dropdown.SelectedIndexChanged += Dropdown_SelectedIndexChanged;
            }
        }


        // Single event handler for all TextBoxes
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (sender is BunifuTextBox textBox)
            {
                if (textBoxCheckBoxMap.TryGetValue(textBox, out BunifuCheckBox checkBox))
                {
                    checkBox.Checked = !string.IsNullOrWhiteSpace(textBox.Text);
                }
            }
        }

        // Single event handler for all Dropdowns
        private void Dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is BunifuDropdown dropdown)
            {
                if (dropdownCheckBoxMap1.TryGetValue(dropdown, out BunifuCheckBox checkBox))
                {
                    checkBox.Checked = dropdown.SelectedIndex != -1; // Check if a selection is made
                }
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(Txt_ipn.Text) || string.IsNullOrEmpty(Txt_serial_number.Text) || string.IsNullOrEmpty(Txt_emmc.Text) || string.IsNullOrEmpty(Txt_load_test.Text) || string.IsNullOrEmpty(Txt_keysight_attenuation.Text) || string.IsNullOrEmpty(Txt_failure_details.Text) || string.IsNullOrEmpty(Txt_test_technician.Text) || string.IsNullOrEmpty(Txt_remarks.Text))
            {
                MessageBox.Show("Please input all Fields", "Notification - SECC 2.0 Board Test Checklist", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
                Saved();
        }


        private async void Saved()
        {
            try
            {
              pictureBox3.Show();
                StringBuilder sql = new StringBuilder();
                Dictionary<string, object> data = new Dictionary<string, object> {
                                { "no",Txt_no.Text},
                                { "date_tested", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss")},
                                { "serial_number", Txt_serial_number.Text},
                                { "ipn",Txt_ipn.Text},
                                { "rev_no",Txt_revno.Text},
                                { "flashing_latest_image",Txt_emmc.Text},
                                { "board_selection",Cmb_board_selection.SelectedItem.ToString()},
                                { "board_type",Cmb_boardtype.SelectedItem.ToString()},
                                { "load_test_binaries_firmware",Txt_load_test.Text},
                                { "usb_type_a_test",Cmb_usb_type_a_test.SelectedItem.ToString()},
                                { "usb_type_c_test",Cmb_usb_type_c_test.SelectedItem.ToString()},
                                { "cm_set_key",Cmb_cm_set_key_test.SelectedItem.ToString()},
                                { "sucessfully",Cmb_succesfully.SelectedItem.ToString()},
                                { "load_production_binaries_firmware",Cmb_Load_production_binaries.SelectedItem.ToString()},
                                { "charging_session",Cmb_charging_sessions.SelectedItem.ToString()},
                                { "keysight_attenuation",Txt_keysight_attenuation.Text},
                                { "charging_session_1",Cmb_charging_session1.SelectedItem.ToString()},
                                { "charging_session_2",Cmb_charging_session2.SelectedItem.ToString()},
                                { "charging_session_3",Cmb_charging_session3.SelectedItem.ToString()},
                                { "judgement",Cmb_judgement.SelectedItem.ToString()},
                                { "tok_sticker_attached",Cmb_tok.SelectedItem.ToString()},
                                { "failure_details",Txt_failure_details.Text},
                                { "test_technician",Txt_test_technician.Text},
                                { "remarks",Txt_remarks.Text},
                                { "date_stamp", DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") },
                                { "date_record",DateTime.Now.ToString("MM/dd/yyyy")}
                };
                sql.Append(MySqlDatasupport.GetInsert("secc2_table", data));
                await Task.Run(() =>
                {
                    MySqlDatasupport.RunNonQuery(sql.ToString(), IsolationLevel.ReadCommitted);
                });
               pictureBox3.Hide();
                MessageBox.Show("Data Sucessfully Saved!!!", "Success-SECC 2.0 Board Test Checklist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleardata();
            }
            catch (Exception)
            {
               pictureBox3.Hide();
                MessageBox.Show("Failed!!!", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Cleardata()
        {
            Txt_no.Clear();
            Txt_revno.Clear();
            Txt_serial_number.Clear();

            Txt_emmc.Clear();
            Txt_load_test.Clear();
            Txt_keysight_attenuation.Clear();
            Txt_failure_details.Clear();
            Txt_test_technician.Clear();
            Txt_remarks.Clear();
            Cmb_board_selection.SelectedIndex = -1;
            Cmb_usb_type_a_test.SelectedIndex = -1;
            Cmb_usb_type_c_test.SelectedIndex = -1;
            Cmb_boardtype.SelectedIndex = -1;
            Cmb_charging_session1.SelectedIndex = -1;
            Cmb_charging_session2.SelectedIndex = -1;
            Cmb_charging_session3.SelectedIndex = -1;
            Cmb_judgement.SelectedIndex = -1;
            Cmb_tok.SelectedIndex = -1;
            Cmb_succesfully.SelectedIndex = -1;
            Cmb_Load_production_binaries.SelectedIndex = -1;
            Cmb_cm_set_key_test.SelectedIndex = -1;
            Cmb_charging_sessions.SelectedIndex = -1;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0x112, 0xf012, 0);
            }
        }
    }
}
