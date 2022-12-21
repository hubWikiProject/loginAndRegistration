using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loginAndRegistration
{
    internal class DBConnection
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=ci_sharp");

        /* Открываем соединение к базе данных, если оно закрыто */
        public void openConnection1()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        /* Закрывает соединение к базе данных, если оно открыто */
        public void closeConnection1()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Clone();
            }
        }

        /* Получаем соединение с базой данных */
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
