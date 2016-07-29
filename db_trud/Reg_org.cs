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
    public partial class Reg_org : Form
    {
        int flag;

        string[] org = new string[6];

        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        SqlCommand cmd = new SqlCommand(); 

        public Reg_org()
        {
            InitializeComponent();
        }

        
        private void Reg_org_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            label2.Visible = false;
            textBox2.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Who_Registration.fl = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Who_Registration.fl = true;

            label2.Visible = false;
            label2.Text = "Такая организация уже зарегистрирована";

            org[0] = textBox2.Text.Trim();
            org[1] = textBox4.Text.Trim();
            /*org[2] = textBox19.Text.Trim();
            org[3] = textBox17.Text.Trim();
            org[4] = textBox15.Text.Trim();
            org[5] = textBox25.Text.Trim();
            org[6] = textBox27.Text.Trim();*/
            org[3] = textBox8.Text.Trim();
            org[4] = textBox10.Text.Trim();
            org[5] = textBox12.Text.Trim();

            if (org[0] == "") { label2.Visible = true; label2.Text = "Название организации обязательно для заполнения"; return; }

            if (org[4] == "") { label2.Visible = true; label2.Text = "Телефон обязателен для заполнения"; return; }


            if (textBox25.Text.Trim() != "")
            {
                org[2] = "г." + textBox19.Text.Trim() + ", ул." + textBox17.Text.Trim() + ", д." + textBox15.Text.Trim() + "/" + textBox25.Text.Trim() + ", оф." + textBox27.Text.Trim();
            }
            else
            {
                org[2] = "г." + textBox19.Text.Trim() + ", ул." + textBox17.Text.Trim() + ", д." + textBox15.Text.Trim() + ", оф." + textBox27.Text.Trim();
            }

            cmd = con.CreateCommand();

            cmd.CommandText = "select Код from Организации where Наименование='" + org[0] + " ' and Адрес='" + org[2] + "'";
           
            if (con.State == ConnectionState.Closed)
                con.Open();



            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                label2.Visible = true;
                reader.Close();
                con.Close();
            }
            else
            {
                reader.Close();

                cmd.CommandText = "select Код from Организации where Наименование='" + org[0] + " ' and [Номер телефона]='" + org[4] + "'";

                if (con.State == ConnectionState.Closed)
                    con.Open();



                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    label2.Visible = true;
                    reader.Close();
                    con.Close();
                }
                else
                {


                    int kod;

                    cmd.CommandText = "select top 1 Код from Организации order by Код desc";
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    reader.Close();


                    kod = (int)cmd.ExecuteScalar();

                    kod++;

                    cmd.CommandText = "insert into Организации values ('" + kod + "', '" + org[0] + "', '" + org[1] + "', '"
                    + org[2] + "', '" + org[3] + "', '" + org[4] + "', '" + org[5] + "')";

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    this.Visible = false;
                    Regist_Org_Form f = new Regist_Org_Form(kod, org[0]);
                    f.ShowDialog();

                    this.Close();
                }
                
            }

          


            
        }
    }
}
