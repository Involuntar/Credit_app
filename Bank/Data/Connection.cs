using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
        
        public static void Update_users(Users users, string id)
        {
            string sql = "UPDATE users SET firstname = @firstname, middlename = @middlename," +
                "lastname = @lastname, login = @login, password = @password, email = @email " +
                "WHERE id = @id";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = users.Firstname;
            cmd.Parameters.Add("@middlename", MySqlDbType.VarChar).Value = users.Middlename;
            cmd.Parameters.Add("@lastname", MySqlDbType.VarChar).Value = users.Lastname;
            cmd.Parameters.Add("@login", MySqlDbType.VarChar).Value = users.Login;
            cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = users.Password;
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

        public static void Delete_type(string id)
        {
            string sql = "DELETE FROM credits_types WHERE id = @id";
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
    }
}
