using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Terminal4Windows
{
    class FileAndDirectory
    {
        public static void CreateDirectory()
        {
            Console.Write("pleas enter directory:");
            string Directory2Create = Console.ReadLine();
            if (GetWorkingDirectory.CheckRelative(Directory2Create))
                Directory2Create = Directory.GetCurrentDirectory() + Directory2Create;
            if (Directory.Exists(Directory2Create))
            {
                Console.WriteLine("sorry, this directory is already existed");
                Program.GeneralTask();
            }
            else
            {
                Directory.CreateDirectory(Directory2Create);
                Console.WriteLine(Directory2Create + "is succesfully created");
            }
        }
        public static void CreateFile()
        {
            Console.Write("pleas enter file name: ");
            string File2Create = Console.ReadLine();
            if (GetWorkingDirectory.CheckRelative(File2Create))
                File2Create = Directory.GetCurrentDirectory() + File2Create;
            if (File.Exists(File2Create))
            {
                Console.WriteLine("sorry this file is already existed.");
                Program.GeneralTask();
            }
            else
            {
                File.Create(File2Create);
                Console.WriteLine(File2Create + " is succesfuly created.");
            }
        }
        public static void DeleteFile()
        {
            Console.Write("pleas enter file name with directory:");
            string FilePath2Delete = Console.ReadLine();
            if (GetWorkingDirectory.CheckRelative(FilePath2Delete))
                FilePath2Delete = Directory.GetCurrentDirectory() + FilePath2Delete;
            if (File.Exists(FilePath2Delete))
            {
                File.Delete(FilePath2Delete);
                Console.WriteLine("the file has succesfuly deleted.");
            }
            else
            {
                Console.WriteLine("the file you entered is not existed");
                Program.GeneralTask();
            }
        }
        public static void DeleteDirectory()
        {
            Console.Write("pleas enter directory:");
            string Directory2Delete = Console.ReadLine();
            if (GetWorkingDirectory.CheckRelative(Directory2Delete))
                Directory2Delete = Directory.GetCurrentDirectory() + Directory2Delete;
            if (Directory.Exists(Directory2Delete))
            {
                string[] CheckSubDirectories = Directory.GetDirectories(Directory2Delete);
                string[] CheckSubFiles = Directory.GetFiles(Directory2Delete);
                bool k = true, l = true;
                foreach(var i in CheckSubDirectories)
                {
                    k = false;
                }
                foreach(var j in CheckSubFiles)
                {
                    l = false;
                }
                if (k && l)
                {
                    Directory.Delete(Directory2Delete);
                    Console.WriteLine("this directory deleted succesfuly.");
                }
                else
                {
                    Console.WriteLine("this directory is not empty and can't be deleted.");
                    Program.GeneralTask();
                }
            }
            else
            {
                Console.WriteLine("this directory is not existed");
                Program.GeneralTask();
                
            }
        }
        public static void List()
        {
                string[] SubDirectories = Directory.GetDirectories(Directory.GetCurrentDirectory());
                string[] SubFiles = Directory.GetFiles(Directory.GetCurrentDirectory());
                int i = 0,j = 0;
            Console.ForegroundColor = ConsoleColor.Blue;
                foreach (var k in SubDirectories) {
                    Console.WriteLine(SubDirectories[i]);
                    i++;
                }
            Console.ForegroundColor = ConsoleColor.Cyan;
                foreach (var l in SubFiles) {
                    Console.WriteLine(SubFiles[j]);
                    j++;
                }
            Console.ResetColor();
            
            }

        public static void Copy()
        {
            Console.Write("please enter file Path:");
            string File2Copy = Console.ReadLine();
            if (GetWorkingDirectory.CheckRelative(File2Copy))
                File2Copy = Directory.GetCurrentDirectory() + File2Copy;
            if (File.Exists(File2Copy))
            {
                Console.Write("please enter destanation Path");
                string Path2Copy = Console.ReadLine();
                if (GetWorkingDirectory.CheckRelative(Path2Copy))
                    Path2Copy = Directory.GetCurrentDirectory() + Path2Copy;
                if (File.Exists(Path2Copy))
                {
                    Console.WriteLine("There is already a file with this name in the destenation path.");
                    Program.GeneralTask();
                }
                else
                {
                    File.Copy(File2Copy, Path2Copy);
                }
                
            }
            else
            {
                Console.WriteLine("The source path you entered is incorrect.");
                Program.GeneralTask();
            }
        }
        public static void Move()
        {
            Console.Write("please enter file path:");
            string File2Move = Console.ReadLine();
            if (GetWorkingDirectory.CheckRelative(File2Move))
                File2Move = Directory.GetCurrentDirectory() + File2Move;
            if (File.Exists(File2Move))
            {
                Console.Write("pleas enter destenation path:");
                string Path2Move = Console.ReadLine();
                if (GetWorkingDirectory.CheckRelative(Path2Move))
                    Path2Move = Directory.GetCurrentDirectory() + Path2Move;
                if (File.Exists(Path2Move))
                {
                    Console.WriteLine("there is already a file with this name in the path you entered.");
                    Program.GeneralTask();
                }
                else
                {
                    File.Move(File2Move, Path2Move);
                }
            }
            else
            {
                Console.WriteLine("The source path you entered is incorrect.");
                Program.GeneralTask();
            }
        }
        }
    }

