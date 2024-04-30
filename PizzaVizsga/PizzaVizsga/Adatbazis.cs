using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if ( _connection.State != System.Data.ConnectionState.Closed)
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
            _command.CommandText = "SELECT futar.fazon,futar.fnev, futar.ftel, SUM(pizza.par * tetel.db) AS ertek FROM futar NATURAL JOIN rendeles NATURAL JOIN tetel NATURAL JOIN pizza GROUP BY futar.fnev;";
            KapcsNyit();
            using (MySqlDataReader dr = _command.ExecuteReader())
            {
                while (dr.Read()) { 
                Futar futar =new Futar(dr.GetInt32("fazon"),dr.GetString("fnev"),dr.GetString("ftel"),dr.GetInt32("ertek"));
                futars.Add(futar);
            }
            }
            return futars;
        }
    }
}
