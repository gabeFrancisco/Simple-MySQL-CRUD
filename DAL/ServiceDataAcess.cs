using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public class ServiceDataAcess
    {
        readonly MySqlConnection conn = new MySqlConnection("Server=localhost;Database=SERVICECLIENT;Uid=root;Pwd=1234;");
        public DataTable ReturnTable()
        {
            conn.Open();
            DataTable dt = new DataTable();
            MySqlDataAdapter adp = new MySqlDataAdapter("SELECT * FROM SERVICE", conn);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(adp);
            adp.Fill(dt);
            conn.Close();
            return dt;
        }

        public void InsertService(string client, string title, string desc)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO SERVICE VALUES(NULL," +
                $"'{title}'," +
                $"'{desc}'," +
                $"'{client}')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void DeleteItem(int index)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM SERVICE WHERE IDSERVICE = {index}", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateData(int id, string client, string title, string desc)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand($"UPDATE SERVICE SET TITLE = '{title}'," +
                $"SERVICEDESC = '{desc}'," +
                $"CLIENTNAME = '{client}' WHERE IDSERVICE = {id}", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
