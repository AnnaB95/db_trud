using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace db_trud
{
    public partial class Educ : Form
    {
        public static int fl = 0;
        public static string ur = null;

        public Educ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fl = 1;
            ur = comboBox1.SelectedItem.ToString();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fl = 0;
            ur = null;
            this.Close();
        }

        private void Educ_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void Educ_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*fl = 0;
            ur = null;*/
        }
    }
}
