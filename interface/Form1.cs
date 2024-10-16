using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            game.ShowDialog();
        }
        gameform game = new gameform();
    }
}
        /*
        void start()
        {
        }
    }
    interface Idbhandler
    {
        List<user> readall();
        void insertoneuser(user oneuser);
        void deleteoneuser(user oneuser);
        void deleteall();
        void updateoneuser(user oneuser);
    }
    public class user
    {
        public static List<user> users = new List<user>();
        public string username { get; set; }
        public string password { get; set; }
        public int points { get; set; }
        public int id { get; set; }
    }
    public class dbhandler : Idbhandler
    {
        string serveraddress;
        string username;
        string password;
        string dbname;
        string connectionstring;
        MySqlConnection connection;
        public dbhandler()
        {
            //szerver címe
            serveraddress = "localhost";
            username = "root";
            password = "";
            dbname = "users";
            connectionstring = $"Server={serveraddress};Database={dbname};User={username};Password={password}";
            connection = new MySqlConnection(connectionstring);
        }
        public void deleteall()
        {
            throw new NotImplementedException();
        }

        public void deleteoneuser(user oneuser)
        {
            try
            {
                connection.Open();
                string query = $"DELETE FROM users WHERE ID =  '{oneuser.id}'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error kurva anyád kubinyi: " + e.Message);
            }

        }
        public void insertoneuser(user oneuser)
        {
            try
            {
                connection.Open();
                string query = $"insert into users (    username, password, points) values ('{oneuser.username}','{oneuser.password}','{oneuser.points})'";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
        public List<user> readall()
        {
            List<user> users = new List<user>();
            try
            {
                connection.Open();
                string query = "select * from users";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader read = command.ExecuteReader();
                while (read.Read())
                {
                    user oneuser = new user();
                    oneuser.id = read.GetInt32(read.GetOrdinal("ID"));
                    oneuser.username = read.GetString(read.GetOrdinal("usernamef"));
                    oneuser.password = read.GetString(read.GetOrdinal("password"));
                    oneuser.points = read.GetInt32(read.GetOrdinal("points"));
                    users.Add(oneuser);
                }
                read.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return users    ;
        }

        public void updateoneuser()
        {
            throw new NotImplementedException();
        }

        public void updateoneuser(user oneuser)
        {
            throw new NotImplementedException();
        }
    }



}
        */