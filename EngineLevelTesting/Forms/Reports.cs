using System;
using System.Data;
using System.Reflection;
using System.Windows.Forms;
using EngineLevelTesting.Utilities;
using Microsoft.Reporting.WinForms;

namespace EngineLevelTesting.Forms
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            dtfrom.Value = DateTime.Now.AddDays(-7);
        }

        private void Reports_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            #region Scratch
            //string sql = "";
            //string report = "";
            //if (comboBox1.Text == "")
            //{
            //    MessageBox.Show("Please select from checklist!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (comboBox1.Text == "HvCombo Checklist")
            //{
            //    sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where date_record between '{dtfrom.Value.ToShortDateString()}' and '{dtto.Value.ToShortDateString()}'";
            //    report = "HvComboReport";
            //}
            //else if(comboBox1.Text == "HvCombo Checklist ISO")
            //{
            //    sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where date_record between '{dtfrom.Value.ToShortDateString()}' and '{dtto.Value.ToShortDateString()}'";
            //    report = "IsoDocReport";
            //}
            //else if(comboBox1.Text == "AFE Board Checklist ISO")
            //{
            //    sql = $@"Select * from afe_table where date_record between '{dtfrom.Value.ToShortDateString()}' and '{dtto.Value.ToShortDateString()}'";
            //    report = "IsoDocAfe";
            //}
            //else 
            //{
            //    sql = $@"Select * from afe_table where date_record between '{dtfrom.Value.ToShortDateString()}' and '{dtto.Value.ToShortDateString()}'";
            //    report = "afeReport";
            //}
            //reportViewer1.Reset();
            //DataTable dt = MySqlDatasupport.RunDataTableDapper(sql, Class.SqlCon.connectionString(1));
            //var localreport = reportViewer1.LocalReport;
            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            //reportViewer1.LocalReport.DataSources.Add(rds);
            ////if (dt.Rows.Count != 0)
            ////{
            //    localreport.ReportEmbeddedResource = $"{ Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.Reports.{report}.rdlc";
            ////    ReportParameter rp1 = new ReportParameter("from", "From : " + dtfrom.Value.ToShortDateString());
            ////    ReportParameter rp2 = new ReportParameter("to", "To : " + dtto.Value.ToShortDateString());
            ////    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            ////}
            ////else
            ////{
            ////    localreport.ReportEmbeddedResource = $"{ Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.Report.NoRecord.rdlc";
            ////}
            //reportViewer1.RefreshReport();
            //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //reportViewer1.ZoomMode = ZoomMode.PageWidth;
            #endregion
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                ShowDataDateRange();
            }
            else
            {
                SearchDate();
            }
        }
        private void ShowDataDateRange()
        {
            string sql = "";
            string report = "";
            string datasetname = "";
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select from checklist!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.Text == "HvCombo Checklist")
            {
                sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "HvComboReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "HvCombo Checklist ISO")
            {
                sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "IsoDocReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "AFE Board Checklist ISO")
            {
                sql = $@"Select * from afe_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "IsoDocAfe";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "AFE Board Checklist")
            {
                sql = $@"Select * from afe_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "afeReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Secc Board Checklist")
            {
                sql = $@"SELECT * FROM secc_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "seccReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Secc Board Checklist ISO")
            {
                sql = $@"SELECT * FROM secc_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "ISOseccReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Power Board Checklist")
            {
                sql = $@"SELECT * FROM powerboard_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "powerReport";
                datasetname = "powerboard";
            }
            else if (comboBox1.Text == "Power Board Checklist ISO")
            {
                sql = $@"SELECT * FROM powerboard_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "IsopowerReport";
                datasetname = "powerboard";
            }
            else if (comboBox1.Text == "Power Meter Board Checklist")
            {
                sql = $@"SELECT * FROM powermeter_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "powermeterReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Power Meter Board Checklist ISO")
            {
                sql = $@"SELECT * FROM powermeter_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "IsoPowermeterReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu_table where STR_TO_DATE(date_record,'%m/%d/%Y') between '{dtfrom.Value.ToString("yyyy-MM-dd")}' and '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "isoMCUReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "XBU AIO Tower Board Checklist ISO")
            {
                sql = $@"SELECT * FROM xbu_table where STR_TO_DATE(date_record,'%m/%d/%Y') between '{dtfrom.Value.ToString("yyyy-MM-dd")}' and '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "isoXBUReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 50 Board Checklist")
            {
                sql = $@"SELECT * FROM mcu50_table where STR_TO_DATE(date_record,'%m/%d/%Y') between '{dtfrom.Value.ToString("yyyy-MM-dd")}' and '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "mcu50Report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 50 Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu50_table where STR_TO_DATE(date_record,'%m/%d/%Y') between '{dtfrom.Value.ToString("yyyy-MM-dd")}' and '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "Isomcu50";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Opto-Isolator Board Checklist ISO")
            {
                sql = $@"SELECT * FROM opto_isolator_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "optoISO";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "AC L2 Side Bracket Checklist ISO")
            {
                sql = $@"SELECT * FROM acl2_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "isoacl2Report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "XBU Tower Board Checklist ISO")
            {
                sql = $@"SELECT * FROM xbu_tower_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "isoxbutowerReport";
                datasetname = "DataSet2";
            }
            else if (comboBox1.Text == "MCU 360 Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu_360_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "isoMcu360report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Mini PCM 1 and 2 Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mini_pcm where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "minipcmrReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Reset Board Test Checklist ISO")
            {
                sql = $@"SELECT * FROM reset_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "isoresetreport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 6 Series Board Engine Level Test Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu6_series_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}' and mcu_type = 'MCU 6'";
                report = "isomcu6series";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "SECC 2.0 Board Test Checklist ISO")
            {
                sql = $@"SELECT * FROM secc2_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "secc2Report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 6.4 Board Engine Level Test Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu6_series_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}' and mcu_type = 'MCU 6.4'";
                report = "mcu6.4";
                datasetname = "DataSet1";
            }

            else if (comboBox1.Text == "Power Module Test Data")
            {
                sql = $@"SELECT * FROM power_module_table where Date(date_stamp) >= '{dtfrom.Value.ToString("yyyy-MM-dd")}' and  Date(date_stamp) <= '{dtto.Value.ToString("yyyy-MM-dd")}'";
                report = "PowerModuleReport";
                datasetname = "DataSet2";
            }

            reportViewer1.Reset();
            DataTable dt = MySqlDatasupport.RunDataTableDapper(sql);
            var localreport = reportViewer1.LocalReport;
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource(datasetname, dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            //if (dt.Rows.Count != 0)
            //{
            localreport.ReportEmbeddedResource = $"{Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.Reports.{report}.rdlc";
            //    ReportParameter rp1 = new ReportParameter("from", "From : " + dtfrom.Value.ToShortDateString());
            //    ReportParameter rp2 = new ReportParameter("to", "To : " + dtto.Value.ToShortDateString());
            //    reportViewer1.LocalReport.SetParameters(new ReportParameter[] { rp1, rp2 });
            //}
            //else
            //{
            //    localreport.ReportEmbeddedResource = $"{ Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.Report.NoRecord.rdlc";
            //}
            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }
        private void SearchDate()
        {
            string sql = "";
            string report = "";
            string datasetname = "";
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select from checklist!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBox1.Text == "HvCombo Checklist")
            {
                sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where board_serial = '{textBox1.Text}'";
                report = "HvComboReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "HvCombo Checklist ISO")
            {
                sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where board_serial = '{textBox1.Text}'";
                report = "IsoDocReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "AFE Board Checklist ISO")
            {
                sql = $@"Select * from afe_table where board_serial = '{textBox1.Text}'";
                report = "IsoDocAfe";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "AFE Board Checklist")
            {
                sql = $@"Select * from afe_table where board_serial = '{textBox1.Text}'";
                report = "afeReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Secc Board Checklist")
            {
                sql = $@"SELECT * FROM secc_table where serial_number = '{textBox1.Text}'";
                report = "seccReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Secc Board Checklist ISO")
            {
                sql = $@"SELECT * FROM secc_table where serial_number = '{textBox1.Text}'";
                report = "ISOseccReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Power Board Checklist")
            {
                sql = $@"SELECT * FROM powerboard_table where board_serial = '{textBox1.Text}'";
                report = "powerReport";
                datasetname = "powerboard";
            }
            else if (comboBox1.Text == "Power Board Checklist ISO")
            {
                sql = $@"SELECT * FROM powerboard_table where serial_number = '{textBox1.Text}'";
                report = "IsopowerReport";
                datasetname = "powerboard";
            }
            else if (comboBox1.Text == "Power Meter Board Checklist")
            {
                sql = $@"SELECT * FROM powermeter_table where board_serial = '{textBox1.Text}'";
                report = "powermeterReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Power Meter Board Checklist ISO")
            {
                sql = $@"SELECT * FROM powermeter_table where board_serial = '{textBox1.Text}'";
                report = "IsoPowermeterReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu_table where board_serial = '{textBox1.Text}'";
                report = "isoMCUReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 50 Board Checklist")
            {
                sql = $@"SELECT * FROM mcu50_table where board_serial = '{textBox1.Text}'";
                report = "mcu50Report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 50 Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu50_table where board_serial = '{textBox1.Text}'";
                report = "Isomcu50";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Opto-Isolator Board Checklist ISO")
            {
                sql = $@"SELECT * FROM opto_isolator_table where board_serial = '{textBox1.Text}'";
                report = "optoISO";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "AC L2 Side Bracket Checklist ISO")
            {
                sql = $@"SELECT * FROM acl2_table where board_serial = '{textBox1.Text}'";
                report = "isoacl2Report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "XBU Tower Board Checklist ISO")
            {
                sql = $@"SELECT * FROM xbu_tower_table where board_serial = '{textBox1.Text}'";
                report = "isoxbutowerReport";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "MCU 360 Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mcu_360_table where board_serial = '{textBox1.Text}'";
                report = "isoMcu360report";
                datasetname = "DataSet1";
            }
            else if (comboBox1.Text == "Mini PCM 1 and 2 Board Checklist ISO")
            {
                sql = $@"SELECT * FROM mini_pcm where board_serial = '{textBox1.Text}'";
                report = "minipcmrReport";
                datasetname = "DataSet2";
            }


            reportViewer1.Reset();
            DataTable dt = MySqlDatasupport.RunDataTableDapper(sql);
            var localreport = reportViewer1.LocalReport;
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource(datasetname, dt);
            reportViewer1.LocalReport.DataSources.Add(rds);
            //if (dt.Rows.Count != 0)
            //{
            localreport.ReportEmbeddedResource = $"{Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.Reports.{report}.rdlc";

            reportViewer1.RefreshReport();
            reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }
        private void Reports_FormClosed(object sender, FormClosedEventArgs e)
        {
            Forms.MenuV2 frm = new Forms.MenuV2();
            frm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            #region Scratch
            //string sql = "";
            //string report = "";
            //if (comboBox1.Text == "")
            //{
            //    MessageBox.Show("Please select from checklist!!!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (comboBox1.Text == "HvCombo Checklist")
            //{
            //    sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where board_serial = '{textBox1.Text}'";
            //    report = "HvComboReport";
            //}
            //else if(comboBox1.Text == "HvCombo Checklist ISO")
            //{
            //    sql = $@"Select *, 12a_request as a_request12,25a_request as a_request25, 400voltage as voltage400, 800voltage as voltage800 from hvcombo_table hv where board_serial = '{textBox1.Text}'";
            //    report = "IsoDocReport";
            //}
            //else if (comboBox1.Text == "AFE Board Checklist ISO")
            //{
            //    sql = $@"Select * from afe_table where board_serial = '{textBox1.Text}'";
            //    report = "IsoDocAfe";
            //}
            //else
            //{
            //    sql = $@"Select * from afe_table where board_serial = '{textBox1.Text}'";
            //    report = "afeReport";
            //}
            //reportViewer1.Reset();
            //DataTable dt = MySqlDatasupport.RunDataTableDapper(sql, Class.SqlCon.connectionString(1));
            //var localreport = reportViewer1.LocalReport;
            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource rds = new ReportDataSource("DataSet1", dt);
            //reportViewer1.LocalReport.DataSources.Add(rds);
            ////if (dt.Rows.Count != 0)
            ////{
            //localreport.ReportEmbeddedResource = $"{ Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace}.Reports.{report}.rdlc";

            //reportViewer1.RefreshReport();
            //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            //reportViewer1.ZoomMode = ZoomMode.PageWidth;
            #endregion
        }

        private void dtfrom_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void dtto_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
