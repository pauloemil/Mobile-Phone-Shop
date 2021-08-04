using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Management;

namespace jaimeMarket
{
    class Database
    {
        //public SQLiteConnection Connect;
        public string connectionstring { get; set; }
        string connection;
        SQLiteConnection con;
        public void getconnection()
        {
            connection = @"DataSource=Database.db; Version=3;Pooling=true;";
            connectionstring = connection;
        }
        public Database()
        {

            if (!File.Exists("./Database.db"))
            {
                SQLiteConnection.CreateFile("./Database.db");
                getconnection();
                con = new SQLiteConnection(connection);
                string query1 = "CREATE TABLE \"items\" (\"id\"    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\"name\"  TEXT NOT NULL,\"amount\"    INTEGER NOT NULL,\"price\"	REAL NOT NULL); ";
                string query2 = "CREATE TABLE \"sold\" (\"sellingID\" INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\"itemID\"    INTEGER NOT NULL,\"itemName\"  TEXT NOT NULL,\"amount\"    INTEGER NOT NULL,\"totalPrice\"    REAL NOT NULL,\"year\"  INTEGER NOT NULL,\"month\" INTEGER NOT NULL,\"day\"   INTEGER NOT NULL,\"time\"  TEXT NOT NULL, \"added\"	INTEGER NOT NULL);";
                string query3 = "CREATE TABLE \"ta3delat\" (\"id\"    INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,\"elTa3del\"  TEXT NOT NULL,\"date\"  TEXT NOT NULL,\"time\"  TEXT NOT NULL); ";
                exe(query1);
                exe(query2);
                exe(query3);
            }
            else
            {
                getconnection();
                con = new SQLiteConnection(connection);
            }
        }
        public void exe(string q)
        {
            try
            {
                openConnection();
                SQLiteCommand command = new SQLiteCommand(q, con);
                command.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            finally
            {
                closeConnection();
            }
        }
        public SQLiteConnection Con
        {
            get { return this.con; }

        }
        public SQLiteDataReader readme(string q)
        {
            SQLiteCommand command = new SQLiteCommand(q, con);
            SQLiteDataReader reader = command.ExecuteReader();
            return reader;
        }
        public void openConnection()
        {
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void closeConnection()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
        }
    }
}
