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
                query.CommandText = "SELECT * FROM Contact WHERE $t LIKE '%$v%' OR $t LIKE '%v' OR $t LIKE 'v%' OR $t = $v";
                query.Parameters.AddWithValue("$t", com[1]);
                query.Parameters.AddWithValue("$v", com[2]);
                using (var reader = query.ExecuteReader())
                {
                    System.Console.WriteLine("|   First Name   |   Last Name   |   Phone   |");
                    while (reader.Read())
                    {
                        var phone = reader.GetInt32(0);
                        var firstname = reader.GetString(0);
                        var lastname = reader.GetString(1);
                        System.Console.WriteLine($"|   {firstname}   |   {lastname}   |   {phone}   |");
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.ToString());
                Console.ResetColor();
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
                        var phone = reader.GetInt32(0);
                        var firstname = reader.GetString(0);
                        var lastname = reader.GetString(1);
                        System.Console.WriteLine($"|   {firstname}   |   {lastname}   |   {phone}   |");
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine(e.ToString());
                Console.ResetColor();
            }
        }
    }
}