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
                Console.WriteLine("Saving ...");
                
                conn.Open();
                
                // var sql = $"INSERT INTO oneday (theDate, score, answers, deleted) VALUES ('{model.theDate}', {model.score}, '{model.answers}', {model.deleted});";
                // MySqlScript script = new MySqlScript(conn, sql);
                // script.Execute();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR {ex.ToString()}");
            }

            conn.Close();
            Console.WriteLine("Saving done.");
        }
    }
}
