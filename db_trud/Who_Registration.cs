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
    public partial class Who_Registration : Form
    {
        public static bool fl = true;
       

        public Who_Registration()
        {
            InitializeComponent();
        }

        private void Who_Registration_Load(object sender, EventArgs e)
        {
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
                
                Registration_Form form = new Registration_Form();
                form.ShowDialog();
               
                
            }
            else
            {
                Reg_org form = new Reg_org();
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
