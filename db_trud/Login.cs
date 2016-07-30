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
    

    public partial class Login : Form
    {
        public static int reg = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Guests_Form form = new Guests_Form();            
            form.ShowDialog();

            if (reg == 0)
                this.Close();
            else
                this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //Registration_Form form = new Registration_Form();
            Who_Registration form = new Who_Registration();
            form.ShowDialog();

            if (reg == 0)
                this.Close();
            else
                this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // this.Visible = false;
            label5.Visible = false;
            int flag = 0;
            string login = null;
            string pass = null;
            string table = null;
            string prim_key = null;

            SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
                      
            

            for (int i = 1; i < 4; i++)
            {
                
                switch (i)
                {
                    case 1:
                        prim_key = "Личный номер";
                        login = "ФИО";
                        pass = "Пароль";
                        table = "Сотрудники";
                        break;
                    case 2:
                        prim_key = "Личный номер";
                        login = "ФИО";
                        pass = "Номер телефона";
                        table = "Резюме";
                        break;
                    case 3:
                        prim_key = "Код";
                        login = "Наименование";
                        pass = "Номер телефона";
                        table = "Организации";
                        break;
                }

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select [" + prim_key + "], [" + login + "], [" + pass + "] from " + table + " where " + login + " like " + "@name";
               cmd.Parameters.AddWithValue("@name", textBox1.Text.Trim() + " %");
                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {                   
                    if (reader[2].ToString().Trim() == textBox2.Text)
                    {
                        flag = 1;

                        switch (i)
                        {
                            case 1:
                                break;
                            case 2:
                                this.Visible = false;
                                Regist_Users_Form form = new Regist_Users_Form(reader[1].ToString().Trim(), reader[0].ToString().Trim());
                                form.ShowDialog();
                                break;
                            case 3:
                                this.Visible = false;
                                Regist_Org_Form form_org = new Regist_Org_Form(Int32.Parse(reader[0].ToString().Trim()), reader[1].ToString().Trim());
                                form_org.ShowDialog();
                                break;
                        }
                       
                        this.Close();
                    }

                    if (flag == 1) break;
                }
                reader.Close();
                con.Close();

                if (flag == 1) break;

            }

            if (flag == 0)
            {
                label5.Visible = true;
                textBox2.Text = "";
            }
        }
    }
}
