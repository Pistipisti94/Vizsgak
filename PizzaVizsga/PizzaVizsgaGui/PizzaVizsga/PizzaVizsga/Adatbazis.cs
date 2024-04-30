using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PizzaVizsga
{
    internal class Adatbazis
    {
        MySqlConnection _connection;
        MySqlCommand _command;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Database = "pizza";
            builder.Password = "";
            _connection = new MySqlConnection(builder.ConnectionString);
            _command = _connection.CreateCommand();
            try
            {
                KapcsNyit();
                KapcsZar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        private void KapcsZar()
        {
            if (_connection.State != System.Data.ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        private void KapcsNyit()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }

        internal List<Futar> GetAllFutar()
        {
            List<Futar> futars = new List<Futar>();
            _command.CommandText = "SELECT * FROM futar GROUP BY futar.fnev ORDER BY futar.fazon ASC;";
            KapcsNyit();
            using (MySqlDataReader dr = _command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Futar futar = new Futar(dr.GetInt32("fazon"), dr.GetString("fnev"), dr.GetString("ftel"));
                    futars.Add(futar);
                }
            }
            return futars;
        }
        public void Modosit(string tel, string nev)
        {
            
            _command.CommandText = "UPDATE `futar` SET `ftel`= @tel WHERE `fnev` = @nev";
            _command.Parameters.Clear();
            _command.Parameters.AddWithValue("@tel", tel);
            _command.Parameters.AddWithValue("@nev", nev);
            KapcsNyit();
            _command.ExecuteNonQuery();
            MessageBox.Show("Sikeres módosítás", "Hozzáadva", MessageBoxButtons.OK, MessageBoxIcon.Information);
            KapcsZar();
            
        }
    }
}