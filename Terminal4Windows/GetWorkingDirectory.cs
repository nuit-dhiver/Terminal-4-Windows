using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Terminal4Windows
{
    class GetWorkingDirectory
    {
        public static void SetCurrentDirectory2Home()
        {
            Directory.SetCurrentDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
        }

        public static string GetRootDirectory(string CurrentDirectory)
        {
            string RootDirectory = Directory.GetDirectoryRoot(CurrentDirectory);
            return RootDirectory;
        }

        public static void ChangeDirectory(string CurrentDirectory)
        {
            Console.Write("pleas enter new directory: ");
            string Directory2Change = Console.ReadLine();
            switch (Directory2Change)
            {
                case "./..":
                    Directory.SetCurrentDirectory(Directory.GetParent(CurrentDirectory).ToString());
                    break;

                case "./../..":
                    Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetParent(CurrentDirectory).ToString()).ToString());
                    break;
                case "./../../..":
                    Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetParent(Directory.GetParent(CurrentDirectory).ToString()).ToString()).ToString());
                    break;
                case "./../../../..":
                    Directory.SetCurrentDirectory(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(CurrentDirectory).ToString()).ToString()).ToString()).ToString());
                    break;
                case "root":
                    Directory.SetCurrentDirectory(Directory.GetDirectoryRoot(CurrentDirectory));
                    break;
                case "~":
                    Directory.SetCurrentDirectory(Directory.GetParent(CurrentDirectory).ToString());
                    break;
                default:
                    if (CheckRelative(Directory2Change))
                        Directory2Change = Directory.GetCurrentDirectory() + Directory2Change;
                    if (Directory.Exists(Directory2Change))
                        Directory.SetCurrentDirectory(Directory2Change);
                    else
                        Console.WriteLine("sorry the directory you entered is not existed.");
                    break;
            }

        }

        public static bool CheckRelative(string Path)
        {
            if (Path.Contains(@":\"))
                return false;
            else
                return true;
        }
    }
}