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
    public partial class Vacanci_Form : Form
    {
        int org = 0;
        int vac = 0;
        bool submenu = true;

        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        SqlCommand cmd = new SqlCommand();

        public Vacanci_Form()
        {
            InitializeComponent();
        }

        public Vacanci_Form(int org, int vac)
        {
            InitializeComponent();

            submenu = true;
            this.org = org;
            this.vac = vac;
        }

        public Vacanci_Form(int org)
        {
            InitializeComponent();

            submenu = false;

            this.org = org;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vacanci_Form_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (submenu)
            {
                button5.Text = "Редактировать";
                button2.Visible = true;

                cmd.CommandText = "select Должности.Название, Вакансии.[Количество рабочих мест], Вакансии.[График работы]"
                + ", Вакансии.[Тип занятости], Вакансии.[Заработная плата], Вакансии.[Должностные обязанности]"
                + ", Вакансии.[Пол кандидата], Вакансии.[Опыт работы], Вакансии.Образование, Вакансии.Специальность"
                + ", Вакансии.[Необходимые навыки], Вакансии.[Дополнительные требования], Вакансии.Статус"
                + " from Вакансии inner join Должности on Должности.Код=Вакансии.Должность"
                + " where Вакансии.[Регистрационный номер]=" + vac;

                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.Connection = con;


                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    textBox2.Text = reader[0].ToString().Trim();
                    textBox4.Text = reader[4].ToString().Trim();
                    comboBox1.SelectedItem = reader[12].ToString().Trim();
                    textBox19.Text = reader[1].ToString().Trim();
                    comboBox2.SelectedItem = reader[2].ToString().Trim();
                    comboBox3.SelectedItem = reader[3].ToString().Trim();
                    textBox17.Text = reader[5].ToString().Trim();
                    comboBox5.SelectedItem = reader[6].ToString().Trim();
                    textBox12.Text = reader[7].ToString().Trim();
                    comboBox4.SelectedItem = reader[8].ToString().Trim();
                    textBox13.Text = reader[9].ToString().Trim();
                    textBox16.Text = reader[10].ToString().Trim();
                    textBox22.Text = reader[11].ToString().Trim();

                }

                reader.Close();
                con.Close();
            }
            else
            {
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                comboBox3.SelectedIndex = 0;
                comboBox4.SelectedIndex = 0;
                comboBox5.SelectedIndex = 0;

                button5.Text = "Добавить";
                button2.Visible = false;
            }

            this.CenterToParent();
            textBox2.Select();



        }

        private int Get_Kod(string position)
        {
            int kod = 0;

            cmd = con.CreateCommand();
            cmd.CommandText = "select Код from Должности where Название like '" + position + "'";
            if (con.State == ConnectionState.Closed)
                con.Open();

            //int kod = (int)cmd.ExecuteScalar();



            //if (kod == 0)
            if (cmd.ExecuteScalar() == null)
            {
                // int kod = (int)cmd.ExecuteScalar();

                cmd.CommandText = "select top 1 Код from Должности order by Код desc";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                kod = (int)cmd.ExecuteScalar();

                kod++;

                cmd.CommandText = "insert into Должности values ('" + kod + "', '" + position + "')";
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd.ExecuteNonQuery();

                con.Close();
            }
            else
            {
                kod = (int)cmd.ExecuteScalar();
            }

            return kod;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Вы уверены, что хотите удалить данную вакансию?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); //диалоговок окно с предложением сохранить данные из таблицы
            if (rsl == DialogResult.Yes) //если да, то сохраняем данные и закрываем приложение
            {
                cmd.CommandText = "delete from Вакансии where [Регистрационный номер]=" + vac;

                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.ExecuteNonQuery();

                con.Close();

            }
            if (rsl == DialogResult.No) //если нет, то осуществляется только выход из приложения
            {

            }
            if (rsl == DialogResult.Cancel) //если отмена - продолжается работа с приложением
            {
            }

            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "") { label1.Text = "Должность должно быть обязательно заполнено"; label1.Visible = true; return; }

                cmd.CommandText = "select [Регистрационный номер] from Вакансии inner join Должности on Должности.Код=Вакансии.Должность"
                + " where Должности.Название='" + textBox2.Text.Trim() + "' and Вакансии.Организация=" + org + " and Вакансии.Статус='" + comboBox1.SelectedItem + "' and Вакансии.[Регистрационный номер] !=" + vac;

                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    label1.Text = "Такая вакансия уже существует"; label1.Visible = true; reader.Close(); con.Close(); return;
                }
                else
                {
                    reader.Close();

                    if (submenu)
                    {
                        int kod1 = Get_Kod(textBox2.Text.Trim());


                        cmd.CommandText = "update Вакансии set Должность='" + kod1 + "', [Количество рабочих мест]='" + textBox19.Text.Trim()
                            + "', [График работы]='" + comboBox2.SelectedItem + "', [Тип занятости]='" + comboBox3.SelectedItem + "', [Заработная плата]='" + textBox4.Text.Trim()
                            + "', [Должностные обязанности]='" + textBox17.Text.Trim() + "', [Пол кандидата]='" + comboBox5.SelectedItem + "', [Опыт работы]='" + textBox12.Text.Trim()
                            + "', Образование='" + comboBox4.SelectedItem + "', Специальность='" + textBox13.Text.Trim() + "', [Необходимые навыки]='" + textBox16.Text.Trim()
                            + "', [Дополнительные требования]='" + textBox22.Text.Trim() + "', Статус='" + comboBox1.SelectedItem + "'"
                        + " where [Регистрационный номер]=" + vac;

                        if (con.State == ConnectionState.Closed)
                            con.Open();

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }

                    else
                    {
                        int kod, kod1; ;

                         cmd.CommandText = "select top 1 [Регистрационный номер] from Вакансии order by [Регистрационный номер] desc";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                kod = (int)cmd.ExecuteScalar();

                kod++;

                kod1 = Get_Kod(textBox2.Text.Trim());

                cmd.CommandText = "insert into Вакансии values ('" + kod + "', '" +  kod1 + "', '" + org + "', '" + DateTime.Now.Date.ToString()
                    + "', '" + textBox19.Text.Trim() + "', '" + comboBox2.SelectedItem + "', '" + comboBox3.SelectedItem + "', '" + textBox4.Text.Trim()
                    + "', '" + textBox17.Text.Trim() + "', '" + comboBox5.SelectedItem + "', '" + textBox12.Text.Trim()
                    + "', '" + comboBox4.SelectedItem + "', '" + textBox13.Text.Trim() + "', '" + textBox16.Text.Trim()
                    + "', '" + textBox22.Text.Trim() + "', '" + comboBox1.SelectedItem + "')";

                        if (con.State == ConnectionState.Closed)
                            con.Open();

                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                this.Close();
        }
    }
}
