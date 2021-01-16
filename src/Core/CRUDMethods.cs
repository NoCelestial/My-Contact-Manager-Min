using System;
using Microsoft.Data.Sqlite;

namespace My_Contac_Manager_Min.Core
{
    class CRUDMethods
    {
        SqliteConnection connection;
        public CRUDMethods(SqliteConnection conn)
        {
            try
            {
                connection = conn;
                connection.Open();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.ToString());
                Console.ResetColor();
            }
        }

        public void Create(string[] com)
        {
            try
            {
                var query = connection.CreateCommand();
                query.Connection = connection;
                query.CommandText = "INSERT INTO Contact (FirstName,LastName,Phone) VALUES($fn,$ln,$p);";
                query.Parameters.AddWithValue("$fn", com[1]);
                query.Parameters.AddWithValue("$ln", com[2]);
                query.Parameters.AddWithValue("$p", int.Parse(com[3]));
                query.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Success !!");
                Console.ResetColor();
                CoreMethods.ChoiseMethod();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.ToString());
                Console.ResetColor();
                CoreMethods.ChoiseMethod();
            }
        }
        public void Edit(string[] com )
        {
            try
            {
                var query = connection.CreateCommand();
                query.Connection = connection;
                query.CommandText = "UPDATE Contact SET FirstName = $fn , LastName = $ln WHERE Phone = $p;";
                query.Parameters.AddWithValue("$fn", com[2]);
                query.Parameters.AddWithValue("$ln", com[3]);
                query.Parameters.AddWithValue("$p", int.Parse(com[1]));
                query.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Success !!");
                Console.ResetColor();
                CoreMethods.ChoiseMethod();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.ToString());
                Console.ResetColor();
                CoreMethods.ChoiseMethod();
            }
        }
        public void Remove(string[] com)
        {
            try
            {
                var query = connection.CreateCommand();
                query.Connection = connection;
                query.CommandText = "DELETE FROM Contact WHERE Phone = $p;";
                query.Parameters.AddWithValue("$p", int.Parse(com[1]));
                query.ExecuteNonQuery();
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine("Success !!");
                Console.ResetColor();
                CoreMethods.ChoiseMethod();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.ToString());
                Console.ResetColor();
                CoreMethods.ChoiseMethod();
            }
        }
    }
}