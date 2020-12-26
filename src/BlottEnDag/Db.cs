using System;
using MySql.Data.MySqlClient;

namespace BlottEnDag
{
    static public class Db
    {
        static public void Save(DbModel model, string connectionString)
        {
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
            {
                Console.WriteLine("Open Database");
                
                conn.Open();
                
                var sql = $"INSERT INTO oneday (theDate, score, answers, deleted) VALUES ('{model.theDate}', {model.score}, '{model.answers}', {model.deleted});";
                MySqlScript script = new MySqlScript(conn, sql);
                script.Execute();

                Console.WriteLine("Saving Success");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR {ex.ToString()}");
            }

            conn.Close();
            Console.WriteLine("Closing Database");
        }
    }
}
