using System;
using Microsoft.Data.Sqlite;

namespace My_Contac_Manager_Min.Core
{
    class QueryMethods
    {
        SqliteConnection connection;
        public QueryMethods(SqliteConnection conn)
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
        public void Search(string[] com)
        {
            try
            {
                var query = connection.CreateCommand();
                query.Connection = connection;
                switch (com[1])
                {
                    case "firstname":
                        query.CommandText = "SELECT * FROM Contact WHERE FirstName = $val";
                        break;
                    case "lastnamr":
                        query.CommandText = "SELECT * FROM Contact WHERE LastName = $val";
                        break;
                    case "phone":
                        query.CommandText = "SELECT * FROM Contact WHERE Phone = $val";
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        System.Console.WriteLine("Wat ?! ...");
                        Console.ResetColor();
                        CoreMethods.ChoiseMethod();
                        break;

                }
                query.Parameters.AddWithValue("$val", com[2]);
                using (var reader = query.ExecuteReader())
                {
                    System.Console.WriteLine("|   First Name   |   Last Name   |   Phone   |");
                    while (reader.Read())
                    {
                        System.Console.WriteLine($"|   {reader[0]}   |   {reader[1]}   |   {reader[2]}   |");
                    }
                }
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
        public void Show()
        {
            try
            {
                var query = connection.CreateCommand();
                query.Connection = connection;
                query.CommandText = "SELECT * FROM Contact";
                using (var reader = query.ExecuteReader())
                {
                    System.Console.WriteLine("|   First Name   |   Last Name   |   Phone   |");
                    while (reader.Read())
                    {
                        System.Console.WriteLine($"|   {reader[0]}   |   {reader[1]}   |   {reader[2]}   |");
                    }
                }
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