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
    public partial class List_Vacancies : Form
    {
        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        SqlCommand cmd = new SqlCommand(); 
        int submenu = 0;
        int org = 0;
        int count = 0;
        int empl = 0;

        Label label5 = new Label();

        public List_Vacancies()
        {
            InitializeComponent();
        }

        public List_Vacancies(int a, int b)
        {
            InitializeComponent();

            submenu = a;
            org = b;
        }

          public List_Vacancies(int a, int b, int c)
        {
            InitializeComponent();

            submenu = a;
            org = b;
              empl = c;
        }


        private void List_Vacancies_Load(object sender, EventArgs e)
        {

            this.CenterToParent();

            dataGridView1.ColumnCount = 5;
            // dataGridView1.Size = new Size(486, 284);
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 100;
            dataGridView1.Columns[2].Width = 130;
            dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[4].Width = 0;
            dataGridView1.Columns[0].Name = "Должность";
            dataGridView1.Columns[1].Name = "Зар. плата";
            dataGridView1.Columns[2].Name = "Кол-во раб.мест";
            dataGridView1.Columns[3].Name = "Статус";
            dataGridView1.Columns[4].Name = "Код";
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            if (dataGridView1.Contains(label5))
            {
                dataGridView1.Controls.Remove(label5);
                dataGridView1.ColumnHeadersVisible = true;

            }


            count = 0;

            while (dataGridView1.Rows.Count != 0)
                dataGridView1.Rows.Remove(dataGridView1.Rows[dataGridView1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            if (submenu == 1)
            {
                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
                + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
                + " where Вакансии.Организация=" + org;


                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    dataGridView1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim(), reader1[3].ToString().Trim(), reader1[4].ToString().Trim());
                    count++;
                }

                reader1.Close();
                con.Close();

                if (count == 0)
                {
                    label5.Text = "У Вас пока нет ни одной вакансии";
                    dataGridView1.ColumnHeadersVisible = false;
                    dataGridView1.Controls.Add(label5);
                    button5.Visible = false;
                }
            }
            else
            {
                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
                + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
                + " where Вакансии.Организация=" + org;


                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader1 = cmd.ExecuteReader();

                while (reader1.Read())
                {
                    dataGridView1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim(), reader1[3].ToString().Trim(), reader1[4].ToString().Trim());
                    count++;
                }

                reader1.Close();
                con.Close();

                 cmd.CommandText = "select Собеседования.Результат, Собеседования.[Принято/Отказ], Вакансии.[Регистрационный номер]"
           + " from Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер]"
           + " where Вакансии.Организация=" + org + " and Собеседования.Кандидат=" + empl;

                 if (con.State == ConnectionState.Closed)
                     con.Open();

                 reader1 = cmd.ExecuteReader();

                 while (reader1.Read())
                 {
                     if ((reader1[0].ToString().Trim() != "приглашение на собеседование" && reader1[0].ToString().Trim() != "рассмотрение заявки") && (reader1[1].ToString().Trim() != "2"))
                     {
                         int i = 0;
                         for (i = 0; i < dataGridView1.RowCount; i++)
                         {
                             if (dataGridView1[4, i].Value.ToString() == reader1[2].ToString())
                             {
                                 count--; 
                                 dataGridView1.Rows.RemoveAt(i); return;
                                
                             }
                         }
                     }
                 }

                 reader1.Close();
                 con.Close();

                if (count == 0)
                {
                    label5.Text = "У Вас нет доступной вакансии";
                    dataGridView1.ColumnHeadersVisible = false;
                    dataGridView1.Controls.Add(label5);
                    button5.Visible = false;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Regist_Org_Form.ok = false;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                Regist_Org_Form.ok = true;

                Regist_Org_Form.vac = Int32.Parse(dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString());
            
            this.Close();
        }
    }
}
