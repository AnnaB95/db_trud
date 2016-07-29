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
    public partial class Regist_Users_Form : Form
    {
        #region переменные
        public static DateTime date = new DateTime();
        int count = 0;
        int submenu = 1;
        int menu = 0;
        int kod = 0;
        string fio = null;
        string num = null;
        string status = null;

        GroupBox groupbox1 = new GroupBox(), groupbox2 = new GroupBox();
        Button button1 = new Button(), button2 = new Button(), button3 = new Button(), button4 = new Button();
        Button button5 = new Button(), button6 = new Button(), button7 = new Button(), button8 = new Button(), button9 = new Button();
        Button button10 = new Button(), button11 = new Button(), button12 = new Button(), button13 = new Button();
        Button button14 = new Button(), button15 = new Button(), button16 = new Button(), button17 = new Button(), button18 = new Button();
        ListBox listbox1 = new ListBox();
        LinkLabel ll1 = new LinkLabel(), ll2 = new LinkLabel(), ll3 = new LinkLabel(), ll4 = new LinkLabel();
        LinkLabel ll5 = new LinkLabel(), ll6 = new LinkLabel();
        Panel panel3 = new Panel(), panel4 = new Panel();
       //TextBox[] textboxes = new TextBox[30];
        TextBox textboxes0 = new TextBox();
        TextBox textboxes1 = new TextBox();
        TextBox textboxes2 = new TextBox();
        TextBox textboxes3 = new TextBox();
        TextBox textboxes4 = new TextBox();
        TextBox textboxes5 = new TextBox();
        TextBox textboxes6 = new TextBox();
        TextBox textboxes7 = new TextBox();
        TextBox textboxes8 = new TextBox();
        TextBox textboxes9 = new TextBox();
        TextBox textboxes10 = new TextBox();
        TextBox textboxes11 = new TextBox();
        TextBox textboxes12 = new TextBox();
        TextBox textboxes13 = new TextBox();
        TextBox textboxes14 = new TextBox();
        TextBox textboxes15 = new TextBox();
        TextBox textboxes16 = new TextBox();
        TextBox textboxes17 = new TextBox();
        TextBox textboxes18  = new TextBox();
        TextBox textboxes19 = new TextBox();
        TextBox textboxes20 = new TextBox();
        TextBox textboxes21 = new TextBox();
        TextBox textboxes22 = new TextBox();
        TextBox textboxes23 = new TextBox();
        TextBox textboxes24 = new TextBox();
        TextBox textboxes25 = new TextBox();
        TextBox textboxes26 = new TextBox();
        TextBox textboxes27 = new TextBox();
        TextBox textboxes28 = new TextBox();
        TextBox textboxes29 = new TextBox();
          
       // ComboBox[] comboboxes = new ComboBox[3];

        ComboBox comboboxes0 = new ComboBox();
        ComboBox comboboxes1 = new ComboBox();
        ComboBox comboboxes2 = new ComboBox();

       // RadioButton[] radio = new RadioButton[2];

        RadioButton radio0 = new RadioButton();
        RadioButton radio1 = new RadioButton();

        DataGridView data1 = new DataGridView();

        Label label5 = new Label(), label6 = new Label(), label7 = new Label(), label8 = new Label(), label9 = new Label(), label10 = new Label();

        string[] info = new string[17];
        string[] work_info = new string[17];

        //string[] new_info = new string[17];
        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        SqlCommand cmd = new SqlCommand();     

        #endregion

        
        public Regist_Users_Form()
        {
            InitializeComponent();
        }


        public Regist_Users_Form(string fio, string num)
        {
            InitializeComponent();
           /* switch (i)
            {
                case 1:
                    this.Text += " админ " + fio;
                    break;
                case 2:
                    this.Text += " соискатель " + fio;
                    break;
                case 3:
                    this.Text += " работодатель " + fio;
                    break;
            }*/
            this.Text += fio;

            this.fio = fio;
            this.num = num;
        }


        private void Regist_Users_Form_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            ll1.Click += ll1_Clicked;
            ll2.Click += ll2_Clicked;
            ll3.Click += ll3_Clicked;
            ll4.Click += ll4_Clicked;
            button1.Click += But_Change_Click;
            button2.Click += But_Cancel_Click;
            button3.Click += Plus_Clicked;
            button4.Click += Minus_Clicked;
            button5.Click += Find_Clicked;
            button6.Click += Info_Clicked;
            button7.Click += Back_Clicked;
            button8.Click += Recording_Clicked;
            button9.Click += Unrecording_Clicked;
            button10.Click += Info_1_Clicked;
            button11.Click += Back_1_Clicked;
            button12.Click += Yes_Clicked;
            button13.Click += No_Clicked;
            button14.Click += Info_Work_Clicked;
            button15.Click += Find_Work_Clicked;
            button16.Click += Back_Work_Clicked;
            button17.Click += Recording_Work;
            button18.Click += Unrecording_Work;
            


        }


        #region функции стартового меню

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            редактироватьРезюмеToolStripMenuItem.ForeColor = Color.Red;

            //ll1.LinkColor = Color.Red;
                        
            Summary();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
           редактироватьРезюмеToolStripMenuItem.ForeColor = Color.Red;

           //ll1.LinkColor = Color.Red;

            Summary();
            
        }

        private void Delete_menu(Panel panel)
        {

            panel.Controls.Clear();

            this.Size = new Size(928, 590);
            this.CenterToScreen();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Delete_menu(panel1);
            Delete_menu(panel2);

            Black_Menu();
            найтиРаботуToolStripMenuItem.ForeColor = Color.Red;

            Find_Work();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Delete_menu(panel1);
            Delete_menu(panel2);

            Black_Menu();
            найтиРаботуToolStripMenuItem.ForeColor = Color.Red;

            Find_Work();


        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            курсыПереобученияповышенияКвалификацииToolStripMenuItem.ForeColor = Color.Red;

            Kurses();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            курсыПереобученияповышенияКвалификацииToolStripMenuItem.ForeColor = Color.Red;

            Kurses();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            собеседованияToolStripMenuItem.ForeColor = Color.Red;

            Interviews();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            собеседованияToolStripMenuItem.ForeColor = Color.Red;

            Interviews();

        }

        #endregion 
 
        #region работа с основным меню
        private void редактироватьРезюмеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Contains(panel4))
                Delete_menu(panel4);
            if (this.Contains(panel3))
                Delete_menu(panel3);
            if (this.Contains(panel2))
                Delete_menu(panel2);
            if (this.Contains(panel1))
                Delete_menu(panel1);


            Black_Menu();
            редактироватьРезюмеToolStripMenuItem.ForeColor = Color.Red;

            Summary();

           // ll1.LinkColor = Color.Red;

        }

        private void найтиРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Contains(panel4))
                Delete_menu(panel4);
            if (this.Contains(panel3))
                Delete_menu(panel3);
            if (this.Contains(panel2))
                Delete_menu(panel2);
            if (this.Contains(panel1))
                Delete_menu(panel1);

            Black_Menu();
            найтиРаботуToolStripMenuItem.ForeColor = Color.Red;

            Find_Work();

        }

        private void курсыПереобученияповышенияКвалификацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Contains(panel4))
                Delete_menu(panel4);
            if (this.Contains(panel3))
                Delete_menu(panel3);
            if (this.Contains(panel2))
                Delete_menu(panel2);
            if (this.Contains(panel1))
                Delete_menu(panel1);

            Black_Menu();
            курсыПереобученияповышенияКвалификацииToolStripMenuItem.ForeColor = Color.Red;

            Kurses();
        }

        private void собеседованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Contains(panel4))
                Delete_menu(panel4);
            if (this.Contains(panel3))
                Delete_menu(panel3);
            if (this.Contains(panel2))
                Delete_menu(panel2);
            if (this.Contains(panel1))
                Delete_menu(panel1);

            Black_Menu();
            собеседованияToolStripMenuItem.ForeColor = Color.Red;

            Interviews();

        }

        private void Black_Menu()
        {
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].ForeColor = Color.Black;
            }
        }

        #endregion 

        #region редактирование резюме

        private void Paint_Buttons(Panel panel) //отрисовка кнопок редактирования и отмены
        {

            panel.Controls.Add(button1);
            panel.Controls.Add(button2);

            button1.BackColor = button2.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = button2.FlatStyle = FlatStyle.Flat;
            button1.Font = button2.Font = new Font("Modern No. 20", 16, FontStyle.Bold);
            button1.ForeColor = button2.ForeColor = Color.White;
            button1.Size = button2.Size = new Size(167, 36);

            button1.Location = new Point(106, 42);
            button1.Text = "Редактировать";

            button2.Location = new Point(349, 42);
            button2.Text = "Отменить";



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

        private int Get_Educ_Kod(string position)
        {
            int kod = 0;

            cmd = con.CreateCommand();
            cmd.CommandText = "select Код from [Образовательные учреждения] where Наименование like '" + position + "'";
            if (con.State == ConnectionState.Closed)
                con.Open();

            //int kod = (int)cmd.ExecuteScalar();



            //if (kod == 0)
            if (cmd.ExecuteScalar() == null)
            {
                // int kod = (int)cmd.ExecuteScalar();

                cmd.CommandText = "select top 1 Код from [Образовательные учреждения] order by Код desc";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                kod = (int)cmd.ExecuteScalar();

                kod++;

                cmd.CommandText = "insert into [Образовательные учреждения] values ('" + kod + "', '" + position + "')";
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

        private void But_Change_Click(object sender, EventArgs e) //событие редактирования
        {
            switch(submenu)
            {
                case 1:
                    {

                        //button1.BackColor = Color.Wheat;
                        info[1] = textboxes17.Text;
                        info[6] = textboxes26.Text.Trim();
                        info[7] = textboxes27.Text.Trim();
                        info[10] = textboxes24.Text;
                        info[15] = textboxes25.Text;

                        if (radio0.Checked) info[2] = "м"; else info[2] = "ж";

                        if (textboxes23.Text.Trim() != "")
                        {
                            info[4] = "г." + textboxes19.Text.Trim() + ", ул." + textboxes20.Text.Trim() + ", д." + textboxes21.Text.Trim() + "/" + textboxes23.Text.Trim() + ", кв." + textboxes22.Text.Trim();
                        }
                        else
                        {
                            info[4] = "г." + textboxes19.Text.Trim() + ", ул." + textboxes20.Text.Trim() + ", д." + textboxes21.Text.Trim() + ", кв." + textboxes22.Text.Trim();
                        }

                        info[3] = comboboxes0.SelectedItem.ToString() + "." + comboboxes1.SelectedItem.ToString() + "." + comboboxes2.SelectedItem.ToString() + " ";


                        cmd = con.CreateCommand();
                        cmd.CommandText = "update Резюме Set ФИО='" + info[1] + "', Пол='" + info[2] + "', [Дата рождения]='" + info[3] + "', Адрес='" + info[4] + "', [Номер телефона]='" + info[6] + "', [Адрес электронной почты]='" + info[7] + "', [Личные качества]='" + info[10] + "', [Дополнительная информация]='" + info[15] + "' where [Личный номер]=" + num;

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;

                    }
                case 2:
                    {
                        //for (int i = 1; i < count + 1; i++) 
                        //{
                        int row = 0;
                        int cou = 0;
                        bool flag1 = true, flag2 = true;
                        string[] str_info = new string[6];
                        int row1 = row;

                        while(flag1)
                        {
                            if (row < data1.RowCount)
                            {

                                if (Int32.Parse(data1[1, row].Value.ToString()) - 1 == cou)
                                {
                                    row1 = row;

                                str_info[0] = data1[1, row + 1].Value.ToString();
                                str_info[1] = data1[1, row + 2].Value.ToString();
                                str_info[2] = data1[1, row + 3].Value.ToString();
                                str_info[3] = data1[1, row + 4].Value.ToString();
                                str_info[4] = data1[1, row + 5].Value.ToString();
                                str_info[5] = data1[1, row + 6].Value.ToString();

                                row = row + 7;

                                    kod = Get_Kod(str_info[0]);

                                    flag2 = true;
                                }
                            }
                            else
                                flag2 = false;


                            if (info[cou] == null)
                            {
                                //insert

                                if (flag2)
                                {
                                if ((str_info[0].Trim() != null) && (str_info[1].Trim() != null)
                                    && (str_info[3].Trim() != null) && (str_info[4].Trim() != null))
                                {
                                    //kod = Get_Kod(data1[1, (i - 1) * 6 + i].Value.ToString());

                                    cmd.CommandText = "insert into [Трудовая история] values('" + num + "', '" + kod + "', '" + str_info[1]
                                        + "', '" + str_info[2] + "', '" + str_info[3] + "', '"
                                        + str_info[4] + "', '" + str_info[5] + "')";

                                    if (con.State == ConnectionState.Closed)
                                        con.Open();
                                    cmd.ExecuteNonQuery();

                                    con.Close();


                                }
                                }
                                else flag1 = false;
                               /* cmd = con.CreateCommand();
                                cmd.CommandText = "insert into [] values ('" + num + "', */
                            }
                            else
                            {
                                string[] str = work_info[cou].Split(';');
                                
                                if (info[cou] == "+")
                                {
                                   // kod = Get_Kod(data1[1, (i - 1) * 6 + i].Value.ToString());

                                    //update                                  


                                    cmd.CommandText = "update [Трудовая история] set Должность=" + kod + ", Организация='" + str_info[1]
                                        + "', [Основные обязанности]='" + str_info[2] + "', [Дата начала работы]='"
                                        + str_info[3] + "',  [Дата прекращения работы]='" + str_info[4]
                                        + "', Характеристика='" + str_info[5] + "' where Соискатель=" + num + " and Должность=" + str[0]
                                        + " and Организация like '" + str[1] + "' and [Дата начала работы]='" + str[2] + "'";
                                   // cmd.Parameters.AddWithValue("@org", );

                                    if (con.State == ConnectionState.Closed)
                                        con.Open();
                                    cmd.ExecuteNonQuery();

                                        con.Close();
                                }
                                else
                                {
                                  //delete
                                    
                                    cmd.CommandText = "delete from [Трудовая история] where Соискатель=" + num + " and Должность=" + str[0]
                                        + " and Организация like '" + str[1] + "' and [Дата начала работы]='" + str[2] + "'";
                                    if (con.State == ConnectionState.Closed)
                                        con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                            cou++;
                        }
                        break;
                    }

                case 3:
                    {
                        int row = 0;
                        int cou = 0;
                        bool flag1 = true, flag2 = true;
                        string[] str_info = new string[6];
                        int row1 = row;

                        while (flag1)
                        {

                            if (row < data1.RowCount)
                            {

                                row1 = row;
                                if (Int32.Parse(data1[1, row].Value.ToString()) - 1 == cou)
                                {

                                if ((data1[1, row + 1].Value.ToString().Trim() == "высшее") || (data1[1, row + 1].Value.ToString().Trim() == "незаконченное высшее") || (data1[1, row + 1].Value.ToString().Trim() == "среднее профессиональное"))
                                {
                                    str_info[0] = data1[1, row + 1].Value.ToString();
                                    str_info[1] = data1[1, row + 2].Value.ToString();
                                    str_info[2] = data1[1, row + 3].Value.ToString();
                                    str_info[3] = data1[1, row + 4].Value.ToString();
                                    str_info[4] = data1[1, row + 5].Value.ToString();
                                    str_info[5] = data1[1, row + 6].Value.ToString();

                                    row = row + 7;

                                }
                                else
                                {
                                    if (data1[1, row + 1].Value.ToString().Trim() == "дополнительное")
                                    {
                                        str_info[0] = data1[1, row + 1].Value.ToString();
                                        str_info[1] = data1[1, row + 2].Value.ToString();
                                        str_info[2] = data1[1, row + 3].Value.ToString();
                                        str_info[3] = data1[1, row + 4].Value.ToString();
                                        str_info[4] = null;
                                        str_info[5] = data1[1, row + 5].Value.ToString();

                                        row = row + 6;
                                    }
                                    else
                                    {
                                        str_info[0] = data1[1, row + 1].Value.ToString();
                                        str_info[1] = data1[1, row + 2].Value.ToString();
                                        str_info[2] = data1[1, row + 3].Value.ToString();
                                        str_info[3] = null;
                                        str_info[4] = null;
                                        str_info[5] = null;

                                        row = row + 4;
                                    }
                                }

                                kod = Get_Educ_Kod(str_info[1]);

                                    flag2 = true;

                            }
                            }
                            else
                                flag2 = false;

                                if (info[cou] == null)
                                {
                                    //insert 
                         
                                    if (flag2)
                                    {
                                    if ((data1[1, row1 + 2].Value.ToString().Trim() != null) && (data1[1, row1 + 3].Value.ToString().Trim() != null))
                                    {


                                        cmd.CommandText = "insert into [Сведения об образовании] values ('" + num + "', '" + str_info[0]
                                        + "', '" + kod + "', '" + str_info[2] + "', '" + str_info[3] + "', '" + str_info[4] + "', '" + str_info[5] + "')";

                                        if (con.State == ConnectionState.Closed)
                                            con.Open();
                                        cmd.ExecuteNonQuery();

                                        con.Close();

                                    }
                                    }
                                    else flag1 = false;


                                    /*
                                                                    if ((data1[1, (i - 1) * 6 + i].Value.ToString().Trim() != null) && (data1[1, (i - 1) * 6 + i + 1].Value.ToString().Trim() != null)
                                                                        && (data1[1, (i - 1) * 6 + i + 3].Value.ToString().Trim() != null) && (data1[1, (i - 1) * 6 + i + 4].Value.ToString().Trim() != null))
                                                                    {
                                                                        kod = Get_Kod(data1[1, (i - 1) * 6 + i].Value.ToString());

                                                                        cmd.CommandText = "insert into [Трудовая история] values('" + num + "', '" + kod + "', '" + data1[1, (i - 1) * 6 + i + 1].Value
                                                                            + "', '" + data1[1, (i - 1) * 6 + i + 2].Value + "', '" + data1[1, (i - 1) * 6 + i + 3].Value.ToString().Trim() + "', '"
                                                                            + data1[1, (i - 1) * 6 + i + 4].Value.ToString().Trim() + "', '" + data1[1, (i - 1) * 6 + i + 5].Value + "')";

                                                                        if (con.State == ConnectionState.Closed)
                                                                            con.Open();
                                                                        cmd.ExecuteNonQuery();

                                                                        con.Close();
                                                                    }
                                                                   /* cmd = con.CreateCommand();
                                                                    cmd.CommandText = "insert into [] values ('" + num + "', */
                                }
                                else
                                {
                                    string[] str = work_info[cou].Split(';');

                                    if (info[cou] == "+")
                                    {
                                        // kod = Get_Educ_Kod(str_info[1]);

                                        //update                                  


                                        //kod = Get_Educ_Kod(str_info[1]);

                                        /* cmd.CommandText = "update [Трудовая история] set Должность=" + kod + ", Организация='" + data1[1, (i - 1) * 6 + i + 1].Value
                                             + "', [Основные обязанности]='" + data1[1, (i - 1) * 6 + i + 2].Value + "', [Дата начала работы]='"
                                             + data1[1, (i - 1) * 6 + i + 3].Value.ToString().Trim() + "',  [Дата прекращения работы]='" + data1[1, (i - 1) * 6 + i + 4].Value.ToString().Trim()
                                             + "', Характеристика='" + data1[1, (i - 1) * 6 + i + 5].Value + "' where Соискатель=" + num + " and Должность=" + str[0]
                                             + " and Организация like '" + str[1] + "' and [Дата начала работы]='" + str[2] + "'";*/
                                        // cmd.Parameters.AddWithValue("@org", );

                                        int kod2 = Get_Educ_Kod(str[0]);

                                        cmd.CommandText = "update [Сведения об образовании] set Соискатель=" + num + ", Уровень='" + str_info[0]
                                        + "', [Наименование учебного заведения]=" + kod + ", [Год окончания]='" + str_info[2] + "', Специальность='"
                                        + str_info[3] + "', [Квалификация по диплому]='" + str_info[4] + "', [Название курса/Факультет]='" + str_info[5]
                                        + "' where Соискатель=" + num + " and [Наименование учебного заведения]=" + kod2 + " and [Год окончания]='" + str[1] + "'";

                                        if (con.State == ConnectionState.Closed)
                                            con.Open();
                                        cmd.ExecuteNonQuery();

                                        con.Close();
                                    }
                                    else
                                    {
                                        kod = Get_Educ_Kod(str[0]);
                                        //delete

                                        cmd.CommandText = "delete from [Сведения об образовании] where Соискатель=" + num
                                            + " and [Наименование учебного заведения]="
                                            + kod + " and [Год окончания]='" + str[1] + "'";

                                        if (con.State == ConnectionState.Closed)
                                            con.Open();
                                        cmd.ExecuteNonQuery();
                                        con.Close();
                                    }
                                }
                                cou++;

                            }
                        
                        
                        break;
                    }
                case 4:
                    {
                        info[0] = textboxes1.Text;
                        info[1] = textboxes3.Text;
                        info[2] = comboboxes0.SelectedItem.ToString();
                        info[3] = comboboxes1.SelectedItem.ToString();

                        kod = Get_Kod(info[0]);

                        cmd.CommandText = "update Резюме Set [Интересующая должность]=" + kod + ", [Уровень заработной платы]='" + info[1]
                                + "', [График работы]='" + info[3] + "', [Тип занятости]='" + info[2] + "' where [Личный номер]=" + num;

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        break;
                    }
            }


        }

        private void But_Cancel_Click(object sender, EventArgs e) //событие отмены
        {
            switch (submenu)
            {
                case 1:
                    From_info_rez(info);
                    break;
                case 2:
                    Get_Work_History();
                    break;
                case 3:
                    Get_Education();
                    break;
                case 4:
                    From_info_rez(info);
                    break;
            }

           

        }

        private void Summary() //создание внешнего вида формы при редактировании резюме: отрисовка бокового меню и вызов отрисовки кнопок
        {
            /*DataGridView data = new DataGridView();
            data.Dock = DockStyle.None;
            data.Width = this.Width;
            data.Visible = true;
            data.ColumnCount = 2;
            data.Columns[0].Width = this.Width / 3;
            data.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            panel1.Controls.Add(data);
            */

            menu = 1;

            

           // panel1.Controls.Clear();
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel4);

            panel2.Dock = DockStyle.Left;
            panel2.BackColor = menuStrip1.BackColor;
            panel2.Size = new Size(324, 533);

            // panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(324, 424);
            panel3.Size = new Size(panel1.Width - panel2.Width, 112);
            //panel3.BackColor = Color.Yellow;



            panel4.Location = new Point(324, 0);
            panel4.Size = new Size(panel1.Width - panel2.Width, 424);
            //panel4.BackColor = Color.Red;

            panel2.Controls.Add(ll1);
            panel2.Controls.Add(ll2);
            panel2.Controls.Add(ll3);
            panel2.Controls.Add(ll4);

            ll1.LinkColor = ll2.LinkColor = ll3.LinkColor = ll4.LinkColor = Color.White;
            ll1.Location = new Point(90, 67);
            ll1.Text = "Обо мне";
            ll1.Font = ll2.Font = ll3.Font = ll4.Font = new Font("Modern No. 20", 22, FontStyle.Bold);
            ll1.Size = new Size(123, 31);
            ll1.LinkColor = Color.Red;

            ll2.Location = new Point(36, 144);
            ll2.Text = "Трудовая история";
            ll2.Size = new Size(243, 31);


            ll3.Location = new Point(61, 221);
            ll3.Text = "Образование";
            ll3.Size = new Size(182, 31);

            ll4.Location = new Point(61, 298);
            ll4.Text = "Предпочтения";
            ll4.Size = new Size(198, 31);

            Paint_Buttons(panel3);

            About_me();      
        }


        private void About_me() //отрисовка подменю обо мне
    {
        submenu = 1;

        panel4.Controls.Clear();
           /*panel4.Controls.AddRange(textboxes);
            panel4.Controls.Remove(textboxes[29]);
            panel4.Controls.Remove(textboxes[28]);
            panel4.Controls.AddRange(comboboxes);*/
        panel4.Controls.Add(textboxes0);
        panel4.Controls.Add(textboxes1);
        panel4.Controls.Add(textboxes2);
        panel4.Controls.Add(textboxes3);
        panel4.Controls.Add(textboxes4);
        panel4.Controls.Add(textboxes5);
        panel4.Controls.Add(textboxes6);
        panel4.Controls.Add(textboxes7);
        panel4.Controls.Add(textboxes8);
        panel4.Controls.Add(textboxes9);
        panel4.Controls.Add(textboxes10);
        panel4.Controls.Add(textboxes11);
        panel4.Controls.Add(textboxes12);
        panel4.Controls.Add(textboxes13);
        panel4.Controls.Add(textboxes14);
        panel4.Controls.Add(textboxes15);
        panel4.Controls.Add(textboxes16);
        panel4.Controls.Add(textboxes17);
        panel4.Controls.Add(textboxes18);
        panel4.Controls.Add(textboxes19);
        panel4.Controls.Add(textboxes20);
        panel4.Controls.Add(textboxes21);
        panel4.Controls.Add(textboxes22);
        panel4.Controls.Add(textboxes23);
        panel4.Controls.Add(textboxes24);
        panel4.Controls.Add(textboxes25);
        panel4.Controls.Add(textboxes26);
        panel4.Controls.Add(textboxes27);

        panel4.Controls.Add(comboboxes0);
        panel4.Controls.Add(comboboxes1);
        panel4.Controls.Add(comboboxes2);
        
           

           /* for (int i = 0; i < comboboxes.Count(); i++)
            {
                comboboxes[i] = new ComboBox();
            }

            for (int i = 0; i < textboxes.Count(); i++)
            {
                textboxes[i] = new TextBox();
            }*/

            comboboxes0.DropDownStyle = comboboxes1.DropDownStyle = comboboxes2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxes0.Font = comboboxes1.Font = comboboxes2.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            comboboxes0.Items.Clear();
            comboboxes1.Items.Clear();
            comboboxes2.Items.Clear();


            for (int i = DateTime.Now.Year - 18; i >= DateTime.Now.Year - 100; i--)
                comboboxes2.Items.Add(i.ToString());

            for (int i = 1; i <= 31; i++)
            {
                comboboxes0.Items.Add(i.ToString());
            }

            for (int i = 1; i <= 12; i++)
            {
                string month;

                if (i < 10)
                    month = "0" + i.ToString();
                else month = i.ToString();

                comboboxes1.Items.Add(month);
            }

            comboboxes0.Size = new Size(62, 26);
            comboboxes1.Size = new Size(60, 26);
            comboboxes2.Size = new Size(60, 26);

            comboboxes0.Location = new Point(275, 53);
            comboboxes1.Location = new Point(408, 53);
            comboboxes2.Location = new Point(535, 53);

           /* for (int i = 0; i < 17; i++)
            {
                textboxes[i].Font = new Font("Modern No. 20", 12, FontStyle.Bold);
                textboxes[i].ReadOnly = true;
            }

            for (int i = 17; i < 29; i++)
            {
                textboxes[i].Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            }*/

            textboxes0.Font = textboxes1.Font = textboxes2.Font = textboxes3.Font = textboxes4.Font = textboxes5.Font = textboxes6.Font = 
            textboxes7.Font = textboxes8.Font = textboxes9.Font = textboxes10.Font = textboxes11.Font = textboxes12.Font = textboxes13.Font =
            textboxes14.Font = textboxes15.Font = textboxes16.Font  = new Font("Modern No. 20", 12, FontStyle.Bold);

            textboxes0.ReadOnly = textboxes1.ReadOnly = textboxes2.ReadOnly = textboxes3.ReadOnly = textboxes4.ReadOnly = textboxes5.ReadOnly =
            textboxes6.ReadOnly = textboxes7.ReadOnly = textboxes8.ReadOnly = textboxes9.ReadOnly = textboxes10.ReadOnly = textboxes11.ReadOnly =
            textboxes12.ReadOnly = textboxes13.ReadOnly = textboxes14.ReadOnly = textboxes15.ReadOnly = textboxes16.ReadOnly =  true;

           textboxes17.Font = textboxes18.Font = textboxes19.Font = textboxes20.Font = textboxes21.Font = textboxes22.Font = textboxes23.Font =
           textboxes24.Font = textboxes25.Font = textboxes26.Font = textboxes27.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            textboxes0.Size = textboxes1.Size = textboxes2.Size = textboxes7.Size = textboxes8.Size = textboxes15.Size = textboxes16.Size = new Size(198, 25);
            textboxes3.Size = textboxes4.Size = textboxes5.Size = new Size(71, 25);
            textboxes6.Size = textboxes14.Size = new Size(589, 25);            
            textboxes9.Size = new Size(68, 25);
            textboxes10.Size = new Size(97, 25);
            textboxes11.Size = new Size(123, 25);
            textboxes12.Size = textboxes13.Size = new Size(200, 75);

            textboxes17.Size = textboxes18.Size = textboxes19.Size = textboxes20.Size = textboxes26.Size = textboxes27.Size = new Size(391, 25);
            textboxes21.Size = textboxes22.Size = textboxes23.Size = new Size(114, 25);
            textboxes24.Size = textboxes25.Size = new Size(391, 75);

            textboxes12.Multiline = textboxes13.Multiline = textboxes24.Multiline = textboxes25.Multiline = true;

            textboxes18.ReadOnly = true;
            textboxes18.BackColor = Color.White;

            textboxes6.TextAlign = textboxes14.TextAlign = HorizontalAlignment.Center;

            textboxes0.Location = new Point(6, 3);
            textboxes1.Location = new Point(6, 28);
            textboxes2.Location = new Point(6, 53);
            textboxes3.Location = new Point(204, 53);
            textboxes4.Location = new Point(337, 53);
            textboxes5.Location = new Point(468, 53);
            textboxes6.Location = new Point(6, 78);
            textboxes7.Location = new Point(6, 103);
            textboxes8.Location = new Point(6, 128);
            textboxes9.Location = new Point(6, 153);
            textboxes10.Location = new Point(185, 153);
            textboxes11.Location = new Point(362, 153);
            textboxes12.Location = new Point(6, 178);
            textboxes13.Location = new Point(6, 253);
            textboxes14.Location = new Point(6, 328);
            textboxes15.Location = new Point(6, 353);
            textboxes16.Location = new Point(6, 378);
            textboxes17.Location = new Point(204, 3);
            textboxes18.Location = new Point(204, 28);
            textboxes19.Location = new Point(204, 103);
            textboxes20.Location = new Point(204, 128);
            textboxes21.Location = new Point(72, 153);
            textboxes22.Location = new Point(481, 153);
            textboxes23.Location = new Point(279, 153);
            textboxes24.Location = new Point(204, 178);
            textboxes25.Location = new Point(204, 253);
            textboxes26.Location = new Point(204, 353);
            textboxes27.Location = new Point(204, 378);
            

          
            textboxes0.Text = "ФИО";
            textboxes1.Text = "Пол";
            textboxes2.Text = "Дата рождения";
            textboxes3.Text = "День";
            textboxes4.Text = "Месяц";
            textboxes5.Text = "Год";
            textboxes6.Text = "Адрес";
            textboxes7.Text = "Город";
            textboxes8.Text = "Улица";
            textboxes9.Text = "Дом";
            textboxes10.Text = "Корпус";
            textboxes11.Text = "Квартира";
            textboxes12.Text = "Личные качества";
            textboxes13.Text = "Дополнительная информация";
            textboxes14.Text = "Контактная информация";
            textboxes15.Text = "Телефон";
            textboxes16.Text = "E-mail";

            //panel4.Controls.AddRange(radio);

            panel4.Controls.Add(radio0);
            panel4.Controls.Add(radio1);

           /* for (int i = 0; i < radio.Count(); i++)
            {
                radio[i] = new RadioButton();

                radio[i].Size = new Size(33, 17);
            }*/

            radio0.Text = "м";
            radio1.Text = "ж";

            radio0.Location = new Point(310, 32);
            radio1.Location = new Point(448, 32);

            textboxes18.Visible = false;
            
            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Резюме where [Личный номер] = " + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Array.Clear(info, 0, info.Length);

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    info[i] = reader[i].ToString();
                }
               
            }
            reader.Close();
            con.Close();

            

            // textboxes[17].Text = info[1];
            //textboxes[19].Text =     

            From_info_rez(info);
}

        private void Work_history()
        {
            submenu = 2;
                            

            panel4.Controls.Clear();

            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(data1);

            button3.Text = "Plus";
            button3.Location = new Point(153, 33);


            button4.Text = "Minus";
            button4.Location = new Point(391, 33);

            data1.ColumnCount = 2;
            data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 200;
            data1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = false;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = false;
            data1.Location = new Point(54, 99);
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data1.Visible = true;


            label5.Dock = DockStyle.Fill;
            label5.Text = "Информация о прежних местах работы отсутствует";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);
         


            Get_Work_History();

            if (count == 0)
            {
                data1.Controls.Add(label5);               
            }
          

        }//отрисовка подменю трудовая история

        private void Education()
        {
            submenu = 3;

            panel4.Controls.Clear();

            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Controls.Add(data1);

            button3.Text = "Plus";
            button3.Location = new Point(153, 33);


            button4.Text = "Minus";
            button4.Location = new Point(391, 33);

            data1.ColumnCount = 2;
            data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 200;
            data1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = false;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.ReadOnly = false;
            data1.AllowUserToResizeRows = false;
            data1.Location = new Point(54, 99);
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data1.Visible = true;


            label5.Dock = DockStyle.Fill;
            label5.Text = "Информация об образовании отсутствует";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);



            Get_Education();

            if (count == 0)
            {
                data1.Controls.Add(label5);
            }
          

        }

        private void Preferences()
        {
            submenu = 4;

            panel4.Controls.Clear();

            panel4.Controls.Add(textboxes0);
            panel4.Controls.Add(textboxes1);
            panel4.Controls.Add(textboxes2);
            panel4.Controls.Add(textboxes3);
            panel4.Controls.Add(textboxes4);
            panel4.Controls.Add(textboxes5);
            panel4.Controls.Add(textboxes6);


            panel4.Controls.Add(comboboxes0);
            panel4.Controls.Add(comboboxes1);


            comboboxes0.DropDownStyle = comboboxes1.DropDownStyle  = ComboBoxStyle.DropDownList;
            comboboxes0.Font = comboboxes1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            comboboxes0.Items.Clear();
            comboboxes1.Items.Clear();

            comboboxes0.Items.Add((object)("полная"));
            comboboxes0.Items.Add("частичная");
            comboboxes0.Items.Add("временная");
            comboboxes0.Items.Add("стажировка");
            comboboxes0.Items.Add("сезонная");
            comboboxes0.Items.Add("удаленная");

            comboboxes1.Items.Add("полный рабочий день");
            comboboxes1.Items.Add("сменный график");
            comboboxes1.Items.Add("гибкий график");
            comboboxes1.Items.Add("вахтовый метод");
            comboboxes1.Items.Add("ненормированный рабочий день");
            comboboxes1.Items.Add("неполный рабочий день");

            comboboxes0.Size = comboboxes1.Size = new Size(250, 25);

            comboboxes0.Location = new Point(279, 258);
            comboboxes1.Location = new Point(279, 198);

            textboxes0.Font   = textboxes2.Font  = textboxes4.Font = textboxes5.Font = textboxes6.Font = new Font("Modern No. 20", 12, FontStyle.Bold);
            textboxes1.Font = textboxes3.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            textboxes0.ReadOnly  = textboxes2.ReadOnly = textboxes6.ReadOnly = textboxes4.ReadOnly = textboxes5.ReadOnly = true;
            textboxes1.ReadOnly = textboxes3.ReadOnly  = false;



            textboxes0.Size = textboxes2.Size = textboxes5.Size = textboxes6.Size = new Size(215, 25);
            textboxes1.Size = new Size(250, 25);
            textboxes3.Size = new Size(200, 25);
            textboxes4.Size = new Size(50, 25);

            textboxes0.TextAlign = textboxes2.TextAlign = textboxes4.TextAlign = textboxes5.TextAlign = textboxes6.TextAlign = HorizontalAlignment.Center;

            textboxes1.Text = textboxes3.Text = "";

            textboxes0.Location = new Point(64, 78);
            textboxes1.Location = new Point(279, 78);
            textboxes2.Location = new Point(64, 138);
            textboxes3.Location = new Point(279, 138);
            textboxes4.Location = new Point(479, 138);
            textboxes5.Location = new Point(64, 198);
            textboxes6.Location = new Point(64, 258);

            textboxes0.Text = "Интересующая должность";
            textboxes2.Text = "Уровень заработной платы";
            textboxes4.Text = "руб.";
            textboxes5.Text = "График работы";
            textboxes6.Text = "Тип занятости";

            Array.Clear(info, 0, info.Length);

            cmd.CommandText = "select Должности.Название, Резюме.[Уровень заработной платы], Резюме.[График работы], Резюме.[Тип занятости]"
                + " from Резюме inner join Должности on Должности.Код = Резюме.[Интересующая должность]"
                + " where [Личный номер]=" + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    info[i] = reader[i].ToString();
                }

            }
            reader.Close();
            con.Close();

            From_info_rez(info);
        }

        private void Get_Work_History()
        {

            count = 0; 

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Должности.Название, [Трудовая история].Организация," +
            " [Трудовая история].[Основные обязанности], [Трудовая история].[Дата начала работы]," +
            " [Трудовая история].[Дата прекращения работы], [Трудовая история].Характеристика, [Трудовая история].Должность" +
            " from [Трудовая история] inner join Должности on [Трудовая история].Должность=Должности.Код" +
            " where Соискатель = " + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Array.Clear(info, 0, info.Length);

            while (reader.Read())
            {
                /* for (int i = 0; i < reader.FieldCount; i++)
                 {
                     info[i] = reader[i].ToString();
                 }*/
                info[count] = "+";
                work_info[count] = reader[6] + ";" + reader[1] + ";" + reader[3];
                count++;
                Add_Rows();

                for (int i = 0; i < 6; i++)
                {
                    //dataGridView1.Rows[i].HeaderCell.Value = num.ToString();
                    // dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;
                    if (i == 3 || i == 4)
                    {
                        string str = reader[i].ToString();
                        str = str.Substring(0, str.IndexOf(' '));
                        data1[1, (count - 1) * 6 + count + i].Value = str;
                    }
                    else
                    {
                        data1[1, (count - 1) * 6 + count + i].Value = reader[i].ToString(); ;
                    }
                }

            }
            reader.Close();
            con.Close();
        } //получение данных из бд о прежних местах работы

        private void Get_Education()
        {
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();

            cmd.CommandText = "select [Сведения об образовании].Уровень, [Образовательные учреждения].Наименование, [Сведения об образовании].[Год окончания]," 
                + " [Сведения об образовании].Специальность, [Сведения об образовании].[Квалификация по диплому], [Сведения об образовании].[Название курса/Факультет]"
                + " from [Сведения об образовании] inner join [Образовательные учреждения] on [Сведения об образовании].[Наименование учебного заведения]=[Образовательные учреждения].Код"
                + " where [Сведения об образовании].Соискатель = " + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            Array.Clear(info, 0, info.Length);

            while (reader.Read())
            {
                /* for (int i = 0; i < reader.FieldCount; i++)
                 {
                     info[i] = reader[i].ToString();
                 }*/
                info[count] = "+";
                work_info[count] = reader[1] + ";" + reader[2];
                count++;
                if ((reader[0].ToString().Trim() == "высшее") || (reader[0].ToString().Trim() == "незаконченное высшее") || (reader[0].ToString().Trim() == "среднее профессиональное"))
                {
                    kod = 6;
                }
                else
                {
                    if (reader[0].ToString().Trim() == "дополнительное")
                    {
                        kod = 5;
                    }
                    else
                    {
                        kod = 3;
                    }
                }

                Add_Rows();


               for (int i = 0; i < kod; i++)
                
                    {
                   if ((kod == 5) && (i == 4))
                        data1[1, data1.RowCount - kod + i].Value = reader[i + 1].ToString(); 
                   else
                        data1[1, data1.RowCount - kod + i].Value = reader[i].ToString(); 
                    }
                

            }
            reader.Close();
            con.Close();
        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5); 
            }
            switch (submenu)
            {
                case 2:
                    {
                        count++;
                        Add_Rows();
                        break;
                    }
                case 3:
                    {
                        Educ form = new Educ();
                        form.ShowDialog();
                        if (Educ.fl == 1)
                        {
                            if ((Educ.ur == "высшее") || (Educ.ur == "незаконченное высшее") || (Educ.ur == "среднее профессиональное"))
                            {
                                kod = 6;
                            }
                            else
                            {
                                if (Educ.ur == "дополнительное")
                                {
                                    kod = 5;
                                }
                                else
                                {
                                    kod = 3;
                                }
                            }
                            count++;
                            Add_Rows();

                            data1[1, data1.RowCount - kod].Value = Educ.ur;
                        }
                        
                        break;
                    }
            }
        }

        private void Minus_Clicked(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
                Remove_Rows();
            }
        }

        private void Add_Rows()
        {
            if (data1.Contains(label5)) data1.Controls.Remove(label5);

            switch (submenu)
            {
                case 2:
                    {
                        data1.Rows.Add("Запись", count.ToString());
                        data1.Rows.Add("Должность", "");
                        data1.Rows.Add("Организация", "");
                        data1.Rows.Add("Основные обязанности", "");
                        data1.Rows.Add("Дата начала работы", "");
                        data1.Rows.Add("Дата прекращения работы", "");
                        data1.Rows.Add("Характеристика", "");
                        data1[0, (count - 1) * 6 + count - 1].ReadOnly = true;
                        data1[1, (count - 1) * 6 + count - 1].ReadOnly = true;
                        data1[0, (count - 1) * 6 + count - 1].Style.BackColor = Color.Gray;
                        data1[1, (count - 1) * 6 + count - 1].Style.BackColor = Color.Gray;
                        data1.Rows[count * 6 + count - 1].HeaderCell.Style.BackColor = Color.Gray;
                        data1[0, (count - 1) * 6 + count - 1].Style.ForeColor = Color.White;
                        data1[1, (count - 1) * 6 + count - 1].Style.ForeColor = Color.White;

                        //dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;

                        for (int i = count * 6 + count - 7; i < count * 6 + count - 1; i++)
                        {
                            //dataGridView1.Rows[i].HeaderCell.Value = num.ToString();
                            // dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;
                            data1[0, i].ReadOnly = true;

                        }

                        int rowNum = (count - 1) * 6 + count;
                        DataGridViewCell cell = data1.Rows[rowNum].Cells[1];
                        data1.CurrentCell = cell;
                        data1.CurrentCell.Selected = true; // в некоторых случаях без этого не работает

                        break;
                    }

                case 3:
                    {
                        switch (kod)
                        {
                            case 3:
                                {
                                    data1.Rows.Add("Запись", count.ToString());
                                    data1.Rows.Add("Уровень", "");
                                    data1.Rows.Add("Учебное заведение", "");
                                    data1.Rows.Add("Год окончания", "");
                                 
                                    break;
                                }
                            case 5:
                                {
                                    data1.Rows.Add("Запись", count.ToString());
                                    data1.Rows.Add("Уровень", "");
                                    data1.Rows.Add("Учебное заведение", "");
                                    data1.Rows.Add("Год окончания", "");
                                    data1.Rows.Add("Специализация", "");                                   
                                    data1.Rows.Add("Название курса", "");
                                    break;
                                }
                            case 6:
                                {
                                    data1.Rows.Add("Запись", count.ToString());
                                    data1.Rows.Add("Уровень", "");
                                    data1.Rows.Add("Учебное заведение", "");
                                    data1.Rows.Add("Год окончания", "");
                                    data1.Rows.Add("Специализация", "");
                                    data1.Rows.Add("Квалификация по диплому", "");
                                    data1.Rows.Add("Факультет", "");
                                    break;
                                }

                        
                                
                        }

                        data1[0, data1.RowCount - kod - 1].ReadOnly = true;
                        data1[1, data1.RowCount - kod - 1].ReadOnly = true;
                        data1[0, data1.RowCount - kod - 1].Style.BackColor = Color.Gray;
                        data1[1, data1.RowCount - kod - 1].Style.BackColor = Color.Gray;
                        data1.Rows[data1.RowCount - kod - 1].HeaderCell.Style.BackColor = Color.Gray;
                        data1[0, data1.RowCount - kod - 1].Style.ForeColor = Color.White;
                        data1[1, data1.RowCount - kod - 1].Style.ForeColor = Color.White;

                        //dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;

                        for (int i = data1.RowCount - kod; i <data1.RowCount; i++)
                        {
                            //dataGridView1.Rows[i].HeaderCell.Value = num.ToString();
                            // dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;
                            data1[0, i].ReadOnly = true;

                        }

                        int rowNum = data1.RowCount - kod;
                        DataGridViewCell cell = data1.Rows[rowNum].Cells[1];
                        data1.CurrentCell = cell;
                        data1.CurrentCell.Selected = true; // в некоторых случаях без этого не работает*/
                                               
                        break;
                    }
            }

        }

        private void Remove_Rows()
        {
            int min = 0;
            int max = data1.RowCount;
            int sel = data1.CurrentRow.Index;

            for (int i = sel; i > -1; i--)
            {
                if (data1[0, i].Value.ToString() == "Запись")
                {
                    min = i;
                    break;
                }
                
            }

            for (int i = sel + 1; i < data1.RowCount; i++)
            {
                if (data1[0, i].Value.ToString() == "Запись")
                {
                    max = i;
                    break;
                }
            }

            if (info[Int32.Parse(data1[1, min].Value.ToString()) - 1] == "+") info[Int32.Parse(data1[1, min].Value.ToString()) - 1] = "-";

            for (int i = max - 1; i >= min; i--)
                data1.Rows.RemoveAt(i);

             if (count == 0)
            {
                data1.Controls.Add(label5);
            }

            /*
            int k = count;
            if (data1.CurrentRow != null)
            {
                //dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                k = data1.CurrentRow.Index / 7;

                // if (k > 0) k = k - 1;
            }

            if (info[k] == "+") info[k] = "-";

            for (int i = (k + 1) * 6 + k; i > (k + 1) * 6 + k - 1 - 6; i--)
                data1.Rows.RemoveAt(i);

            if (data1.RowCount != 0)
            {
                int rowNum = (k - 1) * 6 + k;
                if (rowNum < 0) rowNum = 1;
                DataGridViewCell cell = data1.Rows[rowNum].Cells[1];
                data1.CurrentCell = cell;
                data1.CurrentCell.Selected = true;
            }

            if (k != count)
            {
                int kol = k + 1;
                for (int i = (k) * 6 + k; i < data1.RowCount; i = (k) * 6 + k)
                {
                    data1[1, i].Value = kol;
                    kol++;
                    k++;
                }
            }

            if (count == 0)
            {
                data1.Controls.Add(label5);
            }*/
        }

        private void ll1_Clicked(object sender, EventArgs e)
        {
            switch (menu)
            {
                case 1:
                    About_me();                    
                    break;
                case 2:
                    My_Vacancies();
                    break;
                case 3:
                    My_Kurses();
                    break;
                case 4:
                    Soon();
                    break;
            }
            White_Link();
            ll1.LinkColor = Color.Red;
        }

        private void ll2_Clicked(object sender, EventArgs e)
        {
            switch (menu)
            {
                case 1:
                    Work_history();
                    break;
                case 2:
                    All_Vacancies();
                    break;
                case 3:
                    All_Kurses();
                    break;
                case 4:
                    Invitations();
                    break;
            }
            White_Link();
            ll2.LinkColor = Color.Red;

        }

        private void ll3_Clicked(object sender, EventArgs e)
        {
            switch (menu)
            {
                case 1:
                    Education();
                    break;
                case 4:
                    Past();
                    break;
            }
            White_Link();
            ll3.LinkColor = Color.Red;
        }

        private void ll4_Clicked(object sender, EventArgs e)
        {
            switch (menu)
            {
                case 1:
                    {
                        Preferences();                        
                        break;
                    }
                case 4:
                    {
                        Request();                        
                        break;
                    }
            }
            White_Link();
            ll4.LinkColor = Color.Red;
        }


        private void White_Link()
        {
            ll1.LinkColor = ll2.LinkColor = ll3.LinkColor = ll4.LinkColor = Color.White;
        }

        private void From_info_rez(string[] info) //заполнение данными из таблицы подменю обо мне и предпочтения
        {
            switch (submenu)
            {
                case 1:
                    {

                        textboxes17.Text = info[1].Trim();
                        textboxes26.Text = info[6].Trim();
                        textboxes27.Text = info[7].Trim();
                        textboxes24.Text = info[10];
                        textboxes25.Text = info[15];

                        if (info[2].Trim() == "ж") radio1.Checked = true; else radio0.Checked = true;

                        int flag = 0;

                        flag = info[3].IndexOf('.');

                        comboboxes0.SelectedItem = info[3].Substring(0, flag);
                        comboboxes1.SelectedItem = info[3].Substring(flag + 1, info[3].IndexOf('.', flag + 1) - flag - 1);
                        flag = info[3].IndexOf('.', flag + 1);
                        comboboxes2.SelectedItem = info[3].Substring(flag + 1, info[3].IndexOf(' ', flag + 1) - flag - 1);

                        flag = 0;

                        flag = info[4].IndexOf('.', flag) + 1;
                        textboxes19.Text = info[4].Substring(flag, info[4].IndexOf(',', flag) - flag);
                        flag = info[4].IndexOf(',', flag) + 1;
                        flag = info[4].IndexOf('.', flag) + 1;
                        textboxes20.Text = info[4].Substring(flag, info[4].IndexOf(',', flag) - flag);
                        flag = info[4].IndexOf(',', flag) + 1;

                        if (info[4].IndexOf('/') != -1)
                        {
                            flag = info[4].IndexOf('.', flag) + 1;
                            textboxes21.Text = info[4].Substring(flag, info[4].IndexOf('/') - flag);
                            flag = info[4].IndexOf('/') + 1;
                            textboxes23.Text = info[4].Substring(flag, info[4].IndexOf(',', flag) - flag);
                            flag = info[4].IndexOf(',', flag) + 1;
                        }
                        else
                        {
                            flag = info[4].IndexOf('.', flag) + 1;

                            textboxes21.Text = info[4].Substring(flag, info[4].IndexOf(',', flag) - flag);
                            flag = info[4].IndexOf(',', flag) + 1;
                        }

                        flag = info[4].IndexOf('.', flag) + 1;

                        textboxes22.Text = info[4].Substring(flag, info[4].Length - flag);
                        break;
                    }

                case 4:
                    {
                        textboxes1.Text = info[0];
                        textboxes3.Text = info[1];
                        comboboxes1.SelectedItem = info[2].Trim();
                        comboboxes0.SelectedItem = info[3].Trim();
                        break;
                    }
            }
        }

        #endregion


        #region поиск работы

        private void Find_Work()
        {
            menu = 2;

            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            //panel1.Controls.Add(panel4);


            //panel2.Location = new Point(0, 180);
            panel2.BackColor = menuStrip1.BackColor;
            panel2.Size = new Size(242, 371);
            panel2.Dock = DockStyle.Left;

           

            /*panel4.Size = new Size(panel1.Width - panel2.Width, 172);
            panel4.Location = new Point(242, 0);*/
            //panel4.BackColor = Color.Red;
            panel3.Size = new Size(panel1.Width - panel2.Width, panel2.Height);
            panel3.Location = new Point(242, 0);

            panel2.Controls.Add(ll1);
            panel2.Controls.Add(ll2);


            ll1.LinkColor = ll2.LinkColor = Color.White;
            ll1.Font = ll2.Font = new Font("Modern No. 20", 22, FontStyle.Bold);

            ll1.Location = new Point(52, 152);
            ll1.Text = "Для меня";
            ll1.Size = new Size(200, 31);
            ll1.LinkColor = Color.Red;

            ll2.Location = new Point(32, 293);
            ll2.Text = "Все вакансии";
            ll2.Size = new Size(200, 31);

            panel3.Controls.Add(data1);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(groupbox2);


            data1.ColumnCount = 3;
            // data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 250;
            data1.Columns[1].Width = 250;
            data1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data1.Columns[0].Name = "Должность";
            data1.Columns[1].Name = "Организация";
            data1.Columns[2].Name = "Заработная плата";
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = true;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = true;
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular); 
            data1.Size = new Size(panel3.Width - 18, 284);
            data1.Location = new Point(9, 185);

            /*panel4.Controls.Add(groupbox2);
            panel4.Controls.Add(button15);*/


            groupbox2.Location = new Point(9, 6);
            groupbox2.Size = new Size(panel3.Width - 18, 166);
            groupbox2.Text = "Поиск";

            groupbox2.Controls.Add(label6);
            groupbox2.Controls.Add(label7);
            groupbox2.Controls.Add(label8);
            groupbox2.Controls.Add(textboxes0);
            groupbox2.Controls.Add(textboxes1);
            groupbox2.Controls.Add(textboxes2);
            groupbox2.Controls.Add(button15);



            label6.Font = label7.Font = label8.Font = label9.Font = label10.Font = new Font("Modern No. 20", 12, FontStyle.Bold);

            label6.Text = "Должность";
            label6.Location = new Point(6, 48);
            label6.Size = new Size(107, 25);

            label7.Text = "Организация";
            label7.Location = new Point(335, 48);
            label7.Size = new Size(107, 25);

            label8.Text = "Заработная плата";
            label8.Location = new Point(180, 90);
            label8.Size = new Size(157, 25);

            textboxes0.Text = textboxes1.Text = textboxes2.Text = "";
            textboxes0.ReadOnly = textboxes1.ReadOnly = textboxes2.ReadOnly = false;
            textboxes2.Size = new Size(150, 25);
            textboxes1.Size = textboxes0.Size = new Size(200, 25);
            textboxes0.Location = new Point(120, 48);
            textboxes1.Location = new Point(448, 48);
            //label1.Click = label1_Click1();
            textboxes2.Location = new Point(342, 90);
            textboxes0.Font = textboxes1.Font = textboxes2.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            button14.BackColor = button15.BackColor = Color.FromArgb(0, 192, 0);
            button14.FlatStyle = button15.FlatStyle = FlatStyle.Flat;
            button14.Font = button15.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button14.ForeColor = button15.ForeColor = Color.White;
            button14.Size = button15.Size = new Size(120, 30);
            button15.Location = new Point(274, 130);
            button14.Location = new Point(486, 484);
            button15.Text = "Найти";
            button14.Text = "Подробнее";


            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            My_Vacancies();
        }

        private void My_Vacancies()
        {

            if (panel3.Contains(button16)) panel3.Controls.Remove(button16);
            if (panel3.Contains(button17)) panel3.Controls.Remove(button17);
            if (panel3.Contains(button18)) panel3.Controls.Remove(button18);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);

           
            data1.Visible = true;
            button14.Visible = true;
            groupbox2.Visible = false;

            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

            submenu = 1;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            string[] str = new string[4];

            cmd = con.CreateCommand();
            cmd.CommandText = "select [Интересующая должность], [Уровень заработной платы], [График работы], [Тип занятости]"
                + " from Резюме where [Личный номер]=" + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                str[0] = reader[0].ToString().Trim();
                str[1] = reader[1].ToString().Trim();
                str[2] = reader[2].ToString().Trim();
                str[3] = reader[3].ToString().Trim();

            }

            reader.Close();

            cmd = con.CreateCommand();
            cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
            + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Вакансии.Должность='" + str[0] + "' and Вакансии.[Заработная плата]>='" + str[1]
            + "' and Вакансии.[График работы]='" + str[2] + "' and Вакансии.[Тип занятости]='" + str[3] + "' and Вакансии.Статус='активна'";


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                data1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim());
                count++;
            }

            reader1.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Для Вас пока нет ни одной вакансии";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button14.Visible = false;
            }
        }

        private void All_Vacancies()
        {
            if (panel3.Contains(button16)) panel3.Controls.Remove(button16);
            if (panel3.Contains(button17)) panel3.Controls.Remove(button17);
            if (panel3.Contains(button18)) panel3.Controls.Remove(button18);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);


            data1.Visible = true;
            button14.Visible = true;
            groupbox2.Visible = true;

            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

            submenu = 2;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
            + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Вакансии.Статус='активна'";


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            while (reader1.Read())
            {
                data1.Rows.Add(reader1[0].ToString().Trim(), reader1[1].ToString().Trim(), reader1[2].ToString().Trim());
                count++;
            }

            reader1.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Нет ни одной вакансии";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button14.Visible = false;
            }
        }

        private void Info_Work_Clicked(object sender, EventArgs e)
        {
            string[] str = new string[3];
            str[0] = data1[0, data1.CurrentRow.Index].Value.ToString();
            str[1] = data1[1, data1.CurrentRow.Index].Value.ToString();
            //str[2] = data1[2, data1.CurrentRow.Index].Value.ToString();

            //groupbox1.Visible = false;

            data1.Visible = false;
            groupbox2.Visible = false;

            button14.Visible = false;

            panel3.Controls.Add(listbox1);

            listbox1.Size = new Size(panel3.Width - 18, 384);
            listbox1.Location = new Point(9, 52);
            listbox1.Items.Clear();
            listbox1.Font = new Font("Modern No. 20", 14, FontStyle.Regular);

            cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата],"
            + " Организации.Адрес, Вакансии.[График работы], Вакансии.[Тип занятости], Вакансии.[Количество рабочих мест],"
            + " Вакансии.[Должностные обязанности], Вакансии.[Пол кандидата], Вакансии.[Опыт работы],"
            + " Вакансии.Образование, Вакансии.Специальность, Вакансии.[Необходимые навыки],"
            + " Вакансии.[Дополнительные требования], Организации.[Контактное лицо], Организации.[Номер телефона], Организации.[Адрес электронной почты], Вакансии.[Регистрационный номер]"
            + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Должности.Название='" + str[0] + "' and Организации.Наименование='" + str[1]
                /*+ "' and Статус='" + str[2]*/ + "'" + " and Вакансии.Статус='активна'";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listbox1.Items.Add("Должность:  " + reader[0].ToString().Trim());

                listbox1.Items.Add("Организация:  " + reader[1].ToString().Trim());

                listbox1.Items.Add("Заработная плата:  " + reader[2].ToString());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Адрес:  " + reader[3].ToString());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Данные по вакансии");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("График работы:  " + reader[4].ToString().Trim());

                listbox1.Items.Add("Тип занятости:  " + reader[5].ToString().Trim());

                listbox1.Items.Add("Количество рабочих мест:  " + reader[6].ToString().Trim());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Должностные обязанности:  " + reader[7].ToString());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Требования к кандидату");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Пол:  " + reader[8].ToString());
                listbox1.Items.Add("Опыт рабоыт:  " + reader[9].ToString());
                listbox1.Items.Add("Образование:  " + reader[10].ToString());
                listbox1.Items.Add("Специальность:  " + reader[11].ToString());
                listbox1.Items.Add("Необходимые навыки:  " + reader[12].ToString());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Дополнительные требования");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add(reader[13].ToString());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Контактная информация");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Контактное лицо:  " + reader[14].ToString());
                listbox1.Items.Add("Номер телефона:  " + reader[15].ToString());
                listbox1.Items.Add("Адрес электронной почты:  " + reader[16].ToString());
                listbox1.Items.Add("--------------------------------------------------");





                kod = Int32.Parse(reader[17].ToString().Trim());

                /*status = reader[7].ToString().Trim();*/

                count = Int32.Parse(reader[6].ToString().Trim());

            }

            reader.Close();
            con.Close();

            panel3.Controls.Add(button16);
            panel3.Controls.Add(button17);
            panel3.Controls.Add(button18);

            

            button16.BackColor = button17.BackColor = button18.BackColor = Color.FromArgb(0, 192, 0);
            button16.FlatStyle = button17.FlatStyle = button18.FlatStyle = FlatStyle.Flat;
            button16.Font = button17.Font = button18.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button16.ForeColor = button17.ForeColor = button18.ForeColor = Color.White;
            button16.Size = button17.Size = button18.Size = new Size(140, 30);

            button16.Location = new Point(126, 464);
            button17.Location = new Point(366, 464);
            button18.Location = new Point(486, 464);

            button16.Text = "Назад";
            button17.Text = "Записаться";
            button18.Text = "Отказаться";

            cmd.CommandText = "select Результат, [Принято/Отказ]"
           + " from Собеседования"
           + " where Вакансия=" + kod + " and Кандидат=" + num;


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {
                //button8.Enabled = false;

                if ((reader1[0].ToString().Trim() == "принят на должность") || (reader1[0].ToString().Trim() == "отказано"))
                {
                    button17.Text = "Записаться";

                    button18.Enabled = button17.Enabled = false;

                }

                if (reader1[0].ToString().Trim() == "рассмотрение заявки" || reader1[0].ToString().Trim() == "повторное собеседование")
                {

                    button17.Text = "Записаться";
                    button17.Enabled = false;
                    button18.Enabled = true;
                }

                if (reader1[0].ToString().Trim() == "приглашение на собеседование")
                {
                    button17.Text = "Согласиться";


                    switch (Int32.Parse(reader1[1].ToString().Trim()))
                    {
                        case 0:

                            button17.Enabled = button18.Enabled = true;
                            break;
                        case 1:
                            button17.Enabled = false;
                            button18.Enabled = true;
                            break;
                        case 2:
                            button17.Text = "Записаться";
                            button17.Enabled = true;
                            button18.Enabled = false;
                            break;
                    }
                }

            }
            else
            {
                button17.Text = "Отправить заявку";
                button17.Enabled = true;
                button18.Enabled = false;
            }

            reader1.Close();
            con.Close();
        }

        private void Back_Work_Clicked(object sender, EventArgs e)
        {
            switch (submenu)
            {
                case 1:
                    My_Vacancies();
                    break;
                case 2:
                    All_Vacancies();
                    break;
            }
        }

        private void Find_Work_Clicked(object sender, EventArgs e)
        {
            if (textboxes0.Text.Trim() != "" || textboxes1.Text.Trim() != "" || textboxes2.Text.Trim() != "")
            {
                while (data1.Rows.Count != 0)
                    data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

                if (data1.Contains(label5))
                {
                    data1.ColumnHeadersVisible = true;
                    data1.Controls.Remove(label5);
                }
                count = 0;

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() != "")
                            {
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
           + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
           + " inner join Организации on Вакансии.Организация=Организации.Код"
           + " where Вакансии.Статус='активна' and Должности.Название='" + textboxes0.Text.Trim() + "' and Организации.Наименование='" + textboxes1.Text.Trim()
           + "' and Вакансии.[Заработная плата]>='" + textboxes2.Text.Trim() + "'";

                            }

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() == "")
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
                 + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
                 + " inner join Организации on Вакансии.Организация=Организации.Код"
                 + " where Вакансии.Статус='активна' and Должности.Название='" + textboxes0.Text.Trim() + "' and Организации.Наименование='" + textboxes1.Text.Trim()
                 +  "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && textboxes2.Text.Trim() != "")
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
             + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
             + " inner join Организации on Вакансии.Организация=Организации.Код"
             + " where Вакансии.Статус='активна' and Должности.Название='" + textboxes0.Text.Trim() 
             + " and Вакансии.[Заработная плата]>='" + textboxes2.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() != "")
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
           + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
           + " inner join Организации on Вакансии.Организация=Организации.Код"
           + " where Вакансии.Статус='активна' and Организации.Наименование='" + textboxes1.Text.Trim()
           + "' and Вакансии.[Заработная плата]>='" + textboxes2.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && textboxes2.Text.Trim() == "")
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
          + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
          + " inner join Организации on Вакансии.Организация=Организации.Код"
          + " where Вакансии.Статус='активна' and Должности.Название='" + textboxes0.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() == "")
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
          + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
          + " inner join Организации on Вакансии.Организация=Организации.Код"
          + " where Вакансии.Статус='активна' and Организации.Наименование='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() == "" && textboxes2.Text.Trim() != "")
                                cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата]"
          + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
          + " inner join Организации on Вакансии.Организация=Организации.Код"
          + " where Вакансии.Статус='активна' and Вакансии.[Заработная плата]>='" + textboxes2.Text.Trim() + "'";
                       
         
                

                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                    count++;
                }

                reader.Close();
                con.Close();

                if (count == 0)
                {
                    label5.Text = "Нет информации о вакансии";

                    data1.ColumnHeadersVisible = false;
                    data1.Controls.Add(label5);

                }
            }
        }

        private void Recording_Work(object sender, EventArgs e)
        {
             cmd.CommandText = "select Результат, [Принято/Отказ]"
           + " from Собеседования"
           + " where Вакансия=" + kod + " and Кандидат=" + num;


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {
                if (reader1[0].ToString().Trim() == "приглашение на собеседование")
                {
                    //button17.Text = "Согласиться";


                    switch (Int32.Parse(reader1[1].ToString().Trim()))
                    {
                        case 0:

                            cmd.CommandText = "update Собеседования set [Принято/Отказ]=1 where Вакансия=" + kod + " and Кандидат=" + num
                + " and Результат='приглашение на собеседование'";
                            break;

                        case 2:
                            cmd.CommandText = "update Собеседования set [Принято/Отказ]=0, Результат='рассмотрение заявки' where Вакансия=" + kod + " and Кандидат=" + num
                + " and Результат='приглашение на собеседование'";

                            break;
                    }
                }
            }
            else
            {
                Choose_Date form = new Choose_Date();
                form.ShowDialog();
                cmd.CommandText = "insert into Собеседования values('" + kod + "','" + num + "','" + date +"','рассмотрение заявки', '0')";
            }
            reader1.Close();

            cmd.ExecuteNonQuery();

            cmd.CommandText = "update Вакансии set [Количество рабочих мест]=" + (count - 1)
               + " where [Регистрационный номер]=" + kod;

            cmd.ExecuteNonQuery();


            con.Close();
            count = count - 1;

            button17.Enabled = false;
            button18.Enabled = true;

            listbox1.Items[10] = "Количество рабочих мест:  " + count.ToString();

        }

        private void Unrecording_Work(object sender, EventArgs e)
        {
             cmd.CommandText = "select Результат, [Принято/Отказ]"
           + " from Собеседования"
           + " where Вакансия=" + kod + " and Кандидат=" + num;


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {
                if (reader1[0].ToString().Trim() == "приглашение на собеседование")
                {
                   

                            cmd.CommandText = "update Собеседования set [Принято/Отказ]=2 where Вакансия=" + kod + " and Кандидат=" + num
                + " and Результат='приглашение на собеседование'";
                           
                    
                }

                if (reader1[0].ToString().Trim() == "повторное собеседование" || reader1[0].ToString().Trim() == "рассмотрение заявки")
                {
                    cmd.CommandText = "delete from Собеседования where Вакансия=" + kod + " and Кандидат=" + num
                + " and Результат='" + reader1[1].ToString().Trim() + "'";
                }
                reader1.Close();

                cmd.ExecuteNonQuery();

                cmd.CommandText = "update Вакансии set [Количество рабочих мест]=" + (count + 1)
                   + " where [Регистрационный номер]=" + kod;

                cmd.ExecuteNonQuery();


                con.Close();

                count = count + 1;
                button17.Enabled = true;
                button18.Enabled = false;

                listbox1.Items[10] = "Количество рабочих мест:  " + count.ToString();

            }
        }

        #endregion


        #region курсы переобучения

        private void Kurses()
        {
            //panel1.Controls.Clear();
            menu = 3;

            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);

            panel2.Dock = DockStyle.Left;
            panel2.BackColor = menuStrip1.BackColor;
            panel2.Size = new Size(242, 523);


            panel3.Size = new Size(panel1.Width - panel2.Width, panel2.Height);
            panel3.Location = new Point(242, 0);

            panel2.Controls.Add(ll1);
            panel2.Controls.Add(ll2);

            if (panel3.Contains(button7)) panel3.Controls.Remove(button7);
            if (panel3.Contains(button8)) panel3.Controls.Remove(button8);
            if (panel3.Contains(button9)) panel3.Controls.Remove(button9);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);



            ll1.LinkColor = ll2.LinkColor = Color.White;
            ll1.Font = ll2.Font = new Font("Modern No. 20", 22, FontStyle.Bold);

            ll1.Location = new Point(31, 152);
            ll1.Text = "Мои курсы";            
            ll1.Size = new Size(146, 31);
            ll1.LinkColor = Color.Red;

            ll2.Location = new Point(38, 293);
            ll2.Text = "Все курсы";
            ll2.Size = new Size(139, 31);

            panel3.Controls.Add(groupbox1);
            panel3.Controls.Add(data1);
            panel3.Controls.Add(button6);


            groupbox1.Location = new Point(9, 3);
            groupbox1.Size = new Size(659, 140);
            groupbox1.Text = "Поиск";

            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(label7);
            groupbox1.Controls.Add(label8);
            groupbox1.Controls.Add(textboxes0);
            groupbox1.Controls.Add(textboxes1);
            groupbox1.Controls.Add(comboboxes0);
            groupbox1.Controls.Add(button5);


            label6.Font = label7.Font = label8.Font = new Font("Modern No. 20", 11, FontStyle.Bold);

            label6.Text = "Курс";
            label6.Location = new Point(6, 48);
            label6.Size = new Size(38, 15);

            label7.Text = "Специальность";
            label7.Location = new Point(209, 48);
            label7.Size = new Size(107, 15);
            
            label8.Text = "Статус";
            label8.Location = new Point(479, 48);
            label8.Size = new Size(48, 15);
            
            textboxes0.Text = textboxes1.Text = "";
            textboxes0.ReadOnly = textboxes1.ReadOnly = false;
            textboxes0.Size = new Size(150, 25);
            textboxes1.Size = new Size(150, 25);
            textboxes0.Location = new Point(50, 48);
            textboxes1.Location = new Point(318, 48);
            //label1.Click = label1_Click1();
            textboxes0.Font = textboxes1.Font = textboxes2.Font = new Font("Modern No. 20", 12, FontStyle.Regular);


            comboboxes0.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxes0.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

                       
            comboboxes0.Size = new Size(100, 25);
            comboboxes0.Location = new Point(529, 48);

            button5.BackColor = button6.BackColor = Color.FromArgb(0, 192, 0);
            button5.FlatStyle = button6.FlatStyle = FlatStyle.Flat;
            button5.Font = button6.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button5.ForeColor = button6.ForeColor = Color.White;
            button5.Size = button6.Size = new Size(120, 30);
            button5.Location = new Point(274, 100);
            button6.Location = new Point(486, 464);
            button5.Text = "Найти";
            button6.Text = "Подробнее";

          

            data1.ColumnCount = 3;
           // data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 250;
            data1.Columns[1].Width = 250;
            data1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data1.Columns[0].Name = "Курс";
            data1.Columns[1].Name = "Специальность";
            data1.Columns[2].Name = "Статус";
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = true;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = true;
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data1.Visible = true;
            groupbox1.Visible = true;
            button6.Visible = true;
            
            data1.Size = new Size(panel3.Width - 18, 284);
            data1.Location = new Point(9, 152);

            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            My_Kurses();

        }

        private void My_Kurses()
        {
            comboboxes0.Items.Clear();

            if (panel3.Contains(button7)) panel3.Controls.Remove(button7);
            if (panel3.Contains(button8)) panel3.Controls.Remove(button8);
            if (panel3.Contains(button9)) panel3.Controls.Remove(button9);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);


            comboboxes0.Items.Add("обучается");
            comboboxes0.Items.Add("закончил");
            comboboxes0.Items.Add("отказался");
            comboboxes0.Items.Add("в ожидании");
            data1.Visible = true;
            button6.Visible = true;
            groupbox1.Visible = true;

            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }
          
            submenu = 1;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
                + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
                + " where [Обучение на курсах].Соискатель=" + num;


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                count++;
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Вы ещё не обучались на курсах";              
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button6.Visible = false;
            }
           
        }

        private void All_Kurses()
        {
            comboboxes0.Items.Clear();

            if (panel3.Contains(button7)) panel3.Controls.Remove(button7);
            if (panel3.Contains(button8)) panel3.Controls.Remove(button8);
            if (panel3.Contains(button9)) panel3.Controls.Remove(button9);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);


            string s = "обучение";
            comboboxes0.Items.Add(s);
            comboboxes0.Items.Add("закрыт");
            comboboxes0.Items.Add("набор");
            data1.Visible = true;
            groupbox1.Visible = true;
            button6.Visible = true;

            if (data1.Contains(label5))
            {
                data1.ColumnHeadersVisible = true;
                data1.Controls.Remove(label5);
            }

            submenu = 2;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Название, Специальность, Статус from [Курсы переобучения/повышения квалификации]";
                
            if (con.State == ConnectionState.Closed)
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                count++;
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Нет информации о курсах";

                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button6.Visible = false;

            }
           
        }

        private void Find_Clicked(object sender, EventArgs e)
        {

            if (textboxes0.Text.Trim() != "" || textboxes1.Text.Trim() != "" || comboboxes0.SelectedIndex >= 0)
            {
                while (data1.Rows.Count != 0)
                    data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

                if (data1.Contains(label5))
                {
                    data1.ColumnHeadersVisible = true;
                    data1.Controls.Remove(label5);
                }
                count = 0;

                switch (submenu)
                {
                    case 1:
                        {
                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex >= 0)
                            {
                                cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
                + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
                + " where [Обучение на курсах].Соискатель=" + num + " and [Курсы переобучения/повышения квалификации].Название='" + textboxes0.Text.Trim()
                + "' and [Курсы переобучения/повышения квалификации].Специальность='" + textboxes1.Text.Trim() + "' and [Обучение на курсах].Статус='" + comboboxes0.SelectedItem + "'";

                            }

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
                + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
                + " where [Обучение на курсах].Соискатель=" + num + " and [Курсы переобучения/повышения квалификации].Название='" + textboxes0.Text.Trim()
                + "' and [Курсы переобучения/повышения квалификации].Специальность='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex >= 0)
                                                                cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
                + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
                + " where [Обучение на курсах].Соискатель=" + num + " and [Курсы переобучения/повышения квалификации].Название='" + textboxes0.Text.Trim()
                + "' and [Обучение на курсах].Статус='" + comboboxes0.SelectedItem + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex >= 0)
                       cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
                  + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
                  + " where [Обучение на курсах].Соискатель=" + num + "' and [Курсы переобучения/повышения квалификации].Специальность='" + textboxes1.Text.Trim() 
                  + "' and [Обучение на курсах].Статус='" + comboboxes0.SelectedItem + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
            + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
            + " where [Обучение на курсах].Соискатель=" + num + " and [Курсы переобучения/повышения квалификации].Название='" + textboxes0.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
+ " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
+ " where [Обучение на курсах].Соискатель=" + num + "' and [Курсы переобучения/повышения квалификации].Специальность='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select [Курсы переобучения/повышения квалификации].Название, [Курсы переобучения/повышения квалификации].Специальность, [Обучение на курсах].Статус"
              + " from [Курсы переобучения/повышения квалификации] inner join [Обучение на курсах] on [Обучение на курсах].[Код курса]=[Курсы переобучения/повышения квалификации].[Код курса]"
              + " where [Обучение на курсах].Соискатель=" + num + " and [Обучение на курсах].Статус='" + comboboxes0.SelectedItem + "'";
                            break;
                        }

                    case 2:
                        {
                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex >= 0)
                            {
                                cmd.CommandText = "select Название, Специальность, Статус"
                + " from [Курсы переобучения/повышения квалификации]"
                + " where Название='" + textboxes0.Text.Trim() + "' and Специальность='" + textboxes1.Text.Trim() 
                + "' and Статус='" + comboboxes0.SelectedItem + "'";

                            }

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select Название, Специальность, Статус"
                + " from [Курсы переобучения/повышения квалификации]"
                + " where Название='" + textboxes0.Text.Trim() + "' and Специальность='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select Название, Специальность, Статус"
+ " from [Курсы переобучения/повышения квалификации]"
+ " where Название='" + textboxes0.Text.Trim() + "' and Статус='" + comboboxes0.SelectedItem + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select Название, Специальность, Статус"
                           + " from [Курсы переобучения/повышения квалификации]"
                           + " where Специальность='" + textboxes1.Text.Trim() + "' and Статус='" + comboboxes0.SelectedItem + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select Название, Специальность, Статус"
            + " from [Курсы переобучения/повышения квалификации]" + " where Название='" + textboxes0.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select Название, Специальность, Статус"
+ " from [Курсы переобучения/повышения квалификации]" + " where Специальность='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select Название, Специальность, Статус"
              + " from [Курсы переобучения/повышения квалификации]"
              + " where Статус='" + comboboxes0.SelectedItem + "'";
                            break;
                        }
                }

                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                    count++;
                }

                reader.Close();
                con.Close();

                if (count == 0)
                {
                    label5.Text = "Нет информации о курсах";

                    data1.ColumnHeadersVisible = false;
                    data1.Controls.Add(label5);
                }
           
            }
        }

        private void Info_Clicked(object sender, EventArgs e)
        {
            //string s = null;

            string[] str = new string[3];
            str[0] = data1[0, data1.CurrentRow.Index].Value.ToString();
            str[1] = data1[1, data1.CurrentRow.Index].Value.ToString();
            //str[2] = data1[2, data1.CurrentRow.Index].Value.ToString();

            groupbox1.Visible = false;

            data1.Visible = false;

            button6.Visible = false;

            panel3.Controls.Add(listbox1);
                        
            listbox1.Size = new Size(panel3.Width - 18, 284);
            listbox1.Location = new Point(9, 152);
            listbox1.Items.Clear();
            listbox1.Font = new Font("Modern No. 20", 14, FontStyle.Regular);
            
            cmd.CommandText = "select Сотрудники.ФИО, [Курсы переобучения/повышения квалификации].Название,"
                + " [Курсы переобучения/повышения квалификации].Специальность,"
                + " [Курсы переобучения/повышения квалификации].[Продолжительнсоть обучения],"
                + " [Курсы переобучения/повышения квалификации].[Количество мест],"
            + " [Курсы переобучения/повышения квалификации].[Дата начала обучения],"
            + " [Курсы переобучения/повышения квалификации].[Форма аттестации],"
            + " [Курсы переобучения/повышения квалификации].Статус,"
            + " [Курсы переобучения/повышения квалификации].[Код курса]"
            + " from [Курсы переобучения/повышения квалификации] inner join Сотрудники on [Курсы переобучения/повышения квалификации].Преподаватель=Сотрудники.[Личный номер]"
                + " where Название='" + str[0] + "' and Специальность='" + str[1]
                /*+ "' and Статус='" + str[2]*/ + "'";

             if (con.State == ConnectionState.Closed)
            con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listbox1.Items.Add("Курс:  " + reader[1].ToString());
                
                listbox1.Items.Add("Специальность:  " + reader[2].ToString());
                
                listbox1.Items.Add("Продолжительность обучения:  " + reader[3].ToString());

                listbox1.Items.Add("Количество оставшихся мест:  " + reader[4].ToString());
                
                listbox1.Items.Add("Преподаватель:  " + reader[0].ToString());
               
                listbox1.Items.Add("Дата начала занятий:  " + reader[5].ToString().Substring(0, reader[5].ToString().IndexOf(' ')));
            
                listbox1.Items.Add("Спопоб аттестации:  " + reader[6].ToString());
                
                listbox1.Items.Add("Статус:  " + reader[7].ToString());

                kod = Int32.Parse(reader[8].ToString().Trim());

                status = reader[7].ToString().Trim();

                count = Int32.Parse(reader[4].ToString().Trim());
               
            }

            reader.Close();
            con.Close();

            panel3.Controls.Add(button7);
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button9);


            button7.BackColor = button8.BackColor = button9.BackColor = Color.FromArgb(0, 192, 0);
            button7.FlatStyle = button8.FlatStyle = button9.FlatStyle = FlatStyle.Flat;
            button7.Font = button8.Font = button9.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button7.ForeColor = button8.ForeColor = button9.ForeColor = Color.White;
            button7.Size = button8.Size = button9.Size = new Size(120, 30);

            button7.Location = new Point(126, 464);
            button8.Location = new Point(366, 464);
            button9.Location = new Point(486, 464);

            button7.Text = "Назад";
            button8.Text = "Записаться";
            button9.Text = "Отказаться";

            cmd.CommandText = "select Статус"
            + " from [Обучение на курсах]"
            + " where [Код курса]=" + kod + " and Соискатель=" + num;


             if (con.State == ConnectionState.Closed)
            con.Open();

            SqlDataReader reader1 = cmd.ExecuteReader();

            if (reader1.Read())
            {
                //button8.Enabled = false;

                if ((reader1[0].ToString().Trim() == "закончил") || (reader1[0].ToString().Trim() == "отказался"))
                {
                    button9.Enabled = false;
                    
                }
                else
                    button9.Enabled = true;

                if (reader1[0].ToString().Trim() == "отказался")
                {
                    button8.Enabled = true;
                }
                else
                {
                    button8.Enabled = false;
                }

            }
            else
            {
                if (status == "набор")
                {
                    if (count > 0)
                    {
                        button8.Enabled = true;
                        button9.Enabled = false;
                    }
                    else
                    {
                        button8.Enabled = false;
                        button9.Enabled = false;
                    }

                }
                else
                   /* if (status == "обучение")
                    {
                        button8.Enabled = false;
                        button9.Enabled = true;
                    }
                    else*/
                    {
                        button8.Enabled = button9.Enabled = false;
                    }
            }

            reader1.Close();
            con.Close();


        }

        private void Back_Clicked(object sender, EventArgs e)
        {
            switch(submenu)
            {
                case 1:
                    My_Kurses();
                        break;
                case 2:
                    All_Kurses();
                        break;
            }
        }

        private void Recording_Clicked(object sender, EventArgs e)
        {
            cmd.CommandText = "insert into [Обучение на курсах] values ('" + kod + "', '" + num + "', 'в ожидании')";

            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.ExecuteNonQuery();
                                 

            cmd.CommandText = "update [Курсы переобучения/повышения квалификации] set [Количество мест]=" + (count-1)
                + " where [Код курса]=" + kod;

            cmd.ExecuteNonQuery();

            con.Close();

            button8.Enabled = false;
            button9.Enabled = true;

            count = count - 1;

            listbox1.Items[3] = "Количество оставшихся мест:  " + count.ToString();
      }

        private void Unrecording_Clicked(object sender, EventArgs e)
        {
            cmd.CommandText = "delete from [Обучение на курсах] where [Код курса]=" + kod + " and Соискатель=" + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            cmd.ExecuteNonQuery();

            cmd.CommandText = "update [Курсы переобучения/повышения квалификации] set [Количество мест]=" + (count + 1)
              + " where [Код курса]=" + kod;

            cmd.ExecuteNonQuery();

            con.Close();

            //button8.Enabled = true;
            button9.Enabled = false;

            if (status == "набор")
            {
                button8.Enabled = true;
            }

            count = count + 1;

            listbox1.Items[3] = "Количество оставшихся мест:  " + count.ToString();
        }

        #endregion

        #region собеседования

        private void Interviews()
        {
            menu = 4;

            if (panel3.Contains(button11)) panel3.Controls.Remove(button11);
            if (panel3.Contains(button12)) panel3.Controls.Remove(button12);
            if (panel3.Contains(button13)) panel3.Controls.Remove(button13);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);

            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);

            panel2.Dock = DockStyle.Left;
            panel2.BackColor = menuStrip1.BackColor;
            panel2.Size = new Size(242, 523);


            panel3.Size = new Size(panel1.Width - panel2.Width, panel2.Height);
            panel3.Location = new Point(242, 0);

            panel2.Controls.Add(ll1);
            panel2.Controls.Add(ll2);
            panel2.Controls.Add(ll3);
            panel2.Controls.Add(ll4);

            ll1.LinkColor = ll2.LinkColor = ll3.LinkColor = ll4.LinkColor = Color.White;
            ll1.Font = ll2.Font = ll3.Font = ll4.Font = new Font("Modern No. 20", 22, FontStyle.Bold);

            ll1.Location = new Point(32, 88);
            ll1.Text = "Намеченные";
            ll1.Size = new Size(175, 31);
            ll1.LinkColor = Color.Red;

            ll2.Location = new Point(32, 167);
            ll2.Text = "Приглашения";
            ll2.Size = new Size(188, 31);

            ll3.Location = new Point(42, 327);
            ll3.Text = "Прошедшие";
            ll3.Size = new Size(165, 31);

            ll4.Location = new Point(45, 247);
            ll4.Text = "Заявки";
            ll4.Size = new Size(165, 31);

            panel3.Controls.Add(data1);
            panel3.Controls.Add(button10);


            data1.ColumnCount = 3;
            // data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 150;
            data1.Columns[1].Width = 300;
            data1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           /* data1.Columns[0].Name = "Курс";
            data1.Columns[1].Name = "Специальность";
            data1.Columns[2].Name = "Статус";*/
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = true;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = true;
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data1.Visible = true;

            button10.BackColor = Color.FromArgb(0, 192, 0);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button10.ForeColor = Color.White;
            button10.Size = new Size(120, 30);
            
            button10.Location = new Point(486, 464);
            
            button10.Text = "Подробнее";

            button10.Visible = true;

            data1.Size = new Size(panel3.Width - 18, 284);
            data1.Location = new Point(9, 152);

            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            Soon();

        }

        private void Soon()
        {
            if (panel3.Contains(button11)) panel3.Controls.Remove(button11);
            if (panel3.Contains(button12)) panel3.Controls.Remove(button12);
            if (panel3.Contains(button13)) panel3.Controls.Remove(button13);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);
            
            data1.Columns[0].Name = "Дата";
            data1.Columns[1].Name = "Должность";
            data1.Columns[2].Name = "Организация";


            data1.Visible = true;
            button10.Visible = true;
            
            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

            submenu = 1;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Собеседования.Дата, Должности.Название, Организации.Наименование"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Собеседования.Кандидат=" + num + " and Собеседования.Результат in ('повторное собеседование', 'приглашение на собеседование')"
            + " and Собеседования.[Принято/Отказ]=1";


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data1.Rows.Add(reader[0].ToString().Substring(0, reader[0].ToString().IndexOf(' ')), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                count++;
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "У вас не назначено ни одного собеседования";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button10.Visible = false;
            }
        }

        private void Invitations()
        {
            if (panel3.Contains(button11)) panel3.Controls.Remove(button11);
            if (panel3.Contains(button12)) panel3.Controls.Remove(button12);
            if (panel3.Contains(button13)) panel3.Controls.Remove(button13);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);
            
            data1.Columns[0].Name = "Дата";
            data1.Columns[1].Name = "Должность";
            data1.Columns[2].Name = "Организация";


            data1.Visible = true;
            button10.Visible = true;

            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

            submenu = 2;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Собеседования.Дата, Должности.Название, Организации.Наименование"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Собеседования.Кандидат=" + num + " and Собеседования.Результат in ('приглашение на собеседование')"
            + " and Собеседования.[Принято/Отказ]=0";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data1.Rows.Add(reader[0].ToString().Substring(0, reader[0].ToString().IndexOf(' ')), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                count++;
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "У вас нет приглашений на собеседования";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button10.Visible = false;
            }
        }

        private void Past()
        {
            if (panel3.Contains(button11)) panel3.Controls.Remove(button11);
            if (panel3.Contains(button12)) panel3.Controls.Remove(button12);
            if (panel3.Contains(button13)) panel3.Controls.Remove(button13);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);
            
            data1.Columns[0].Name = "Результат";
            data1.Columns[1].Name = "Должность";
            data1.Columns[2].Name = "Организация";


            data1.Visible = true;
            button10.Visible = true;

            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

            submenu = 3;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Собеседования.Результат, Должности.Название, Организации.Наименование"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Собеседования.Кандидат=" + num + " and Собеседования.Результат in ('принят на должность', 'отказано')";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim());
                count++;
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "У вас не было собеседований";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button10.Visible = false;
            }
        }

        private void Request()
        {
            if (panel3.Contains(button11)) panel3.Controls.Remove(button11);
            if (panel3.Contains(button12)) panel3.Controls.Remove(button12);
            if (panel3.Contains(button13)) panel3.Controls.Remove(button13);
            if (panel3.Contains(listbox1)) panel3.Controls.Remove(listbox1);


            data1.Columns[0].Name = "Статус";
            data1.Columns[1].Name = "Должность";
            data1.Columns[2].Name = "Организация";


            data1.Visible = true;
            button10.Visible = true;

            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

            submenu = 4;
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Должности.Название, Организации.Наименование, Собеседования.[Принято/Отказ]"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Собеседования.Кандидат=" + num + " and Собеседования.Результат in ('рассмотрение заявки')";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch(Int32.Parse(reader[2].ToString().Trim()))
                {
                    case 0:
                        {
                         data1.Rows.Add("на рассмотрении", reader[0].ToString().Trim(), reader[1].ToString().Trim());
                         count++;
                            break;
                        }

                    case 1:
                        {
                            data1.Rows.Add("принято", reader[0].ToString().Trim(), reader[1].ToString().Trim());
                            count++;
                            break;
                        }

                    case 2:
                        {
                            data1.Rows.Add("отказано", reader[0].ToString().Trim(), reader[1].ToString().Trim());
                            count++;
                            break;
                        }

                }
                
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Вы не подавали заявки на собеседования";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button10.Visible = false;
            }
        }

        private void Info_1_Clicked(object sender, EventArgs e)
        {

            //string s = null;

            string[] str = new string[3];
            str[0] = data1[1, data1.CurrentRow.Index].Value.ToString();
            str[1] = data1[2, data1.CurrentRow.Index].Value.ToString();
            //str[2] = data1[2, data1.CurrentRow.Index].Value.ToString();

            //groupbox1.Visible = false;

            data1.Visible = false;

            button10.Visible = false;

            panel3.Controls.Add(listbox1);

            listbox1.Size = new Size(panel3.Width - 18, 384);
            listbox1.Location = new Point(9, 52);
            listbox1.Items.Clear();
            listbox1.Font = new Font("Modern No. 20", 14, FontStyle.Regular);

            cmd.CommandText = "select Должности.Название, Организации.Наименование, Вакансии.[Заработная плата],"
            + " Организации.Адрес, Вакансии.[График работы], Вакансии.[Тип занятости], Вакансии.[Количество рабочих мест],"
            + " Вакансии.[Должностные обязанности], Вакансии.[Пол кандидата], Вакансии.[Опыт работы],"
            + " Вакансии.Образование, Вакансии.Специальность, Вакансии.[Необходимые навыки],"
            + " Вакансии.[Дополнительные требования], Организации.[Контактное лицо], Организации.[Номер телефона], Организации.[Адрес электронной почты], Вакансии.[Регистрационный номер]"
            + " from (Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Организации on Вакансии.Организация=Организации.Код"
            + " where Должности.Название='" + str[0] + "' and Организации.Наименование='" + str[1]
                /*+ "' and Статус='" + str[2]*/ + "'" + " and Вакансии.Статус='активна'";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listbox1.Items.Add("Должность:  " + reader[0].ToString().Trim());

                listbox1.Items.Add("Организация:  " + reader[1].ToString().Trim());

                listbox1.Items.Add("Заработная плата:  " + reader[2].ToString());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Адрес:  " + reader[3].ToString());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Данные по вакансии");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("График работы:  " + reader[4].ToString().Trim());

                listbox1.Items.Add("Тип занятости:  " + reader[5].ToString().Trim());

                listbox1.Items.Add("Количество рабочих мест:  " + reader[6].ToString().Trim());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Должностные обязанности:  " + reader[7].ToString());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Требования к кандидату");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Пол:  " + reader[8].ToString());
                listbox1.Items.Add("Опыт рабоыт:  " + reader[9].ToString());
                listbox1.Items.Add("Образование:  " + reader[10].ToString());
                listbox1.Items.Add("Специальность:  " + reader[11].ToString());
                listbox1.Items.Add("Необходимые навыки:  " + reader[12].ToString());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Дополнительные требования");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add( reader[13].ToString());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Контактная информация" );
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Контактное лицо:  " + reader[14].ToString());
                listbox1.Items.Add("Номер телефона:  " + reader[15].ToString());
                listbox1.Items.Add("Адрес электронной почты:  " + reader[16].ToString());
                listbox1.Items.Add("--------------------------------------------------");





               kod = Int32.Parse(reader[17].ToString().Trim());

                /*status = reader[7].ToString().Trim();*/

                count = Int32.Parse(reader[6].ToString().Trim());

            }

            reader.Close();
            con.Close();

            panel3.Controls.Add(button11);

            if (submenu == 2)
            {
                panel3.Controls.Add(button12);
                panel3.Controls.Add(button13);

                button12.Enabled = button13.Enabled = true;
            }
            if (submenu == 1 || submenu == 4)
            {
                panel3.Controls.Add(button13);

                button13.Enabled = true;
            }

            button11.BackColor = button12.BackColor = button13.BackColor = Color.FromArgb(0, 192, 0);
            button11.FlatStyle = button12.FlatStyle = button13.FlatStyle = FlatStyle.Flat;
            button11.Font = button12.Font = button13.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button11.ForeColor = button12.ForeColor = button13.ForeColor = Color.White;
            button11.Size = button12.Size = button13.Size = new Size(130, 30);

            button11.Location = new Point(126, 464);
            button12.Location = new Point(366, 464);
            button13.Location = new Point(486, 464);

            button11.Text = "Назад";
            button12.Text = "Согласиться";
            button13.Text = "Отказаться";
        }
        
        private void Back_1_Clicked(object sender, EventArgs e)
        {
            switch (submenu)
            {
                case 1:
                    Soon();
                    break;
                case 2:
                    Invitations();
                    break;
                case 3:
                    Past();
                    break;
                case 4:
                    Request();
                    break;
            }
        }

        private void Yes_Clicked(object sender, EventArgs e)
        {
            cmd.CommandText = "update Собеседования set [Принято/Отказ]=1 where Вакансия=" + kod + " and Кандидат=" + num
                + " and Результат='приглашение на собеседование'";


            if (con.State == ConnectionState.Closed)
                con.Open();


            cmd.ExecuteNonQuery();

            cmd.CommandText = "update Вакансии set [Количество рабочих мест]=" + (count - 1)
                + " where [Регистрационный номер]=" + kod ;

            cmd.ExecuteNonQuery();

            con.Close();

            count = count - 1;

            listbox1.Items[10] = "Количество рабочих мест:  " + count.ToString();

            button12.Enabled = false;
        }

        private void No_Clicked(object sender, EventArgs e)
        {
            cmd.CommandText = "update Собеседования set [Принято/Отказ]=2 where Вакансия=" + kod + " and Кандидат=" + num
                + " and Результат='приглашение на собеседование'";

            if (con.State == ConnectionState.Closed)
                con.Open();


            cmd.ExecuteNonQuery();

            cmd.CommandText = "update Вакансии set [Количество рабочих мест]=" + (count + 1)
               + " where [Регистрационный номер]=" + kod;

            cmd.ExecuteNonQuery();

            con.Close();

            count = count + 1;

            listbox1.Items[10] = "Количество рабочих мест:  " + count.ToString();

            button12.Enabled = false;
            button13.Enabled = false;

        }

        #endregion

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }





    }
}
