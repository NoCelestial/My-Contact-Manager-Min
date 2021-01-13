using System;

namespace My_Contac_Manager_Min
{
    static class CoreMethods
    {
        //Help Method For Interduction Methods
        public static void Help()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            System.Console.WriteLine("Welcome To Help Method\n" +
            "1- -help \t\t\tHelp\n" +
            "2- -about \t\t\tAbout Programmer\n" +
            "3- -add <firstname> < lastname > < phone > \t\t\tFor Create Contact\n" +
            "4- -edit <phone> <firstname> <lastname> \t\t\tFor Update Contact\n" +
            "5- -remove <phone> \t\t\t For Delete Contact\n" +
            "6- -show \t\t\tFor Show All Contacts\n" +
            "7- -search <type> <value> \t\t\t For Search Contact\n" +
            "8- -example <command> \t\t\tFor Show Target Command Example \n" +
            "** Phone Number Is Basic ID For Validate Contact You aren't Change This **" +
            "** In Edit If You Want To Edit A Parameter Write In Param <-> Use Example For See This **");
            Console.ResetColor();
        }
        //About Method For Interduction Me
        public static void About()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            System.Console.WriteLine("Im Amir Ali Shokri This Is My Git Hub Profile https://github.com/AmirAliShokri");
            Console.ResetColor();
        }
        //Choise Method For Connect The Command To Methods
        public static void ChoiseMethod()
        {
            System.Console.WriteLine("Enter Method If You Don't Have Any Opinion Write '-help' ");
            string[] com = Console.ReadLine().Split(' ');
            switch (com[0])
            {
                case "-help":
                    break;
                case "-about":
                    break;
                case "-add":
                    break;
                case "-edit":
                    break;
                case "-remove":
                    break;
                case "-show":
                    break;
                case "-search":
                    break;
                case "-example":
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("Thats Not a Command ...");
                    Console.ResetColor();
                    break;
            }
        }
        //Program Start Method
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome To My Contact Manager V 1.0\nFor More Informtion Of Me Write '-about'\nFor Help And Interduction Methods Write '-help' ");
            Console.ResetColor();
        }

        public static void Example(string[] com)
        {
            switch (com[1])
            {
                case "-add":
                    System.Console.WriteLine("-add AmirAli Shokri 1234567890");
                    break;
                case "-edit":
                    System.Console.WriteLine("-edit 1234567890 Amir Shokri");
                    break;
                case "-remove":
                    System.Console.WriteLine("-remove 1234567890");
                    break;
                case "-search":
                    System.Console.WriteLine("-search firstname Ali");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine("I Cant Found This Method");
                    Console.ResetColor();
                    break;
            }
        }
    }
}
