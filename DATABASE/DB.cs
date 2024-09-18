using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace LibrarySystem.DATABASE
{

    class DB
    {
        // the connection
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=libsys");

        // create a function to open the connection
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        // create a function to close the connection
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        // create a function to return the connection
        public MySqlConnection getConnection()
        {
            return connection; 
        }

        public int setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connection);
            if(parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnection();
            int commandState = command.ExecuteNonQuery();

            closeConnection();
            return commandState;
        }

    }

   
}
