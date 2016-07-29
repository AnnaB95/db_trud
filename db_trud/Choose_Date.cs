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
    public partial class Choose_Date : Form
    {
        public Choose_Date()
        {
            InitializeComponent();
        }

        private void Choose_Date_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now.Date;
            dateTimePicker1.Value = DateTime.Now.Date;
            this.CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regist_Users_Form.date = dateTimePicker1.Value.Date;
            Regist_Org_Form.date = dateTimePicker1.Value.Date;

            this.Close();
        }
    }
}
