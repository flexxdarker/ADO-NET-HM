using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserClass
{
    public class GuestManager
    {
        private SqlConnection connection = null;

        public GuestManager(string? connectionStr = null)
        {
            connectionStr = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;";
            connection = new SqlConnection(connectionStr);
            connection.Open();
        }
        public IEnumerable<Guests> GetAllGuests()
        {
            string cmdText = "select * from Guests";
            SqlCommand command = new SqlCommand(cmdText, connection);
            using var reader = command.ExecuteReader();
            List<Guests> items = new List<Guests>();
            while (reader.Read())
            {
                items.Add(new Guests()
                {
                    Id = (int)reader["Id"],
                    Login = (string)reader["Login"],
                    Password = (string)reader["Password"],
                    Phone = (int)reader["Phone"],
                    Adress = (string)reader["Adress"],
                    RoleId = (int)reader["RoleId"]
                });
            }

            return items;
        }
        public IEnumerable<Guests> GetAdmins()
        {
            string cmdText = "select * from Guests where RoleId = 1";
            SqlCommand command = new SqlCommand( cmdText, connection);
            using var reader = command.ExecuteReader();
            List<Guests> items = new List<Guests>();
            while(reader.Read())
            {
                items.Add(new Guests()
                {
                    Id = (int)reader["Id"],
                    Login = (string)reader["Login"],
                    Password = (string)reader["Password"],
                    Phone = (int)reader["Phone"],
                    Adress = (string)reader["Adress"],
                    RoleId = (int)reader["RoleId"]
                });
            }
            return items;
        }
    }
}
