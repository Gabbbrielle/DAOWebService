using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace DAOWebService
{
    public class Connections
    {
        public Connections()
        {

        }
        public static void InsertUser(Users p)
        {

            Connections c = new Connections();
            SqlConnection conn;
            SqlCommand cmd;

            string connectionString = "Data Source=DESKTOP-5BJVM3V;Initial Catalog=TP2;Integrated Security=True";

            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertUser";
            cmd.Parameters.Add(new SqlParameter("@nom", p.Nom));
            cmd.Parameters.Add(new SqlParameter("@annee", p.Annee));
            cmd.Parameters.Add(new SqlParameter("@resultat", p.Resulat));
            cmd.Parameters.Add(new SqlParameter("@machine", p.Machine));
            cmd.Parameters.Add(new SqlParameter("@ip", p.Ip));
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
        }

        public static List<Users> AllUsers()
        {            
                List<Users> UserList = new List<Users>();
                Connections c = new Connections();
                SqlConnection conn;
                SqlCommand cmd;
                SqlDataReader reader;
                string connectionString = "Data Source=DESKTOP-5BJVM3V;Initial Catalog=TP2;Integrated Security=True";
                conn = new SqlConnection(connectionString);
                cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUserList";
                cmd.Connection = conn;
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Users p = new Users();
                    p.Id = reader.GetInt32(0);
                    p.Nom = reader.GetString(1);
                    p.Annee = reader.GetInt32(2);
                    p.Resulat = reader.GetString(3);
                    p.Machine = reader.GetString(4);
                    p.Ip = reader.GetString(5);
                    p.Date = reader.GetDateTime(6);

                    UserList.Add(p);
                }
                return UserList;
            
        }

        
    }
}