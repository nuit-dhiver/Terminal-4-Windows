using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terminal4Windows
{
    class Help
    {
        public static void helper()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("exutable commands:mkdir,touch,cp,mv,rm,rmdir,ls,uname,ping,help,about.");
            Console.ResetColor();
            Console.Write("please enter the command that you need a help about it:");
            string Command2Help = Console.ReadLine();
            switch (Command2Help)
            {
                case "mkdir":
                    Console.WriteLine("this command create directory with an absolute or relative addrese.\n" + @"example of absolute address: C:\Users\username\Documents"+"\n"+ @"example of an relative address on C:\Users\username: \Documents");
                    break;
                case "touch":
                    Console.WriteLine("this command create a file with and absolute or relative address.\n" + @"example of absolute address: C:\Users\username\Documents\example.txt" + "\n" + @"example of an relative address on C:\Users\username: \Documents\example.txt");
                    break;
                case "help":
                     Console.WriteLine("helps you with commands");
                    break;
                case "rm":
                    Console.WriteLine("this command can remove a file with and absolute or relative address.\n" + @"example of absolute address: C:\Users\username\Documents\example.txt" + "\n" + @"example of an relative address on C:\Users\username: \Documents\example.txt");
                    break;
                case "rmdir":
                    Console.WriteLine("this command can remove folder with an absolute or relative addrese.\n" + @"example of absolute address: C:\Users\username\Documents" + "\n" + @"example of an relative address on C:\Users\username: \Documents");
                    break;
                case "cp":
                    Console.WriteLine("this command can copy files with and absolute or relative address.\n" + @"example of absolute address: C:\Users\username\Documents\example.txt" + "\n" + @"example of an relative address on C:\Users\username: \Documents\example.txt");
                    break;
                case "mv":
                    Console.WriteLine("this command can move files with and absolute or relative address.\n" + @"example of absolute address: C:\Users\username\Documents\example.txt" + "\n" + @"example of an relative address on C:\Users\username: \Documents\example.txt");
                    break;
                case "ping":
                    Console.WriteLine("this command is usful for pinging an ip or a domain name\nexample of correct domain name: www.google.com");
                    break;
                case "uname":
                    Console.WriteLine("this command gives you information about name of machine and windows kernel version");
                    break;
                case "ls":
                    Console.WriteLine("this command list every folders and files in current directory.");
                    break;
                case "about":
                    Console.WriteLine("this command print program version and developer.");
                    break;
                default:
                     Console.WriteLine("there is no command like this!");
                    break;
            }
        }
    }
}
