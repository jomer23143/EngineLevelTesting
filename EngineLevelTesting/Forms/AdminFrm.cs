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
    public partial class AdminFrm : Form
    {
        public AdminFrm()
        {
            InitializeComponent();
        }

        private void AdminFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode ==Keys.Enter)
            {
                if (Forms.Menu.adminpass == textBox1.Text)
                    DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("Wrong Password!!!");
            }
        }
    }
}
