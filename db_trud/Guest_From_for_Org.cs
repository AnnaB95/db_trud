using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace db_trud
{
    public partial class Guest_From_for_Org : Form
    {

        Label label5 = new Label();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        int count = 0;
        bool submenu = true;

        public Guest_From_for_Org()
        {
            InitializeComponent();
        }

        private void Guest_From_for_Org_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            data1.ColumnCount = 4;
            // data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 250;
            data1.Columns[1].Width = 50;
            data1.Columns[2].Width = 130;
            data1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            data1.Columns[0].Name = "ФИО";
            data1.Columns[1].Name = "Стаж";
            data1.Columns[2].Name = "Должность";
            data1.Columns[3].Name = "Зар. плата";
         
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = true;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = true;
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);


            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }


            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();

            cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
            + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код";


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                data1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim(), reader1[3].ToString().Trim(), reader1[4].ToString().Trim());
                count++;
            }

            reader1.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Нет ни одного кандидата";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
               
            }
        }


        private void выйтиИзГостевогоРежимаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guests_Form.fl = false;
            this.Close();
        }

        private void выйтиИзПриложенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guests_Form.fl = true;
            this.Close();
        }
    }
}
