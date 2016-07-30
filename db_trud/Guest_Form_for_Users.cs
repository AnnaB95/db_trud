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
    public partial class Guest_Form_for_Users : Form
    {
        Label label5 = new Label();
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        int count = 0;
        bool submenu = true;
        
        public Guest_Form_for_Users()
        {
            InitializeComponent();
        }

        private void курсыПереобученияповышенияКвалификацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "Курс";
            dataGridView1.Columns[1].Name = "Специальность";
            dataGridView1.Columns[2].Name = "Статус";

            Black_Menu();
            курсыПереобученияповышенияКвалификацииToolStripMenuItem.ForeColor = Color.Red;

            submenu = false;


            Info();
            
        }

        private void редактироватьРезюмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].Name = "Должность";
            dataGridView1.Columns[1].Name = "Организация";
            dataGridView1.Columns[2].Name = "Зар. плата";

            Black_Menu();
            редактироватьРезюмеToolStripMenuItem.ForeColor = Color.Red;

            submenu = true;

            Info();
        }

        private void Black_Menu()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].ForeColor = Color.Black;
            }
        }

        private void Guest_Form_for_Users_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 3;
            // dataGridView1.Size = new Size(486, 284);
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].Name = "Должность";
            dataGridView1.Columns[1].Name = "Организация";
            dataGridView1.Columns[2].Name = "Зар. плата";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            Info();
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

        private void Info()
        {
            if (dataGridView1.Contains(label5))
            {
                dataGridView1.Controls.Remove(label5);
                dataGridView1.ColumnHeadersVisible = true;

            }

            count = 0;

            while (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);

            if (submenu)
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
                + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
                + " inner join Организации on Вакансии.Организация=Организации.Код"
                + " where Вакансии.Статус='активна'";
            }
            else
            {
                cmd = con.CreateCommand();
                cmd.CommandText = "select Название, Специальность, Статус from [Курсы переобучения/повышения квалификации]";
            }



                if (con.State == ConnectionState.Closed)
                    con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                dataGridView1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim());
                count++;
            }

            reader1.Close();
            con.Close();

            if (count == 0)
            {
                if (submenu)
                label5.Text = "Нет ни одной вакансии";
                else
                    label5.Text = "Нет ни одного курса";

                dataGridView1.ColumnHeadersVisible = false;
                dataGridView1.Controls.Add(label5);
                
            }
        }

      
    }
}
