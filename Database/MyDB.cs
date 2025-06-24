using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FInalLibrarySystem.Database
{
    //open xampp
    //create database
    //create table users
    //add the mysql connector

    internal class MyDB
    {
        // the connection 
        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=csharp_lms_db");

        //create a function to open the connectoin
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //create a function to open the connectoin
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        //create a function to return the connection
        public MySqlConnection getConnection()
        {
            return connection;
        }

    }
}
