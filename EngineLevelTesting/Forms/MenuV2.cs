using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities.BunifuShadowPanel;
using Utility.ModifyRegistry;

namespace EngineLevelTesting.Forms
{
    public partial class MenuV2: Form
    {
        private Dictionary<String, Dictionary<String, String>> dbConnectionSettings = new Dictionary<String, Dictionary<String, String>>();
        public MenuV2()
        {
            InitializeComponent();
        }

        private void MenuV2_Load(object sender, EventArgs e)
        {
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.ItemSize = new Size(160, 70);
            this.tabControl1.SizeMode = TabSizeMode.Fixed;
            Get_connection();
        }
        private void Get_connection()
        {
            RegistrySupport registry = new RegistrySupport();
            String data = registry.Read(Def.REGKEY_SUB);
            if (data == null)
            {
                data += String.Format($"ENGINELEVELTESTING<limiter>194.163.32.81<limiter>u867954426_board<limiter>System@2023<limiter>u867954426_board<limiter>");
                registry.Write(Def.REGKEY_SUB, data);
            }
            Utils.SetConnectionDetails();
            this.Text = $"{Assembly.GetExecutingAssembly().GetName().Version.ToString()} - {Utils.DBConnection["ENGINELEVELTESTING"]["DBNAME"].ToString()}";
            dbConnectionSettings = Utils.DBConnection;
        }
        private void GetRoundButton(Button btn)
        {
            GraphicsPath p = new GraphicsPath();
            p.AddEllipse(1, 1, btn.Width + 4, btn.Height + 4);
            btn.Region = new Region(p);
        }
        private void btnhvcombo_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnafe_Click(object sender, EventArgs e)
        {
            AfeBoard frm = new AfeBoard();
            frm.Show();
        }

        private void btnmc5_Click(object sender, EventArgs e)
        {
            MCU50frm frm = new MCU50frm();
            frm.Show();
        }

        private void btnminipcm_Click(object sender, EventArgs e)
        {
            MiniPCMfrm frm = new MiniPCMfrm();
            frm.Show();
        }

        private void btnSecc_Click(object sender, EventArgs e)
        {
            SeccFrm frm = new SeccFrm();
            frm.Show();
        }

        private void btnxbu_Click(object sender, EventArgs e)
        {
            XBUfrm frm = new XBUfrm();
            frm.Show();
        }

        private void btnxbutower_Click(object sender, EventArgs e)
        {
            XBUTowerfrm frm = new XBUTowerfrm();
            frm.Show();
        }

        private void btnmcu360_Click(object sender, EventArgs e)
        {
            MCU360frm frm = new MCU360frm();
            frm.Show();
        }

        private void btnmcu6_Click(object sender, EventArgs e)
        {
            MCUFrm frm = new MCUFrm();
            frm.Show();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            resetBoardfrm frm = new resetBoardfrm();
            frm.Show();
        }

        private void btnsecc2_Click(object sender, EventArgs e)
        {
            Secc2Frm frm = new Secc2Frm();
            frm.Show();
        }

        private void btnmcu6_4_Click(object sender, EventArgs e)
        {
            MCU6_4frm frm = new MCU6_4frm();
            frm.Show();
        }

        private void btnl2powermeter_Click(object sender, EventArgs e)
        {
            PowerMeterfrm frm = new PowerMeterfrm();
            frm.Show();
        }

        private void btnl2powerboard_Click(object sender, EventArgs e)
        {
            PowerBoardfrm frm = new PowerBoardfrm();
            frm.Show();
        }

        private void btnopto_Click(object sender, EventArgs e)
        {
            OptoFRM frm = new OptoFRM();
            frm.Show();
        }

        private void btnacl2_Click(object sender, EventArgs e)
        {
            Acl2 frm = new Acl2();
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var report = new Reports();
            report.Show();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush textbrush;
            Brush backbrush;
            textbrush = Brushes.Green;
            TextRenderer.DrawText(e.Graphics, tabControl1.TabPages[e.Index].Text, tabControl1.Font, e.Bounds, (textbrush as SolidBrush).Color);
            if (e.State.HasFlag(DrawItemState.Selected))
            {
                backbrush = new System.Drawing.SolidBrush(Color.Orange);
                textbrush = Brushes.White;
            }
            else
            {
                backbrush = new System.Drawing.SolidBrush(Color.DarkOrange);
                textbrush = Brushes.White;
            }
            e.Graphics.FillRectangle(backbrush, e.Bounds);
            TextRenderer.DrawText(e.Graphics, tabControl1.TabPages[e.Index].Text, tabControl1.Font, e.Bounds, (textbrush as SolidBrush).Color);
        }
    }
}
