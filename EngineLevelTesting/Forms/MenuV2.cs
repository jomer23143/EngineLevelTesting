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
    public partial class MenuV2: Form
    {
        public MenuV2()
        {
            InitializeComponent();
        }

        private void MenuV2_Load(object sender, EventArgs e)
        {

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
    }
}
