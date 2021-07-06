using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ddos_panel_not_rat
{
    public partial class panel : Form
    {
        public panel()
        {
            InitializeComponent();
        }

        private void panel_Load(object sender, EventArgs e)
        {

        }

        private void panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Launch Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
