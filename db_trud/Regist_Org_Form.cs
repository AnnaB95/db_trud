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
    public partial class Regist_Org_Form : Form
    {
        #region переменные
        public static DateTime date = new DateTime();
        public static int vac = 0;
        public static bool ok = false;

        int kod1 = 0;
        int kod = 0;
        int num;
        string name;
        int count = 0;
        int submenu = 1;
        int menu = 0;
        Panel panel3 = new Panel(), panel4 = new Panel();

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
        TextBox textboxes18 = new TextBox();
        TextBox textboxes19 = new TextBox();
        TextBox textboxes20 = new TextBox();
        TextBox textboxes21 = new TextBox();
        TextBox textboxes22 = new TextBox();

        ListBox listbox1 = new ListBox();
        LinkLabel ll1 = new LinkLabel(), ll2 = new LinkLabel(), ll3 = new LinkLabel(), ll4 = new LinkLabel();
        DataGridView data1 = new DataGridView();

        Button button1 = new Button(), button2 = new Button(), button10 = new Button(), button11 = new Button(), button12 = new Button(), button13 = new Button();
        Button button14 = new Button(), button15 = new Button(), button16 = new Button(), button17 = new Button();
        Button button18 = new Button(), button19 = new Button(), button20 = new Button();
        Button button21 = new Button(), button22 = new Button(), button23 = new Button();

        Label label5 = new Label(), label6 = new Label(), label7 = new Label(), label8 = new Label();
        GroupBox groupbox1 = new GroupBox();
        ComboBox comboboxes0 = new ComboBox();

        string[] info = new string[17];
        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        SqlCommand cmd = new SqlCommand();  

        #endregion

        public Regist_Org_Form()
        {
            InitializeComponent();
        }

        public Regist_Org_Form(int num, string name)
        {
            InitializeComponent();

            this.num = num;
            this.name = name;

            this.Text = "Вы зашли от имени: " + name;
        }

        private void Regist_Org_Form_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            button2.Click += But_Cancel_Click;
            button1.Click += But_Change_Click;
            ll1.Click += ll1_Clicked;
            ll2.Click += ll2_Clicked;
            ll3.Click += ll3_Clicked;
            ll4.Click += ll4_Clicked;
            button10.Click += Info_1_Clicked;
            button11.Click += Back_1_Clicked;
            button12.Click += Yes_Clicked;
            button13.Click += No_Clicked;
            button15.Click += Find_Clicked;
            button14.Click += Add_Clicked;
            button16.Click += Change_Clicked;
            button17.Click += Delete_Clicked;
            button18.Click += Info_Empl_Clicked;
            button19.Click += Find_Empl_Clicked;
            button20.Click += Find_for_Vac_Clicked;
            button21.Click += Back_Empl_Clicked;
            button22.Click += Recording_Empl;
        }

        #region основное меню
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

            Find_Empl();

        }

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

            About_org();

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

            Vacancies();

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

        #region стартовое меню

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;

        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            label2.ForeColor = Color.Red;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
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

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            label3.ForeColor = Color.Red;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
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
        private void Delete_menu(Panel panel)
        {

            panel.Controls.Clear();

            this.Size = new Size(928, 590);
            this.CenterToScreen();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            редактироватьРезюмеToolStripMenuItem.ForeColor = Color.Red;
            About_org();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            редактироватьРезюмеToolStripMenuItem.ForeColor = Color.Red;
            About_org();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Delete_menu(panel1);
            Delete_menu(panel2);

            Black_Menu();
            найтиРаботуToolStripMenuItem.ForeColor = Color.Red;

            Vacancies();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Delete_menu(panel1);
            Delete_menu(panel2);

            Black_Menu();
            найтиРаботуToolStripMenuItem.ForeColor = Color.Red;

            Vacancies();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            курсыПереобученияповышенияКвалификацииToolStripMenuItem.ForeColor = Color.Red;

            Find_Empl();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Delete_menu(panel2);
            Delete_menu(panel1);

            Black_Menu();
            курсыПереобученияповышенияКвалификацииToolStripMenuItem.ForeColor = Color.Red;

            Find_Empl();

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


        #region редактировать информацию об организации

        private void About_org()
        {
            panel1.Controls.Add(panel2);

            panel2.BackColor = menuStrip1.BackColor;

            panel2.Size = new Size(778, 435);
            panel2.Location = new Point(70, 70);
            panel2.Dock = DockStyle.None;

            panel2.Controls.Add(textboxes0);
            panel2.Controls.Add(textboxes1);
            panel2.Controls.Add(textboxes2);
            panel2.Controls.Add(textboxes3);
            panel2.Controls.Add(textboxes4);
            panel2.Controls.Add(textboxes5);
            panel2.Controls.Add(textboxes6);
            panel2.Controls.Add(textboxes7);
            panel2.Controls.Add(textboxes8);
            panel2.Controls.Add(textboxes9);
            panel2.Controls.Add(textboxes10);
            panel2.Controls.Add(textboxes11);
            panel2.Controls.Add(textboxes12);
            panel2.Controls.Add(textboxes13);
            panel2.Controls.Add(textboxes14);
            panel2.Controls.Add(textboxes15);
            panel2.Controls.Add(textboxes16);
            panel2.Controls.Add(textboxes17);
            panel2.Controls.Add(textboxes18);
            panel2.Controls.Add(textboxes19);
            panel2.Controls.Add(textboxes20);
            panel2.Controls.Add(textboxes21);
            panel2.Controls.Add(textboxes22);


            textboxes1.Font = textboxes3.Font =  textboxes6.Font = textboxes8.Font = textboxes10.Font =
            textboxes12.Font = textboxes14.Font =  textboxes17.Font = textboxes19.Font = textboxes21.Font = new Font("Modern No. 20", 14, FontStyle.Bold);

            textboxes0.Font = textboxes5.Font = textboxes16.Font = new Font("Modern No. 20", 18, FontStyle.Bold);

            textboxes2.Font = textboxes4.Font = textboxes7.Font = textboxes9.Font = textboxes11.Font = textboxes13.Font =
            textboxes15.Font = textboxes18.Font = textboxes20.Font = textboxes22.Font = new Font("Modern No. 20", 14, FontStyle.Regular);

            textboxes0.ReadOnly = textboxes1.ReadOnly = textboxes3.ReadOnly = textboxes5.ReadOnly = textboxes6.ReadOnly = textboxes8.ReadOnly =
            textboxes10.ReadOnly = textboxes12.ReadOnly = textboxes14.ReadOnly = textboxes16.ReadOnly = textboxes17.ReadOnly = textboxes19.ReadOnly =
            textboxes21.ReadOnly = true;

            textboxes2.ReadOnly = textboxes4.ReadOnly = textboxes7.ReadOnly = textboxes9.ReadOnly = textboxes11.ReadOnly = textboxes13.ReadOnly =
            textboxes15.ReadOnly = textboxes18.ReadOnly = textboxes20.ReadOnly = textboxes22.ReadOnly = false;


            textboxes1.Size = textboxes3.Size = textboxes6.Size = textboxes8.Size = textboxes17.Size = textboxes19.Size = textboxes21.Size =
            textboxes2.Size = textboxes4.Size = textboxes7.Size = textboxes9.Size = textboxes18.Size = textboxes20.Size = textboxes22.Size  = new Size(289, 28);
            textboxes0.Size = textboxes5.Size = textboxes16.Size = new Size(578, 33);
            textboxes10.Size = new Size(70, 28);
            textboxes12.Size = new Size(109, 28);
            textboxes14.Size = new Size(120, 28);
            textboxes11.Size = textboxes13.Size = textboxes15.Size = new Size(93, 28);

            textboxes0.TextAlign = textboxes1.TextAlign = textboxes5.TextAlign = textboxes16.TextAlign =
                textboxes3.TextAlign = textboxes6.TextAlign = textboxes8.TextAlign = textboxes10.TextAlign =
                textboxes12.TextAlign = textboxes14.TextAlign = textboxes17.TextAlign = textboxes19.TextAlign =
                textboxes21.TextAlign =HorizontalAlignment.Center;

            textboxes2.TextAlign = textboxes4.TextAlign = textboxes7.TextAlign = textboxes9.TextAlign =
                textboxes11.TextAlign = textboxes13.TextAlign = textboxes15.TextAlign = textboxes18.TextAlign =
                textboxes20.TextAlign = textboxes22.TextAlign = HorizontalAlignment.Left;

            textboxes0.Location = new Point(100, 25);
            textboxes1.Location = new Point(100, 58);
            textboxes2.Location = new Point(389, 58);
            textboxes3.Location = new Point(100, 85);
            textboxes4.Location = new Point(389, 85);
            textboxes5.Location = new Point(100, 112);
            textboxes6.Location = new Point(100, 145);
            textboxes7.Location = new Point(389, 145);
            textboxes8.Location = new Point(100, 172);
            textboxes9.Location = new Point(389, 172);
            textboxes10.Location = new Point(100, 197);
            textboxes11.Location = new Point(170, 197);
            textboxes12.Location = new Point(263, 197);
            textboxes13.Location = new Point(372, 197);
            textboxes14.Location = new Point(465, 197);
            textboxes15.Location = new Point(585, 197);
            textboxes16.Location = new Point(100, 224);
            textboxes17.Location = new Point(100, 257);
            textboxes18.Location = new Point(389, 257);
            textboxes19.Location = new Point(100, 284);
            textboxes20.Location = new Point(389, 284);
            textboxes21.Location = new Point(100, 311);
            textboxes22.Location = new Point(389, 311);

            textboxes0.Text = "Информация об организации";
            textboxes1.Text = "Название организации";
            textboxes3.Text = "Сфера деятельности";
            textboxes5.Text = "Адрес";
            textboxes6.Text = "Город";
            textboxes8.Text = "Улица";
            textboxes10.Text = "Дом";
            textboxes12.Text = "Корпус";
            textboxes14.Text = "Офис";
            textboxes16.Text = "Контактная информация";
            textboxes17.Text = "КОнтактное лицо";
            textboxes19.Text = "Номер телефона";
            textboxes21.Text = "E-mail";

            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);

            button1.BackColor = button2.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = button2.FlatStyle = FlatStyle.Flat;
            button1.Font = button2.Font = new Font("Modern No. 20", 16, FontStyle.Bold);
            button1.ForeColor = button2.ForeColor = Color.White;
            button1.Size = button2.Size = new Size(167, 36);

            button1.Location = new Point(215, 364);
            button1.Text = "Редактировать";

            button2.Location = new Point(415, 364);
            button2.Text = "Отменить";


            cmd = con.CreateCommand();
            cmd.CommandText = "select * from Организации where Код = " + num;

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

            From_info_rez(info);
        }


        private void From_info_rez(string[] info) //заполнение данными из таблицы подменю обо мне и предпочтения
        {
           
                        textboxes2.Text = info[1].Trim();
                        textboxes4.Text = info[2].Trim();
                        textboxes18.Text = info[4].Trim();
                        textboxes20.Text = info[5];
                        textboxes22.Text = info[6];

                        

                        int flag = 0;

                       

                        flag = info[3].IndexOf('.', flag) + 1;
                        textboxes7.Text = info[3].Substring(flag, info[3].IndexOf(',', flag) - flag);
                        flag = info[3].IndexOf(',', flag) + 1;
                        flag = info[3].IndexOf('.', flag) + 1;
                        textboxes9.Text = info[3].Substring(flag, info[3].IndexOf(',', flag) - flag);
                        flag = info[3].IndexOf(',', flag) + 1;

                        if (info[3].IndexOf('/') != -1)
                        {
                            flag = info[3].IndexOf('.', flag) + 1;
                            textboxes11.Text = info[3].Substring(flag, info[3].IndexOf('/') - flag);
                            flag = info[3].IndexOf('/') + 1;
                            textboxes13.Text = info[3].Substring(flag, info[3].IndexOf(',', flag) - flag);
                            flag = info[3].IndexOf(',', flag) + 1;
                        }
                        else
                        {
                            flag = info[3].IndexOf('.', flag) + 1;

                            textboxes11.Text = info[3].Substring(flag, info[3].IndexOf(',', flag) - flag);
                            flag = info[3].IndexOf(',', flag) + 1;
                        }

                        flag = info[3].IndexOf('.', flag) + 1;

                        textboxes15.Text = info[3].Substring(flag, info[3].Length - flag);
                    
            }

        private void But_Cancel_Click(object sender, EventArgs e) //событие отмены
        {

            From_info_rez(info);
        }

        private void But_Change_Click(object sender, EventArgs e) //событие редактирования
        {

            if (textboxes2.Text.Trim() == "" || textboxes20.Text.Trim() == "") { But_Cancel_Click(sender, e); return; }
                        //button1.BackColor = Color.Wheat;
                        info[1] = textboxes2.Text.Trim();
                        info[2] = textboxes4.Text.Trim();
                        info[4] = textboxes18.Text.Trim();
                        info[5] = textboxes20.Text.Trim();
                        info[6] = textboxes22.Text.Trim();

                       


                        if (textboxes13.Text.Trim() != "")
                        {
                            info[3] = "г." + textboxes7.Text.Trim() + ", ул." + textboxes9.Text.Trim() + ", д." + textboxes11.Text.Trim() + "/" + textboxes13.Text.Trim() + ", кв." + textboxes15.Text.Trim();
                        }
                        else
                        {
                            info[3] = "г." + textboxes7.Text.Trim() + ", ул." + textboxes9.Text.Trim() + ", д." + textboxes11.Text.Trim() + ", кв." + textboxes15.Text.Trim();
                        }

                        


                        cmd = con.CreateCommand();
                        cmd.CommandText = "update Организации Set Наименование='" + info[1] + "', [Род деятельности]='" + info[2] + "', Адрес='" + info[3] + "', [Контактное лицо]='" + info[4] + "', [Номер телефона]='" + info[5] + "', [Адрес электронной почты]='" + info[6] + "' where Код=" + num;

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        

                    }

        #endregion

        #region вакансии

        private void Vacancies()
        {
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            groupbox1.Controls.Clear();

            panel2.Dock = DockStyle.Left;
            panel2.BackColor = menuStrip1.BackColor;
            panel2.Size = new Size(324, 533);


            panel3.Size = new Size(panel1.Width - panel2.Width, panel2.Height);
            panel3.Location = new Point(324, 0);

            panel2.Controls.Add(groupbox1);

            panel3.Controls.Add(data1);
            panel3.Controls.Add(button14);
            panel3.Controls.Add(button16);
            panel3.Controls.Add(button17);


            groupbox1.Location = new Point(20, 60);
            groupbox1.Size = new Size(290, 310);
            groupbox1.Text = "Поиск";

            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(label7);
            groupbox1.Controls.Add(label8);
            groupbox1.Controls.Add(textboxes0);
            groupbox1.Controls.Add(textboxes1);
            groupbox1.Controls.Add(comboboxes0);
            groupbox1.Controls.Add(button15);


            label6.Font = label7.Font = label8.Font = new Font("Modern No. 20", 12, FontStyle.Bold);

            label6.Text = "Должность";
            label6.Location = new Point(4, 39);
            label6.Size = new Size(90, 18);

            label7.Text = "Зар. плата от";
            label7.Location = new Point(4, 107);
            label7.Size = new Size(114, 18);

            label8.Text = "Статус";
            label8.Location = new Point(4, 177);
            label8.Size = new Size(59, 18);

            textboxes0.Text = textboxes1.Text = "";
            textboxes0.ReadOnly = textboxes1.ReadOnly = false;
            textboxes1.Size = textboxes0.Size = new Size(155, 25);
            textboxes0.Location = new Point(125, 36);
            textboxes1.Location = new Point(125, 104);
            //label1.Click = label1_Click1();
            
            textboxes0.Font = textboxes1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            comboboxes0.DropDownStyle = ComboBoxStyle.DropDownList;
            comboboxes0.Font = new Font("Modern No. 20", 12, FontStyle.Regular);

            comboboxes0.Items.Clear();

            comboboxes0.Items.Add("активна");
            comboboxes0.Items.Add("закрыта");
            comboboxes0.Size = new Size(155, 26);
            comboboxes0.Location = new Point(125, 170);
            data1.ColumnCount = 5;
            // data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 200;
            data1.Columns[1].Width = 100;
            data1.Columns[2].Width = 130;
            data1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data1.Columns[4].Width = 0;
            data1.Columns[0].Name = "Должность";
            data1.Columns[1].Name = "Зар. плата";
            data1.Columns[2].Name = "Кол-во раб.мест";
            data1.Columns[3].Name = "Статус";
            data1.Columns[4].Name = "Код";
            data1.Columns[4].Visible = false;
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = true;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = true;
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data1.Size = new Size(527, 308);
            data1.Location = new Point(37, 73);

            button14.BackColor = button15.BackColor = button16.BackColor = button17.BackColor = Color.FromArgb(0, 192, 0);
            button14.FlatStyle = button15.FlatStyle = button16.FlatStyle = button17.FlatStyle = FlatStyle.Flat;
            button14.Font = button15.Font = button16.Font = button17.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button14.ForeColor = button15.ForeColor = button16.ForeColor = button17.ForeColor = Color.White;
            button14.Size = button16.Size = button17.Size = new Size(167, 30);
            button15.Size = new Size(120, 30);
            button15.Location = new Point(83, 245);
            button14.Location = new Point(30, 420);
            button16.Location = new Point(240, 420);
            button17.Location = new Point(400, 420);

            button15.Text = "Найти";
            button14.Text = "Добавить";
            button16.Text = "Редактировать";
            button17.Text = "Удалить";


            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            My_Vacancies();
        }

        private void My_Vacancies()
        {
            if (data1.Contains(label5))
            {
                data1.Controls.Remove(label5);
                data1.ColumnHeadersVisible = true;

            }

           
            count = 0;

            while (data1.Rows.Count != 0)
                data1.Rows.Remove(data1.Rows[data1.Rows.Count - 1]);

            cmd = con.CreateCommand();
            cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
            + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
            + " where Вакансии.Организация=" + num;


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
                label5.Text = "У Вас пока нет ни одной вакансии";
                data1.ColumnHeadersVisible = false;
                data1.Controls.Add(label5);
                button14.Visible = false;
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

               
                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex >= 0)
                            {
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
            + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
            + " where Вакансии.Организация=" + num + " and Должности.Название='" + textboxes0.Text.Trim()
                + "' and Вакансии.[Заработная плата]>='" + textboxes1.Text.Trim() + "' and Вакансии.Статус='" + comboboxes0.SelectedItem + "'";

                            }

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
             + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
             + " where Вакансии.Организация=" + num + " and Должности.Название='" + textboxes0.Text.Trim()
                 + "' and Вакансии.[Заработная плата]>='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
+ " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
+ " where Вакансии.Организация=" + num + " and Должности.Название='" + textboxes0.Text.Trim()
+ "' and Вакансии.Статус='" + comboboxes0.SelectedItem + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
                                 + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
                                 + " where Вакансии.Организация=" + num 
                                     + " and Вакансии.[Заработная плата]>='" + textboxes1.Text.Trim() + "' and Вакансии.Статус='" + comboboxes0.SelectedItem + "'";

                            if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
                                       + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
                                       + " where Вакансии.Организация=" + num + " and Должности.Название='" + textboxes0.Text.Trim()
                                          + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && comboboxes0.SelectedIndex < 0)
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
                                            + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
                                            + " where Вакансии.Организация=" + num + " and Вакансии.[Заработная плата]>='" + textboxes1.Text.Trim() + "'";

                            if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() == "" && comboboxes0.SelectedIndex >= 0)
                                cmd.CommandText = "select Должности.Название, Вакансии.[Заработная плата], Вакансии.[Количество рабочих мест], Вакансии.Статус, Вакансии.[Регистрационный номер]"
                                      + " from Вакансии inner join Должности on Вакансии.Должность=Должности.Код"
                                      + " where Вакансии.Организация=" + num + " and Вакансии.Статус='" + comboboxes0.SelectedItem + "'";

                            if (con.State == ConnectionState.Closed)
                                con.Open();

                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim(), reader[3].ToString().Trim(), reader[4].ToString().Trim());
                                count++;
                            }

                            reader.Close();
                            con.Close();

                            if (count == 0)
                            {
                                label5.Text = "Нет информации о вакансиях";

                                data1.ColumnHeadersVisible = false;
                                data1.Controls.Add(label5);
                            }
            
            }
                }

        private void Add_Clicked(object sender, EventArgs e)
        {
           

            Vacanci_Form form = new Vacanci_Form(num);
            form.ShowDialog();

            My_Vacancies();
        }

        private void Change_Clicked(object sender, EventArgs e)
        {
           

            Vacanci_Form form = new Vacanci_Form(num, Int32.Parse(data1[4, data1.CurrentRow.Index].Value.ToString()));
            form.ShowDialog();

            My_Vacancies();
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            DialogResult rsl = MessageBox.Show("Вы уверены, что хотите удалить данную вакансию?", "Внимание!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question); //диалоговок окно с предложением сохранить данные из таблицы
            if (rsl == DialogResult.Yes) //если да, то сохраняем данные и закрываем приложение
            {
                cmd.CommandText = "delete from Вакансии where [Регистрационный номер]=" + Int32.Parse(data1[4, data1.CurrentRow.Index].Value.ToString());

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

            My_Vacancies();
        }

        #endregion 

        #region найти сотрудника

        private void Find_Empl()
        {
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);

            groupbox1.Controls.Clear();

            panel2.Dock = DockStyle.Left;
            panel2.BackColor = menuStrip1.BackColor;
            panel2.Size = new Size(324, 533);


            panel3.Size = new Size(panel1.Width - panel2.Width, panel2.Height);
            panel3.Location = new Point(324, 0);

            panel2.Controls.Add(groupbox1);

            panel3.Controls.Add(data1);
            panel3.Controls.Add(button18);
           


            groupbox1.Location = new Point(20, 60);
            groupbox1.Size = new Size(290, 330);
            groupbox1.Text = "Поиск";

            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(label7);
            groupbox1.Controls.Add(label8);
            groupbox1.Controls.Add(textboxes0);
            groupbox1.Controls.Add(textboxes1);
            groupbox1.Controls.Add(textboxes2);
            groupbox1.Controls.Add(button19);
            groupbox1.Controls.Add(button20);


            label6.Font = label7.Font = label8.Font = new Font("Modern No. 20", 12, FontStyle.Bold);

            label6.Text = "Стаж";
            label6.Location = new Point(4, 39);
            label6.Size = new Size(90, 18);

            label7.Text = "Должность";
            label7.Location = new Point(4, 107);
            label7.Size = new Size(114, 18);

            label8.Text = "Зар. плата от";
            label8.Location = new Point(4, 177);
            label8.Size = new Size(121, 18);

            textboxes0.Text = textboxes1.Text = textboxes2.Text = "";
            textboxes0.ReadOnly = textboxes1.ReadOnly = textboxes2.ReadOnly = false;
            textboxes1.Size = textboxes0.Size = textboxes2.Size = new Size(155, 25);
            textboxes0.Location = new Point(125, 36);
            textboxes1.Location = new Point(125, 104);
            //label1.Click = label1_Click1();

            textboxes0.Font = textboxes1.Font = textboxes2.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            
            textboxes2.Location = new Point(125, 170);
            data1.ColumnCount = 5;
            // data1.Size = new Size(486, 284);
            data1.Columns[0].Width = 250;
            data1.Columns[1].Width = 50;
            data1.Columns[2].Width = 130;
            data1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data1.Columns[4].Width = 0;
            data1.Columns[0].Name = "ФИО";
            data1.Columns[1].Name = "Стаж";
            data1.Columns[2].Name = "Должность";
            data1.Columns[3].Name = "Зар. плата";
            data1.Columns[4].Name = "Код";
            data1.Columns[4].Visible = false;
            data1.RowHeadersVisible = false;
            data1.ColumnHeadersVisible = true;
            data1.AllowUserToAddRows = false;
            data1.AllowUserToDeleteRows = false;
            data1.AllowUserToResizeColumns = false;
            data1.AllowUserToResizeRows = false;
            data1.ReadOnly = true;
            data1.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data1.Size = new Size(527, 308);
            data1.Location = new Point(37, 73);

            button18.BackColor = button19.BackColor = button20.BackColor = Color.FromArgb(0, 192, 0);
            button18.FlatStyle = button19.FlatStyle = button20.FlatStyle = FlatStyle.Flat;
            button18.Font = button19.Font = button20.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button18.ForeColor = button19.ForeColor = button20.ForeColor = Color.White;
            button18.Size = new Size(167, 30);
            button19.Size = new Size(120, 30);
            button20.Size = new Size(280, 30);
            button19.Location = new Point(83, 245);
            button18.Location = new Point(400, 420);
            button20.Location = new Point(5, 290);

            button19.Text = "Найти";
            button18.Text = "Подробнее";
            button20.Text = "Найти кандидата для вакансии";
          
            label5.Dock = DockStyle.Fill;
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            Show_Empl();

        }

        private void Show_Empl()
        {
            data1.Visible = true;

            button18.Visible = true;
            button19.Enabled = button20.Enabled = true;

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
                button18.Visible = false;
            }
        
        }

        private void Find_Empl_Clicked(object sender, EventArgs e)
        {
            data1.Visible = true;

            button18.Visible = true;
            button19.Enabled = button20.Enabled = true;

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
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
           + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
+ " where Резюме.Стаж>='" + textboxes0.Text.Trim() + "' and Должности.Название='" + textboxes1.Text.Trim() 
+ "' and Резюме.[Уровень заработной платы]<='" + textboxes2.Text.Trim() + "'";

                }

                if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() == "")
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
              + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
   + " where Резюме.Стаж>='" + textboxes0.Text.Trim() + "' and Должности.Название='" + textboxes1.Text.Trim() + "'";

                if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && textboxes2.Text.Trim() != "")
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
            + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
 + " where Резюме.Стаж>='" + textboxes0.Text.Trim() + "' and Резюме.[Уровень заработной платы]<='" + textboxes2.Text.Trim() + "'";

                if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() != "")
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
             + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
  + " where Должности.Название='" + textboxes1.Text.Trim() + "' and Резюме.[Уровень заработной платы]<='" + textboxes2.Text.Trim() + "'";

                if (textboxes0.Text.Trim() != "" && textboxes1.Text.Trim() == "" && textboxes2.Text.Trim() == "")
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
           + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
+ " where Резюме.Стаж>='" + textboxes0.Text.Trim() + "'";

                if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() != "" && textboxes2.Text.Trim() == "")
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
                   + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
        + " where  Должности.Название='" + textboxes1.Text.Trim() + "'";

                if (textboxes0.Text.Trim() == "" && textboxes1.Text.Trim() == "" && textboxes2.Text.Trim() != "")
                    cmd.CommandText = "select Резюме.ФИО, Резюме.Стаж, Должности.Название, Резюме.[Уровень заработной платы], Резюме.[Личный номер]"
            + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
 + " where Резюме.[Уровень заработной платы]<='" + textboxes2.Text.Trim() + "'";




                if (con.State == ConnectionState.Closed)
                    con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    data1.Rows.Add(reader[0].ToString().Trim(), reader[1].ToString().Trim(), reader[2].ToString().Trim(), reader[3].ToString().Trim(), reader[4].ToString().Trim());
                    count++;
                }

                reader.Close();
                con.Close();

                if (count == 0)
                {
                    label5.Text = "Нет информации о кандидатах";

                    data1.ColumnHeadersVisible = false;
                    data1.Controls.Add(label5);

                }
            }
        }

        private void Find_for_Vac_Clicked(object sender, EventArgs e)
        {
            data1.Visible = true;

            button18.Visible = true;
            button19.Enabled = button20.Enabled = true;

            submenu = 1;

            List_Vacancies form = new List_Vacancies(submenu, num);
            form.ShowDialog();

            if (ok)
            {
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
                + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
                + " where Резюме.[Интересующая должность]=(select Должность from Вакансии where [Регистрационный номер]=" + vac + ")"
                + " and Резюме.[Уровень заработной платы]<=(select [Заработная плата] from Вакансии where [Регистрационный номер]=" + vac
                + ") and Резюме.[График работы]=(select [График работы] from Вакансии where [Регистрационный номер]=" + vac
                + ") and Резюме.[Тип занятости]=(select [Тип занятости] from Вакансии where [Регистрационный номер]=" + vac
                + ")";


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
                    button18.Visible = false;
                }
            }
        

        }

        private void Info_Empl_Clicked(object sender, EventArgs e)
        {

            //string s = null;

           /* string[] str = new string[3];
            str[0] = data1[1, data1.CurrentRow.Index].Value.ToString();
            str[1] = data1[2, data1.CurrentRow.Index].Value.ToString();
            //str[2] = data1[2, data1.CurrentRow.Index].Value.ToString();*/

            //groupbox1.Visible = false;

            data1.Visible = false;

            button18.Visible = false;

            button19.Enabled = button20.Enabled = false;

            panel3.Controls.Add(listbox1);

            listbox1.Size = new Size(panel3.Width - 18, 384);
            listbox1.Location = new Point(9, 52);
            listbox1.Items.Clear();
            listbox1.Font = new Font("Modern No. 20", 14, FontStyle.Regular);

            cmd.CommandText = "select Резюме.[Личный номер], Резюме.ФИО, Резюме.Пол, Резюме.[Дата рождения],"
                + " Резюме.Адрес, Резюме.Стаж, Резюме.[Номер телефона], Резюме.[Адрес электронной почты],"
                + " Резюме.[Личные качества], Резюме.[Интересующая должность], Резюме.[Уровень заработной платы],"
                + " Резюме.[График работы], Резюме.[Тип занятости], Резюме.[Дополнительная информация]"
                + " from Резюме inner join Должности on Резюме.[Интересующая должность]=Должности.Код"
            + " where Резюме.[Личный номер]=" + Int32.Parse(data1[4, data1.CurrentRow.Index].Value.ToString());

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listbox1.Items.Add("ФИО:  " + reader[1].ToString().Trim());

                listbox1.Items.Add("Пол:  " + reader[2].ToString().Trim());

                listbox1.Items.Add("Дата рождения:  " + reader[3].ToString().Substring(0, reader[3].ToString().IndexOf(' ')));

                listbox1.Items.Add("Личные качества:  " + reader[8].ToString().Trim());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Дополнительная информация:  " + reader[13].ToString().Trim());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Адрес:  " + reader[4].ToString());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Предпочтения");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Интересующая должность:  " + reader[9].ToString().Trim());

                listbox1.Items.Add("Уровень заработной платы:  " + reader[10].ToString().Trim());

                listbox1.Items.Add("График работы:  " + reader[11].ToString().Trim());
                listbox1.Items.Add("Тип занятости:  " + reader[11].ToString().Trim());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Контактная информация");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Номер телефона:  " + reader[6].ToString());
                listbox1.Items.Add("Адрес электронной почты:  " + reader[7].ToString());
                listbox1.Items.Add("--------------------------------------------------");
                listbox1.Items.Add("--------------------------------------------------");
                listbox1.Items.Add("История трудовой деятельности (стаж: " + reader[5].ToString() + ")");
                listbox1.Items.Add("--------------------------------------------------");





                kod = Int32.Parse(reader[0].ToString().Trim());

                /*status = reader[7].ToString().Trim();*/
               // kod1 = Int32.Parse(reader[14].ToString().Trim());

               // count = Int32.Parse(reader[15].ToString().Trim());

            }

            reader.Close();
            con.Close();

            cmd.CommandText = "select Должности.Название, [Трудовая история].Организация,  [Трудовая история].[Основные обязанности]"
                + ", [Трудовая история].[Дата начала работы], [Трудовая история].[Дата прекращения работы], [Трудовая история].Характеристика"
                + " from [Трудовая история] inner join Должности on [Трудовая история].Должность = Должности.Код"
                + " where [Трудовая история].Соискатель=" + kod;


            if (con.State == ConnectionState.Closed)
                con.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listbox1.Items.Add("Должность:  " + reader[0].ToString().Trim());

                listbox1.Items.Add("Организация:  " + reader[1].ToString().Trim());

                listbox1.Items.Add("Основные обязанности:  " + reader[2].ToString().Trim());

                listbox1.Items.Add("Характеристика:  " + reader[5].ToString().Trim());

                listbox1.Items.Add("Сроки работы:  " + reader[3].ToString().Substring(0, reader[3].ToString().IndexOf(' ')) + " - " + reader[4].ToString().Substring(0, reader[4].ToString().IndexOf(' ')));

                listbox1.Items.Add("--------------------------------------------------");

            }

            reader.Close();
            con.Close();

            cmd.CommandText = "select [Образовательные учреждения].Наименование, [Сведения об образовании].Уровень,  [Сведения об образовании].[Год окончания]"
               + ", [Сведения об образовании].Специальность, [Сведения об образовании].[Квалификация по диплому], [Сведения об образовании].[Название курса/Факультет]"
               + " from [Сведения об образовании] inner join [Образовательные учреждения] on [Сведения об образовании].[Наименование учебного заведения] = [Образовательные учреждения].Код"
               + " where [Сведения об образовании].Соискатель=" + kod;
            if (con.State == ConnectionState.Closed)
                con.Open();

            reader = cmd.ExecuteReader();


            listbox1.Items.Add("--------------------------------------------------");
            listbox1.Items.Add("Образование: ");
            listbox1.Items.Add("--------------------------------------------------");


            while (reader.Read())
            {
                if (reader[1].ToString().Trim() == "высшее" || reader[1].ToString().Trim() == "незаконченное высшее" || reader[1].ToString().Trim() == "среднее профессиональное")
                {
                    listbox1.Items.Add("Уровень:  " + reader[1].ToString().Trim());

                    listbox1.Items.Add("Образовательное учреждение:  " + reader[0].ToString().Trim());

                    listbox1.Items.Add("Год окончания:  " + reader[2].ToString().Trim());

                    listbox1.Items.Add("Специальность:  " + reader[3].ToString().Trim());

                    listbox1.Items.Add("Квалификация по диплому:  " + reader[4].ToString().Trim());

                    listbox1.Items.Add("Название курса/Факультет:  " + reader[5].ToString().Trim());


                    listbox1.Items.Add("--------------------------------------------------");
                }
                if (reader[1].ToString().Trim() == "дополнительное")
                {
                    listbox1.Items.Add("Уровень:  " + reader[1].ToString().Trim());

                    listbox1.Items.Add("Образовательное учреждение:  " + reader[0].ToString().Trim());

                    listbox1.Items.Add("Год окончания:  " + reader[2].ToString().Trim());

                    listbox1.Items.Add("Специальность:  " + reader[3].ToString().Trim());

                    listbox1.Items.Add("Название курса/Факультет:  " + reader[5].ToString().Trim());

                    listbox1.Items.Add("--------------------------------------------------");
                }

                if (reader[1].ToString().Trim() == "среднее")
                {
                    listbox1.Items.Add("Уровень:  " + reader[1].ToString().Trim());

                    listbox1.Items.Add("Образовательное учреждение:  " + reader[0].ToString().Trim());

                    listbox1.Items.Add("Год окончания:  " + reader[2].ToString().Trim());

                    listbox1.Items.Add("--------------------------------------------------");
                }
            }

            reader.Close();
            con.Close();

            panel3.Controls.Add(button21);
            panel3.Controls.Add(button22);
          
            button21.BackColor = button22.BackColor = Color.FromArgb(0, 192, 0);
            button21.FlatStyle = button22.FlatStyle = FlatStyle.Flat;
            button21.Font = button22.Font = new Font("Modern No. 20", 14, FontStyle.Bold);
            button21.ForeColor = button22.ForeColor = Color.White;
            button21.Size = button22.Size = new Size(140, 30);

            button21.Location = new Point(66, 464);
            button22.Location = new Point(306, 464);
           
            button21.Text = "Назад";
            button22.Text = "Пригласить";
           
        }

        private void Back_Empl_Clicked(object sender, EventArgs e)
        {
            panel3.Controls.Remove(listbox1);
            panel3.Controls.Remove(button21);
            panel3.Controls.Remove(button22);

            data1.Visible = true;

            button18.Visible = true;
            button19.Enabled = button20.Enabled = true;
        }

        private void Recording_Empl(object sender, EventArgs e)
        {
            submenu = 2;

            List_Vacancies form = new List_Vacancies(submenu, num, kod);
            form.ShowDialog();

            if (ok)
            {


                Choose_Date form1 = new Choose_Date();
                form1.ShowDialog();
                cmd.CommandText = "insert into Собеседования values('" + vac + "','" + kod + "','" + date + "','приглашение на собеседование', '0')";
                if (con.State == ConnectionState.Closed)
                    con.Open();

                cmd.ExecuteNonQuery();


                con.Close();
                count = count - 1;
            }



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
            data1.Columns[2].Name = "Претендент";


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
            cmd.CommandText = "select Собеседования.Дата, Должности.Название, Резюме.ФИО"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Резюме on Собеседования.Кандидат=Резюме.[Личный номер]"
            + " where Вакансии.Организация=" + num + " and Собеседования.Результат in ('повторное собеседование', 'приглашение на собеседование', 'рассмотрение заявки')"
            + " and Собеседования.[Принято/Отказ]=1";


            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime d = DateTime.Parse(reader[0].ToString().Trim());

                if (d.Date > DateTime.Now.Date)
                {
                    data1.Rows.Add(reader[0].ToString().Substring(0, reader[0].ToString().IndexOf(' ')), reader[1].ToString().Trim(), reader[2].ToString().Trim());

                    count++;
                }
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

            data1.Columns[0].Name = "Статус";
            data1.Columns[1].Name = "Должность";
            data1.Columns[2].Name = "Претендент";


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
            cmd.CommandText = "select Собеседования.[Принято/Отказ], Должности.Название, Резюме.ФИО"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Резюме on Собеседования.Кандидат=Резюме.[Личный номер]"
            + " where Вакансии.Организация=" + num + " and Собеседования.Результат in ('приглашение на собеседование')";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (Int32.Parse(reader[0].ToString().Trim()))
                {
                    case 0:
                        {
                            data1.Rows.Add("на рассмотрении", reader[1].ToString().Trim(), reader[2].ToString().Trim());
                            count++;
                            break;
                        }

                    case 1:
                        {
                            data1.Rows.Add("принято", reader[1].ToString().Trim(), reader[2].ToString().Trim());
                            count++;
                            break;
                        }

                    case 2:
                        {
                            data1.Rows.Add("отказано", reader[1].ToString().Trim(), reader[2].ToString().Trim());
                            count++;
                            break;
                        }

                }
            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Вы никого не приглашали на собеседования";
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
            data1.Columns[2].Name = "ФИО";


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
            cmd.CommandText = "select Собеседования.Результат, Должности.Название, Резюме.ФИО"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Резюме on Собеседования.Кандидат=Резюме.[Личный номер]"
            + " where Вакансии.Организация=" + num + " and Собеседования.Результат in ('принят на должность', 'отказано')";

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


            data1.Columns[0].Name = "Дата";
            data1.Columns[1].Name = "Должность";
            data1.Columns[2].Name = "ФИО";


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
            cmd.CommandText = "select Собеседования.Дата, Должности.Название, Резюме.ФИО"
            + " from ((Собеседования inner join Вакансии on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Резюме on Собеседования.Кандидат=Резюме.[Личный номер]"
            + " where Вакансии.Организация=" + num + " and Собеседования.Результат in ('рассмотрение заявки') and Собеседования.[Принято/Отказ]='0'";

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DateTime d = DateTime.Parse(reader[0].ToString().Trim());
                if (d.Date > DateTime.Now.Date)
                {
                    data1.Rows.Add(reader[0].ToString().Substring(0, reader[0].ToString().IndexOf(' ')), reader[1].ToString().Trim(), reader[2].ToString().Trim());

                    count++;
                }

            }

            reader.Close();
            con.Close();

            if (count == 0)
            {
                label5.Text = "Не подано ни одной заявки на собеседования";
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

            cmd.CommandText = "select Резюме.[Личный номер], Резюме.ФИО, Резюме.Пол, Резюме.[Дата рождения],"
                + " Резюме.Адрес, Резюме.Стаж, Резюме.[Номер телефона], Резюме.[Адрес электронной почты],"
                + " Резюме.[Личные качества], Резюме.[Интересующая должность], Резюме.[Уровень заработной платы],"
                + " Резюме.[График работы], Резюме.[Тип занятости], Резюме.[Дополнительная информация], Вакансии.[Регистрационный номер], Вакансии.[Количество рабочих мест]"
                + " from ((Вакансии inner join Должности on Вакансии.Должность=Должности.Код)"
            + " inner join Собеседования on Собеседования.Вакансия=Вакансии.[Регистрационный номер])"
            + " inner join Резюме on Резюме.[Личный номер]=Собеседования.Кандидат"
            + " where Должности.Название='" + str[0] + "' and Резюме.ФИО='" + str[1]
                /*+ "' and Статус='" + str[2]*/ + "'" + " and Вакансии.Статус='активна' and Вакансии.Организация=" + num;

            if (con.State == ConnectionState.Closed)
                con.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                listbox1.Items.Add("ФИО:  " + reader[1].ToString().Trim());

                listbox1.Items.Add("Пол:  " + reader[2].ToString().Trim());

                listbox1.Items.Add("Дата рождения:  " + reader[3].ToString().Substring(0, reader[3].ToString().IndexOf(' ')));

                listbox1.Items.Add("Личные качества:  " + reader[8].ToString().Trim());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Дополнительная информация:  " + reader[13].ToString().Trim());
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Адрес:  " + reader[4].ToString());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Предпочтения");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Интересующая должность:  " + reader[9].ToString().Trim());

                listbox1.Items.Add("Уровень заработной платы:  " + reader[10].ToString().Trim());

                listbox1.Items.Add("График работы:  " + reader[11].ToString().Trim());
                listbox1.Items.Add("Тип занятости:  " + reader[11].ToString().Trim());

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Контактная информация");
                listbox1.Items.Add("--------------------------------------------------");

                listbox1.Items.Add("Номер телефона:  " + reader[6].ToString());
                listbox1.Items.Add("Адрес электронной почты:  " + reader[7].ToString());
                listbox1.Items.Add("--------------------------------------------------");
                listbox1.Items.Add("--------------------------------------------------");
                listbox1.Items.Add("История трудовой деятельности (стаж: "+ reader[5].ToString() + ")");
                listbox1.Items.Add("--------------------------------------------------");





                kod = Int32.Parse(reader[0].ToString().Trim());

                /*status = reader[7].ToString().Trim();*/
                kod1 = Int32.Parse(reader[14].ToString().Trim());

                count = Int32.Parse(reader[15].ToString().Trim());

            }

            reader.Close();
            con.Close();

            cmd.CommandText = "select Должности.Название, [Трудовая история].Организация,  [Трудовая история].[Основные обязанности]"
                + ", [Трудовая история].[Дата начала работы], [Трудовая история].[Дата прекращения работы], [Трудовая история].Характеристика"
                + " from [Трудовая история] inner join Должности on [Трудовая история].Должность = Должности.Код"
                + " where [Трудовая история].Соискатель=" + kod;


            if (con.State == ConnectionState.Closed)
                con.Open();

            reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listbox1.Items.Add("Должность:  " + reader[0].ToString().Trim());

                    listbox1.Items.Add("Организация:  " + reader[1].ToString().Trim());

                    listbox1.Items.Add("Основные обязанности:  " + reader[2].ToString().Trim() );

                    listbox1.Items.Add("Характеристика:  " + reader[5].ToString().Trim());

                    listbox1.Items.Add("Сроки работы:  " + reader[3].ToString().Substring(0, reader[3].ToString().IndexOf(' ')) + " - " + reader[4].ToString().Substring(0, reader[4].ToString().IndexOf(' ')));

                    listbox1.Items.Add("--------------------------------------------------");

                }

                reader.Close();
                con.Close();

                cmd.CommandText = "select [Образовательные учреждения].Наименование, [Сведения об образовании].Уровень,  [Сведения об образовании].[Год окончания]"
                   + ", [Сведения об образовании].Специальность, [Сведения об образовании].[Квалификация по диплому], [Сведения об образовании].[Название курса/Факультет]"
                   + " from [Сведения об образовании] inner join [Образовательные учреждения] on [Сведения об образовании].[Наименование учебного заведения] = [Образовательные учреждения].Код"
                   + " where [Сведения об образовании].Соискатель=" + kod;
                if (con.State == ConnectionState.Closed)
                    con.Open();

                reader = cmd.ExecuteReader();

                
                    listbox1.Items.Add("--------------------------------------------------");
                    listbox1.Items.Add("Образование: ");
                    listbox1.Items.Add("--------------------------------------------------");
                

                while (reader.Read())
                {
                    if (reader[1].ToString().Trim() == "высшее" || reader[1].ToString().Trim() == "незаконченное высшее" || reader[1].ToString().Trim() == "среднее профессиональное")
                    {
                        listbox1.Items.Add("Уровень:  " + reader[1].ToString().Trim());

                        listbox1.Items.Add("Образовательное учреждение:  " + reader[0].ToString().Trim());

                        listbox1.Items.Add("Год окончания:  " + reader[2].ToString().Trim());

                        listbox1.Items.Add("Специальность:  " + reader[3].ToString().Trim());

                        listbox1.Items.Add("Квалификация по диплому:  " + reader[4].ToString().Trim());

                        listbox1.Items.Add("Название курса/Факультет:  " + reader[5].ToString().Trim());


                        listbox1.Items.Add("--------------------------------------------------");
                    }
                    if (reader[1].ToString().Trim() == "дополнительное")
                    {
                        listbox1.Items.Add("Уровень:  " + reader[1].ToString().Trim());

                        listbox1.Items.Add("Образовательное учреждение:  " + reader[0].ToString().Trim());

                        listbox1.Items.Add("Год окончания:  " + reader[2].ToString().Trim());

                        listbox1.Items.Add("Специальность:  " + reader[3].ToString().Trim());

                        listbox1.Items.Add("Название курса/Факультет:  " + reader[5].ToString().Trim());

                        listbox1.Items.Add("--------------------------------------------------");
                    }

                    if (reader[1].ToString().Trim() == "среднее")
                    {
                        listbox1.Items.Add("Уровень:  " + reader[1].ToString().Trim());

                        listbox1.Items.Add("Образовательное учреждение:  " + reader[0].ToString().Trim());

                        listbox1.Items.Add("Год окончания:  " + reader[2].ToString().Trim());
                        
                        listbox1.Items.Add("--------------------------------------------------");
                    }
                }

                reader.Close();
                con.Close();
            panel3.Controls.Add(button11);

            if (submenu == 4)
            {
                panel3.Controls.Add(button12);
                panel3.Controls.Add(button13);

                button12.Enabled = button13.Enabled = true;
            }
            if (submenu == 1 || submenu == 2)
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
            cmd.CommandText = "update Собеседования set [Принято/Отказ]=1 where Вакансия=" + kod1 + " and Кандидат=" + kod
                + " and Результат='рассмотрение заявки'";


            if (con.State == ConnectionState.Closed)
                con.Open();


            cmd.ExecuteNonQuery();

            cmd.CommandText = "update Вакансии set [Количество рабочих мест]=" + (count - 1)
                + " where [Регистрационный номер]=" + kod1;

            cmd.ExecuteNonQuery();

            con.Close();

            count = count - 1;

            

            button12.Enabled = false;
        }

        private void No_Clicked(object sender, EventArgs e)
        {
            cmd.CommandText = "update Собеседования set [Принято/Отказ]=2 where Вакансия=" + kod1 + " and Кандидат=" + kod
                + " and Результат='рассмотрение заявки'";

            if (con.State == ConnectionState.Closed)
                con.Open();


            cmd.ExecuteNonQuery();

            cmd.CommandText = "update Вакансии set [Количество рабочих мест]=" + (count + 1)
               + " where [Регистрационный номер]=" + kod1;

            cmd.ExecuteNonQuery();

            con.Close();

            count = count + 1;

           

            button12.Enabled = false;
            button13.Enabled = false;

        }

        #endregion

        #region ссылки
        private void White_Link()
        {
            ll1.LinkColor = ll2.LinkColor = ll3.LinkColor = ll4.LinkColor = Color.White;
        }

        private void ll1_Clicked(object sender, EventArgs e)
        {
            switch (menu)
            {
                
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
                
                case 4:
                    {
                        Request();
                        break;
                    }
            }
            White_Link();
            ll4.LinkColor = Color.Red;
        }
        #endregion
    }
}
