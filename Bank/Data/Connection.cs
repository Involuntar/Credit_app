using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Aspose.Pdf;
using Aspose.Pdf.Plugins;
using Aspose.Pdf.Text;
using MySql.Data.MySqlClient;

namespace Bank.Data
{
    internal class Connection
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=26.212.113.38;port=3306;username=root;password=Nyp1809!pyN51;database=bank";
            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySQL Connection! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void Add_user(Users users)
        {
            string sql = $"INSERT INTO users VALUES (NULL, @firstname, @middlename, @lastname, " +
                $"@login, @password, @email)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            
            cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = users.Firstname;
            cmd.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = users.Middlename;
            cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = users.Lastname;
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = users.Login;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = users.Password;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = users.Email;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Пользователь добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Добавление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Add_credit(Credits credit)
        {
            string sql = $"INSERT INTO credits VALUES (NULL, @term, " +
                $"@summ, " +
                $"@rate, " +
                $"@type, " +
                $"@status, " +
                $"(SELECT id FROM users WHERE lastname LIKE @user))";

            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@term", MySqlDbType.VarChar).Value = credit.Term_id;
            cmd.Parameters.Add("@summ", MySqlDbType.VarChar).Value = credit.Summ;
            cmd.Parameters.Add("@rate", MySqlDbType.VarChar).Value = credit.Rate_id;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = credit.Credit_type_id;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = credit.Statuses_id;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = credit.Users_id; 
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Кредит добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Добавление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void Add_mortgages(Mortgages mortgages)
        {
            string sql = $"INSERT INTO mortgages VALUES (NULL, @cost, @init_fee, @credit_summ, " +
                $"@term, " +
                $"@rate, " +
                $"@credit_type_id, " +
                $"(SELECT id FROM users WHERE login LIKE @user), " +
                $"@statuses_id)";
            
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@cost", MySqlDbType.VarChar).Value = mortgages.Cost;
            cmd.Parameters.Add("@init_fee", MySqlDbType.VarChar).Value = mortgages.Init_fee;
            cmd.Parameters.Add("@credit_summ", MySqlDbType.VarChar).Value = mortgages.Credit_summ;
            cmd.Parameters.Add("@term", MySqlDbType.UInt16).Value = mortgages.Term_id;

            cmd.Parameters.Add("@rate", MySqlDbType.VarChar).Value = mortgages.Rate_id;
            cmd.Parameters.Add("@credit_type_id", MySqlDbType.VarChar).Value = mortgages.Credit_type_id;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = mortgages.Users_id;
            cmd.Parameters.Add("@statuses_id", MySqlDbType.VarChar).Value = mortgages.Statuses_id;
            
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные об ипотеке добавлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Добавление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Update_users(Users users, string id)
        {
            string sql = "UPDATE users SET firstname = @firstname, middlename = @middlename," +
                "lastname = @lastname, login = @login, email = @email " +
                "WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = users.Firstname;
            cmd.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = users.Middlename;
            cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = users.Lastname;
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = users.Login;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = users.Email;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Изменения произведены успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Изменение произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Update_credit(Credits credit, string id)   
        {
            string sql = $"UPDATE credits SET summ = @summ, " +
                $"term_id = @term, " +
                $"rate_id = @rate, " +
                $"credit_type_id = @type, " +
                $"statuses_id = @status, " +
                $"users_id = (SELECT id FROM users WHERE lastname = @user) " +
                $"WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;

            cmd.Parameters.Add("@term", MySqlDbType.VarChar).Value = credit.Term_id;
            cmd.Parameters.Add("@summ", MySqlDbType.VarChar).Value = credit.Summ;
            cmd.Parameters.Add("@rate", MySqlDbType.VarChar).Value = credit.Rate_id;
            cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = credit.Credit_type_id;
            cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = credit.Statuses_id;
            cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = credit.Users_id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Изменения произведены успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Изменение произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Update_mortgages(Mortgages mortgages, string id)
        {
            string sql = $"UPDATE mortgages SET cost = @cost, init_fee = @init_fee, credit_summ = @credit_summ, " +
                $"term_id = @term, " +
                $"rate_id = @rate, " +
                $"credit_type_id = @credit_type_id, " + 
                $"users_id = (SELECT id FROM users WHERE login = @users), " +
                $"statuses_id = @statuses_id " +
                $"WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
                                                                       
                                                                 
            cmd.Parameters.Add("@cost", MySqlDbType.VarChar).Value = mortgages.Cost;
            cmd.Parameters.Add("@init_fee", MySqlDbType.VarChar).Value = mortgages.Init_fee;
            cmd.Parameters.Add("@credit_summ", MySqlDbType.VarChar).Value = mortgages.Credit_summ;
            cmd.Parameters.Add("@term", MySqlDbType.VarChar).Value = mortgages.Term_id;

            cmd.Parameters.Add("@rate", MySqlDbType.VarChar).Value = mortgages.Rate_id;
            cmd.Parameters.Add("@credit_type_id", MySqlDbType.VarChar).Value = mortgages.Credit_type_id;
            cmd.Parameters.Add("@users", MySqlDbType.VarChar).Value = mortgages.Users_id;
            cmd.Parameters.Add("@statuses_id", MySqlDbType.VarChar).Value = mortgages.Statuses_id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные об ипотеке успешно обновлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Обновление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Delete_user(string id)
        {
            string sql = "DELETE FROM users WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удалено успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Удаление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Delete_credit(string id)
        {
            string sql = "DELETE FROM credits WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удалено успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Удаление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void Delete_mortgages(string id)
        {
            string sql = "DELETE FROM mortgages WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Удалено успешно", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Удаление произошло с ошибкой! \n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void Display(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand( sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void Search(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.Parameters.Add("@search", MySqlDbType.VarChar).Value = public_class.Search;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }

        public static void SelectInComboBox(string query, ComboBox cb,string DM, string VM)
        {
            string sql = query;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable ds = new DataTable();
            adp.Fill(ds);
            cb.DataSource = ds;
            cb.DisplayMember = DM;
            cb.ValueMember = VM;
            
            con.Close();
        }

        public static void Create_pdf(double summ, int term, string file_name)
        {
            Document doc = new Document();

            Table table = new Table();
            table.ColumnAdjustment = ColumnAdjustment.AutoFitToContent;
            table.DefaultCellBorder = new BorderInfo(BorderSide.All, 0.1F);
            table.Border = new BorderInfo(BorderSide.All, 1F);

            /*
            MarginInfo margin = new MarginInfo();
            margin.Top = 5f;
            margin.Bottom = 5f;
            margin.Left = 5f;
            margin.Right = 5f;
            table.DefaultCellPadding = margin;*/

            Row main_row = table.Rows.Add();
            main_row.Cells.Add("Месяц");
            main_row.Cells.Add("Остаток долга");
            main_row.Cells.Add("Сумма платежа");
            main_row.Cells.Add("Платёж по процентам");
            main_row.Cells.Add("Платёж по основному долгу");
            main_row.Cells.Add("Остаток долга на конец периода");

            double debt = summ / term;
            for (int i = 0; i < term - 1; ++i)
            {
                double perc = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;

                Row row = table.Rows.Add();

                row.Cells.Add(Convert.ToString(i + 1));
                row.Cells.Add(Convert.ToString(Math.Round(summ, 2)));
                row.Cells.Add(Convert.ToString(Math.Round(perc + debt, 2)));
                row.Cells.Add(Convert.ToString(Math.Round(perc, 2)));
                row.Cells.Add(Convert.ToString(Math.Round(debt, 2)));
                row.Cells.Add(Convert.ToString(Math.Round(summ - debt, 2)));

                summ -= debt;
            }
            double perc_last = summ * Convert.ToDouble(public_class.Rate) / 12 / 100;

            Row last_row = table.Rows.Add();

            last_row.Cells.Add(Convert.ToString(term));
            last_row.Cells.Add(Convert.ToString(Math.Round(summ, 2)));
            last_row.Cells.Add(Convert.ToString(Math.Round(perc_last + debt, 2)));
            last_row.Cells.Add(Convert.ToString(Math.Round(perc_last, 2)));
            last_row.Cells.Add(Convert.ToString(Math.Round(debt, 2)));
            last_row.Cells.Add("0");
            
            Page page1 = doc.Pages.Add();
            //имя--------------------------------------------------------------
            TextFragment name = new TextFragment($"ФИО занимателя: {public_class.Lastname} {public_class.Firstname} {public_class.Middlename}");

            name.Position = new Position(200, 700);
            name.TextState.FontSize = 20;
            name.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            name.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder1 = new TextBuilder(page1);
            builder1.AppendText(name);

            //займ--------------------------------------------------------------
            TextFragment credit = new TextFragment($"Сумма займа: {public_class.Start_Summ} р.");

            credit.Position = new Position(200, 660);
            credit.TextState.FontSize = 20;
            credit.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            credit.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder2 = new TextBuilder(page1);
            builder2.AppendText(credit);

            //займ--------------------------------------------------------------
            TextFragment rate = new TextFragment($"Процентная ставка: {public_class.Rate} %");

            rate.Position = new Position(200, 620);
            rate.TextState.FontSize = 20;
            rate.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            rate.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder3 = new TextBuilder(page1);
            builder3.AppendText(rate);

            //срок--------------------------------------------------------------
            TextFragment Term = new TextFragment($"Срок кредита: {public_class.Term} лет");

            Term.Position = new Position(200, 580);
            Term.TextState.FontSize = 20;
            Term.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            Term.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder4 = new TextBuilder(page1);
            builder4.AppendText(Term);

            //почта--------------------------------------------------------------
            TextFragment mail = new TextFragment($"Почта: {public_class.Mail}");

            mail.Position = new Position(200, 540);
            mail.TextState.FontSize = 20;
            mail.TextState.Font = FontRepository.FindFont("TimesNewRoman");
            mail.TextState.ForegroundColor = Aspose.Pdf.Color.FromRgb(System.Drawing.Color.Black);

            TextBuilder builder5 = new TextBuilder(page1);
            builder5.AppendText(mail);

            //таблица------------------------------------------------------------
            Page page2 = doc.Pages.Add();
            page2.Paragraphs.Add(table);

            doc.Save("C:\\Users\\Public\\Documents\\" + file_name);
        }
    }
}
