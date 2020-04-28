using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class ClientDataAcess
    {
        readonly MySqlConnection conn = new MySqlConnection("Server=localhost;Database=SERVICECLIENT;Uid=root;Pwd=1234;");
        public DataTable ReturnData()
        {
           
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM CLIENT", conn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public void InsertData(string name, string phone, string adress)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO CLIENT VALUES(NULL," +
                $"'{name.ToUpper()}'," +
                $"'{phone.ToUpper()}'," +
                $"'{adress.ToUpper()}')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void RemoveData(int id)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM CLIENT WHERE ID = {id}", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateData(int id, string name, string phone, string adress)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"UPDATE CLIENT SET NAME = '{name.ToUpper()}'," +
                $"PHONE = '{phone.ToUpper()}'," +
                $"ADRESS = '{adress.ToUpper()}' WHERE ID = {id}", conn);

            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }

   
}
