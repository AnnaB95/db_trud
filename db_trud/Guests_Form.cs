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
    public partial class Guests_Form : Form
    {
        public static bool fl = true;

        public Guests_Form()
        {
            InitializeComponent();
        }

        private void Guests_Form_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            this.CenterToScreen();
            radioButton1.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login.reg = 1;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            if (radioButton1.Checked)
            {

                Guest_Form_for_Users form = new Guest_Form_for_Users();
                form.ShowDialog();


            }
            else
            {
                Guest_From_for_Org form = new Guest_From_for_Org();
                form.ShowDialog();

            }

            if (fl)
            {

                this.Close();
            }
            else
            {
                this.Visible = true;
            }
        }
    }
}
