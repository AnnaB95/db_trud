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
    public partial class Registration_Form : Form
    {
        #region переменные

        private int submenu = 1;
        int kod = 0;
        int count1 = 0;
        int count2 = 0;

        Button button1 = new Button(), button2 = new Button();

        DataGridView data1 = new DataGridView(), data2 = new DataGridView();

        Label label5 = new Label(), label6 = new Label();

        TextBox textboxes0 = new TextBox();
        TextBox textboxes1 = new TextBox();
        TextBox textboxes2 = new TextBox();
        TextBox textboxes3 = new TextBox();
        TextBox textboxes4 = new TextBox();
        TextBox textboxes5 = new TextBox();
        TextBox textboxes6 = new TextBox();

        ComboBox comboboxes0 = new ComboBox();
        ComboBox comboboxes1 = new ComboBox();

        SqlConnection con = new SqlConnection("Data Source=." + @"\SQLEXPRESS;" + "Integrated Security=true;Initial Catalog=trud;");
        SqlCommand cmd = new SqlCommand(); 
        #endregion

        public Registration_Form()
        {
            InitializeComponent();
        }

        private void Registration_Form_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            label2.Visible = false;
            textBox2.Select();

            for (int i = DateTime.Now.Year - 18; i >= DateTime.Now.Year - 100; i--)
                comboBox3.Items.Add(i.ToString());

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 82;

            button1.Text = "Plus";
            button1.Location = new Point(153, 33);


            button2.Text = "Minus";
            button2.Location = new Point(391, 33);

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

            data2.ColumnCount = 2;
            data2.Size = new Size(486, 284);
            data2.Columns[0].Width = 200;
            data2.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            data2.RowHeadersVisible = false;
            data2.ColumnHeadersVisible = false;
            data2.AllowUserToAddRows = false;
            data2.AllowUserToDeleteRows = false;
            data2.AllowUserToResizeColumns = false;
            data2.ReadOnly = false;
            data2.AllowUserToResizeRows = false;
            data2.Location = new Point(54, 99);
            data2.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            data2.Visible = true;


            label5.Dock = DockStyle.Fill;
            label5.Text = "Информация о прежних местах работы отсутствует";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Font = new Font("Modern No. 20", 30, FontStyle.Bold);

            label6.Dock = DockStyle.Fill;
            label6.Text = "Информация об образовании отсутствует";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Font = new Font("Modern No. 20", 30, FontStyle.Bold);


            comboboxes0.DropDownStyle = comboboxes1.DropDownStyle = ComboBoxStyle.DropDownList;
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

            comboboxes0.SelectedIndex = 0;
            comboboxes1.SelectedIndex = 0;
            

            textboxes0.Font = textboxes2.Font = textboxes4.Font = textboxes5.Font = textboxes6.Font = new Font("Modern No. 20", 12, FontStyle.Bold);
            textboxes1.Font = textboxes3.Font = new Font("Modern No. 20", 12, FontStyle.Regular);
            textboxes0.ReadOnly = textboxes2.ReadOnly = textboxes6.ReadOnly = textboxes4.ReadOnly = textboxes5.ReadOnly = true;
            textboxes1.ReadOnly = textboxes3.ReadOnly = false;



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

            button1.Click += Plus_Clicked;
            button2.Click += Minus_Clicked;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (submenu)
            {
                case 1:
                    Cancel();
                    break;
                case 2:
                    About_me();
                    break;
                case 3:
                    Work_history();
                    break;
                case 4:
                    Education();
                    break;
            }
        }

        private void About_me()
        {
            submenu = 1;

            White_Link();
            linkLabel1.LinkColor = Color.Red;

            button5.Text = "Отмена";

            panel4.Controls.Clear();

            panel4.Controls.Add(textBox1);           
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox5);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(textBox7);
            panel4.Controls.Add(textBox8);
            panel4.Controls.Add(textBox9);
            panel4.Controls.Add(textBox10);
            panel4.Controls.Add(textBox11);
            panel4.Controls.Add(textBox12);
            panel4.Controls.Add(textBox13);
            panel4.Controls.Add(textBox14);
            panel4.Controls.Add(textBox15);
            panel4.Controls.Add(textBox16);
            panel4.Controls.Add(textBox17);
            panel4.Controls.Add(textBox18);
            panel4.Controls.Add(textBox19);
            panel4.Controls.Add(textBox19);
            panel4.Controls.Add(textBox20);
            panel4.Controls.Add(textBox21);
            panel4.Controls.Add(textBox22);
            panel4.Controls.Add(textBox23);
            panel4.Controls.Add(textBox24);
            panel4.Controls.Add(textBox25);
            panel4.Controls.Add(textBox26);
            panel4.Controls.Add(textBox27);
            panel4.Controls.Add(textBox28);


            panel4.Controls.Add(radioButton1);
            panel4.Controls.Add(radioButton2);


            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox3);



            textBox2.Select();



        }

        private void Work_history()
        {
            submenu = 2;

            White_Link();
            linkLabel2.LinkColor = Color.Red;

            button5.Text = "Назад";

            panel4.Controls.Clear();
            //panel4.Controls.Add(textBox20);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(data1);        
                       

            if (data1.RowCount == 0)
            {
                data1.Controls.Add(label5);
            }
        }

        private void Education()
        {
            submenu = 3;

            White_Link();
            linkLabel3.LinkColor = Color.Red;

            button6.Text = "Далее";

            panel4.Controls.Clear();
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(data2);


            if (data2.RowCount == 0)
            {
                data2.Controls.Add(label6);
            }

        }

        private void Preferences()
        {
            submenu = 4;

            White_Link();
            linkLabel4.LinkColor = Color.Red;

            button6.Text = "Регистрация";

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


        }

        private void Plus_Clicked(object sender, EventArgs e)
        {
           
            switch (submenu)
            {
                case 2:
                    {
                        if (data1.Contains(label5))
                        {
                            data1.Controls.Remove(label5);
                        }
                        count1++;
                        Add_Rows();
                        break;
                    }
                case 3:
                    {
                        if (data2.Contains(label6))
                        {
                            data2.Controls.Remove(label6);
                        }
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
                            count2++;
                            Add_Rows();

                            data2[1, data2.RowCount - kod].Value = Educ.ur;
                        }

                        break;
                    }
            }
        }

         private void Minus_Clicked(object sender, EventArgs e)
        {
            switch (submenu)
            {
                case 2:
                    {
                        if (count1 > 0)
                        {
                            count1--;
                            Remove_Rows();
                        }
                        break;
                    }
                case 3:
                    {
                        if (count2 > 0)
                        {
                            count2--;
                            Remove_Rows();
                        }
                        break;
                    }
            }
        }

        private void Add_Rows()
        {
            

            switch (submenu)
            {
                case 2:
                    {
                        data1.Rows.Add("Запись", count1.ToString());
                        data1.Rows.Add("Должность", "");
                        data1.Rows.Add("Организация", "");
                        data1.Rows.Add("Основные обязанности", "");
                        data1.Rows.Add("Дата начала работы", "");
                        data1.Rows.Add("Дата прекращения работы", "");
                        data1.Rows.Add("Характеристика", "");
                        data1[0, (count1 - 1) * 6 + count1 - 1].ReadOnly = true;
                        data1[1, (count1 - 1) * 6 + count1 - 1].ReadOnly = true;
                        data1[0, (count1 - 1) * 6 + count1 - 1].Style.BackColor = Color.Gray;
                        data1[1, (count1 - 1) * 6 + count1 - 1].Style.BackColor = Color.Gray;
                        data1.Rows[count1 * 6 + count1 - 1].HeaderCell.Style.BackColor = Color.Gray;
                        data1[0, (count1 - 1) * 6 + count1 - 1].Style.ForeColor = Color.White;
                        data1[1, (count1 - 1) * 6 + count1 - 1].Style.ForeColor = Color.White;

                        //dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;

                        for (int i = count1 * 6 + count1 - 7; i < count1 * 6 + count1 - 1; i++)
                        {
                            //dataGridView1.Rows[i].HeaderCell.Value = num.ToString();
                            // dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;
                            data1[0, i].ReadOnly = true;

                        }

                        int rowNum = (count1 - 1) * 6 + count1;
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
                                    data2.Rows.Add("Запись", count2.ToString());
                                    data2.Rows.Add("Уровень", "");
                                    data2.Rows.Add("Учебное заведение", "");
                                    data2.Rows.Add("Год окончания", "");
                                 
                                    break;
                                }
                            case 5:
                                {
                                    data2.Rows.Add("Запись", count2.ToString());
                                    data2.Rows.Add("Уровень", "");
                                    data2.Rows.Add("Учебное заведение", "");
                                    data2.Rows.Add("Год окончания", "");
                                    data2.Rows.Add("Специализация", "");                                   
                                    data2.Rows.Add("Название курса", "");
                                    break;
                                }
                            case 6:
                                {
                                    data2.Rows.Add("Запись", count2.ToString());
                                    data2.Rows.Add("Уровень", "");
                                    data2.Rows.Add("Учебное заведение", "");
                                    data2.Rows.Add("Год окончания", "");
                                    data2.Rows.Add("Специализация", "");
                                    data2.Rows.Add("Квалификация по диплому", "");
                                    data2.Rows.Add("Факультет", "");
                                    break;
                                }

                        
                                
                        }

                        data2[0, data2.RowCount - kod - 1].ReadOnly = true;
                        data2[1, data2.RowCount - kod - 1].ReadOnly = true;
                        data2[0, data2.RowCount - kod - 1].Style.BackColor = Color.Gray;
                        data2[1, data2.RowCount - kod - 1].Style.BackColor = Color.Gray;
                        data2.Rows[data2.RowCount - kod - 1].HeaderCell.Style.BackColor = Color.Gray;
                        data2[0, data2.RowCount - kod - 1].Style.ForeColor = Color.White;
                        data2[1, data2.RowCount - kod - 1].Style.ForeColor = Color.White;

                        //dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;

                        for (int i = data2.RowCount - kod; i <data2.RowCount; i++)
                        {
                            //dataGridView1.Rows[i].HeaderCell.Value = num.ToString();
                            // dataGridView1.Rows[num * 6 + num - 1].HeaderCell.ReadOnly = true;
                            data2[0, i].ReadOnly = true;

                        }

                        int rowNum = data2.RowCount - kod;
                        DataGridViewCell cell = data2.Rows[rowNum].Cells[1];
                        data2.CurrentCell = cell;
                        data2.CurrentCell.Selected = true; // в некоторых случаях без этого не работает*/
                                               
                        break;
                    }
            }

        }

        private void Remove_Rows()
        {
            int min = 0;

            switch (submenu)
            {
                case 2:
                    {

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

                        if (count1 == 0)
                        {
                            data1.Controls.Add(label5);
                        }
                    }
                    break;


                case 3:
                    {

                        int max = data2.RowCount;
                        int sel = data2.CurrentRow.Index;

                        for (int i = sel; i > -1; i--)
                        {
                            if (data2[0, i].Value.ToString() == "Запись")
                            {
                                min = i;
                                break;
                            }

                        }

                        for (int i = sel + 1; i < data2.RowCount; i++)
                        {
                            if (data2[0, i].Value.ToString() == "Запись")
                            {
                                max = i;
                                break;
                            }
                        }

                        if (count2 == 0)
                        {
                            data2.Controls.Add(label6);
                        }
                    }
                    break;
            }

        }

        private int Get_Kod(string position)
        {
            int kod = 0;

           // cmd = con.CreateCommand();
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

        private void Save()
        {
            int row = 0;

            Who_Registration.fl = true;
            label2.Visible = false;

            label2.Text = "Такой пользователь уже зарегистрирован";

            if (textBox2.Text.Trim() == "") { label2.Visible = true; label2.Text = "ФИО обязательно для заполнения"; About_me();  return; }

            if (textBox18.Text.Trim() == "") { label2.Visible = true; label2.Text = "Телефон обязателен для заполнения"; About_me();  return; }

            cmd = con.CreateCommand();

            cmd.CommandText = "select [Личный номер] from Резюме where ФИО='" + textBox2.Text.Trim() + " ' and [Номер телефона]='" + textBox18.Text.Trim() + "'";

            if (con.State == ConnectionState.Closed)
                con.Open();



            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.Read())
            {
                label2.Visible = true;
                reader.Close();
                con.Close();
                return;
            }
            else
            {
                reader.Close();

                string str, sex, date;
                if (textBox25.Text.Trim() != "")
                {
                    str = "г." + textBox7.Text.Trim() + ", ул." + textBox10.Text.Trim() + ", д." + textBox12.Text.Trim() + "/" + textBox25.Text.Trim() + ", оф." + textBox27.Text.Trim();
                }
                else
                {
                    str = "г." + textBox7.Text.Trim() + ", ул." + textBox10.Text.Trim() + ", д." + textBox12.Text.Trim() + ", кв." + textBox27.Text.Trim();
                }

                if (radioButton1.Checked) sex = "м"; else sex = "ж";

              
                    date = comboBox1.SelectedItem.ToString() + "." + comboBox2.SelectedItem.ToString() + "." + comboBox3.SelectedItem.ToString() + " ";
                

                int kod, stag = 0;

                cmd.CommandText = "select top 1 [Личный номер] from Резюме order by [Личный номер] desc";
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    reader.Close();
                    

                    kod = (int)cmd.ExecuteScalar();

                    kod++;

                    int kod1 = Get_Kod(textboxes1.Text.Trim());

                   cmd.CommandText = "insert into Резюме values ('" + kod + "', '" + textBox2.Text.Trim() + "', '" + sex + "', '"
                    + date + "', '" + str + "', '', '" + textBox18.Text.Trim() + "', '" + textBox20.Text.Trim() + "', '" + DateTime.Now.Date.ToString().Substring(0, DateTime.Now.Date.ToString().IndexOf(' ')) + "', 'ищет работу', '" + textBox14.Text.Trim() 
                    + "', '" + kod1 + "', '" + textboxes3.Text.Trim() + "', '" + comboboxes1.SelectedItem + "', '" + comboboxes0.SelectedItem + "', '" + textBox22.Text.Trim() + "')";

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    cmd.ExecuteNonQuery();

                    con.Close();

                    string[] str_info = new string[6];

                    while (row < data1.RowCount)
                    {

                        str_info[0] = data1[1, row + 1].Value.ToString();
                        str_info[1] = data1[1, row + 2].Value.ToString();
                        str_info[2] = data1[1, row + 3].Value.ToString();
                        str_info[3] = data1[1, row + 4].Value.ToString();
                        str_info[4] = data1[1, row + 5].Value.ToString();
                        str_info[5] = data1[1, row + 6].Value.ToString();

                        row = row + 7;

                        kod1 = Get_Kod(str_info[0]);

                        cmd.CommandText = "select Соискатель from [Трудовая история] where Соискатель='" + kod + "' and Должность="
                        + kod1 + " and Организация='" + str_info[1] + "' and [Дата начала работы]='" + str_info[3] + "'";

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            reader.Close();
                            con.Close();
                            continue;
                        }
                        else
                        {
                            reader.Close();
                            cmd.CommandText = "insert into [Трудовая история] values('" + kod + "', '" + kod1 + "', '" + str_info[1]
                                        + "', '" + str_info[2] + "', '" + str_info[3] + "', '"
                                        + str_info[4] + "', '" + str_info[5] + "')";

                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();

                            //stag = Int32.Parse(DateTime.Parse(DateTime.Parse(str_info[4]) - DateTime.Parse(str_info[3])).Year.ToString());
                            DateTime d1 = DateTime.Parse(str_info[4]);
                            DateTime d2 = DateTime.Parse(str_info[3]);
                             TimeSpan d3 = d1 - d2;

                             stag += d3.Days;
                        }

                    }


                    cmd.CommandText = "update Резюме set Стаж=" + stag / 365 + " where [Личный номер]=" + kod;

                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    cmd.ExecuteNonQuery();
                    con.Close();

                    row = 0;

                    while (row < data2.RowCount)
                    {

                        if ((data2[1, row + 1].Value.ToString().Trim() == "высшее") || (data2[1, row + 1].Value.ToString().Trim() == "незаконченное высшее") || (data2[1, row + 1].Value.ToString().Trim() == "среднее профессиональное"))
                        {
                            str_info[0] = data2[1, row + 1].Value.ToString();
                            str_info[1] = data2[1, row + 2].Value.ToString();
                            str_info[2] = data2[1, row + 3].Value.ToString();
                            str_info[3] = data2[1, row + 4].Value.ToString();
                            str_info[4] = data2[1, row + 5].Value.ToString();
                            str_info[5] = data2[1, row + 6].Value.ToString();

                            row = row + 7;

                        }
                        else
                        {
                            if (data2[1, row + 1].Value.ToString().Trim() == "дополнительное")
                            {
                                str_info[0] = data2[1, row + 1].Value.ToString();
                                str_info[1] = data2[1, row + 2].Value.ToString();
                                str_info[2] = data2[1, row + 3].Value.ToString();
                                str_info[3] = data2[1, row + 4].Value.ToString();
                                str_info[4] = null;
                                str_info[5] = data2[1, row + 5].Value.ToString();

                                row = row + 6;
                            }
                            else
                            {
                                str_info[0] = data2[1, row + 1].Value.ToString();
                                str_info[1] = data2[1, row + 2].Value.ToString();
                                str_info[2] = data2[1, row + 3].Value.ToString();
                                str_info[3] = null;
                                str_info[4] = null;
                                str_info[5] = null;

                                row = row + 4;
                            }
                        }

                        kod1 = Get_Educ_Kod(str_info[1]);

                        cmd.CommandText = "select Соискатель from [Сведения об образовании] where Соискатель=" + kod
                            + " and [Наименование учебного заведения]=" + kod1 + " and [Год окончания]=" + str_info[2];

                        if (con.State == ConnectionState.Closed)
                            con.Open();
                        reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            reader.Close();
                            con.Close();
                            continue;
                        }
                        else
                        {
                            reader.Close();
                            cmd.CommandText = "insert into [Сведения об образовании] values ('" + kod + "', '" + str_info[0]
                               + "', '" + kod1 + "', '" + str_info[2] + "', '" + str_info[3] + "', '" + str_info[4] + "', '" + str_info[5] + "')";

                            if (con.State == ConnectionState.Closed)
                                con.Open();
                            cmd.ExecuteNonQuery();

                            con.Close();

                        }
                    }


                    this.Visible = false;
                    Regist_Users_Form f = new Regist_Users_Form(textBox2.Text.Trim(), kod.ToString());
                    f.ShowDialog();

                    this.Close();
                }

            

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

        private void Cancel()
        {
            Who_Registration.fl = false;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            switch (submenu)
            {
                case 1:
                    Work_history();
                    break;
                case 2:
                    Education();
                    break;
                case 3:
                    Preferences();
                    break;
                case 4:
                    Save();
                    break;
            }
        }

        private void White_Link()
        {
            linkLabel1.LinkColor = linkLabel2.LinkColor = linkLabel3.LinkColor = linkLabel4.LinkColor = Color.White;
        }
    }
}
