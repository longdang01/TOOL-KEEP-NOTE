using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Reflection.Metadata;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace KeepNote
{
    class Program
    {
        #region mainMenu
        public static void mainMenu()
        {
            string prompt = "(^.^)! Welcome to MiniApp";
            string[] options = new string[] { "Categories", "Portfolio", "Open", "Exit" };
            Menu runMainMenu = new Menu(prompt, options);
            bool end = false;

            while (!end)
            {
                int selectedIndex = runMainMenu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        categoriesMenu();
                        break;
                    case 1:
                        portfolioMenu();
                        break;
                    case 2:
                        openMenu();
                        break;
                    case 3:
                        exitMenu();
                        break;
                }
            }
        }
        #endregion

        #region categoriesMenu temporarily not used
        //public static void categoriesMenu()
        //{
        //    string prompt = "Categories Files";
        //    string[] options = new string[] {"Create", "Read And Update", "Delete", "Back"};
        //    Menu runCategoriesMenu = new Menu(prompt, options);
        //    bool end = false;
        //    while (!end)
        //    {
        //        int selectedIndex = runCategoriesMenu.Run();
        //        switch (selectedIndex)
        //        {
        //            case 0:
        //                break;
        //            case 1:
        //                readMenu();
        //                break;
        //            case 2:
        //                break;
        //            case 3:
        //                end = true;
        //                break;
        //        }
        //    }
        //}
        #endregion

        #region categoriesMenu
        public static void categoriesMenu()
        {
            string prompt = "Categories Files";
            string[] options = new string[] { "Education", "Technology", "Business", "Websites", "Tricks", "Back" };
            Menu runReadMenu = new Menu(prompt, options);
            bool end = false;
            while (!end)
            {
                int selectedIndex = runReadMenu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        Process.Start("notepad.exe", @"E:\Dang Hoang Long\CategoriesMiniApp\Education.txt");
                        break;
                    case 1:
                        Process.Start("notepad.exe", @"E:\Dang Hoang Long\CategoriesMiniApp\Technology.txt");
                        break;
                    case 2:
                        Process.Start("notepad.exe", @"E:\Dang Hoang Long\CategoriesMiniApp\Business.txt");
                        break;
                    case 3:
                        Process.Start("notepad.exe", @"E:\Dang Hoang Long\CategoriesMiniApp\Websites.txt");
                        break;
                    case 4:
                        Process.Start("notepad.exe", @"E:\Dang Hoang Long\CategoriesMiniApp\Tricks.txt");
                        break;
                    case 5:
                        end = true;
                        break;
                }
            }
        }
        #endregion

        #region Open
        public static void openMenu()
        {
            string prompt = ">> Open";
            string[] options = new string[] { "Edge", "Chrome", "Dang Hoang Long<Folder>", "Nodepad++", "Back" };
            Menu runExitMenu = new Menu(prompt, options);
            bool end = false;
            while (!end)
            {
                int selectedIndex = runExitMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        Process.Start(@"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe");
                        break;
                    case 1:
                        Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                        break;
                    case 2:
                        Process.Start("explorer.exe", @"E:\Dang Hoang Long");
                        break;
                    case 3:
                        Process.Start(@"C:\Program Files\Notepad++\notepad++.exe");
                        break;
                    case 4:
                        end = true;
                        break;
                }
            }
        }
        #endregion

        #region portfolioMenu
        public static void portfolioMenu()
        {
            string prompt = ">> Resume";
            string[] options = new string[] { "Profile", "Facebook", "Youtube", "Instagram", "Back" };
            Menu runPortfolioMenu = new Menu(prompt, options);
            bool end = false;
            while (!end)
            {
                int selectedIndex = runPortfolioMenu.Run();
                switch (selectedIndex)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\t         << Profile >>       ");
                        Console.WriteLine("\t\t\t\t\tName       : Dang Hoang Long ");
                        Console.WriteLine("\t\t\t\t\tDateOfBirth: 24/07/2001      ");
                        Console.WriteLine("\t\t\t\t\tPhone      : 0971603963      ");
                        Console.WriteLine("\t\t\t\t\tGender     : Male            ");
                        Console.WriteLine("\t\t\t\t\tJob        : Student         ");
                        Console.WriteLine("\t\t\t\t\tAddress    : Yen My, Hung Yen");
                        Console.WriteLine("\t\t\t\t\tHobbies    : Music, Movies, FootBall, ...");
                        Console.WriteLine("\t\t\t\t\tMuốn biết gì thì hỏi trực tiếp nhé ^^!");
                        Console.ReadKey();
                        break;
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\tFacebook: Long Dang <https://www.facebook.com/longdang24/>");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\tYoutube: Long Dang <bit.ly/longdang01>");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("\n\n\n\n\n\n\n\n");
                        Console.WriteLine("\t\t\t\t\tInstagram: ld_2d01");
                        Console.ReadKey();
                        break;
                    case 4:
                        end = true;
                        break;
                }
            }
        }
        #endregion

        #region exitMenu
        public static void exitMenu()
        {
            string prompt = "Are you sure to exit the application?";
            string[] options = new string[] { "Yes", "No" };
            Menu runExitMenu = new Menu(prompt, options);
            int selectedIndex = runExitMenu.Run();
            switch (selectedIndex)
            {
                case 0:
                    System.Environment.Exit(0);
                    break;
                    //case 1:
                    //    //end = true;
                    //    break;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            //KeepNote Application
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {

                Console.WriteLine("\n\n\n\n\n\n\n");
                Console.Write("\t\t\t\t\t\tUsername: ");
                string username = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\t\t\t\t\t\tPassword: ");
                string pass = "";
                ConsoleKey key;
                do
                {
                    var keyInfo = Console.ReadKey(true);
                    key = keyInfo.Key;
                    if (key == ConsoleKey.Backspace && pass.Length > 0)
                    {
                        Console.Write("\b \b");
                        //pass = pass[0..^1];
                        pass = pass.Substring(0, (pass.Length - 1));
                    }
                    else if (!char.IsControl(keyInfo.KeyChar))
                    {
                        Console.Write("*");
                        pass += keyInfo.KeyChar;
                    }
                } while (key != ConsoleKey.Enter);
                if (username == "long" && pass == "240701") { 
                    mainMenu();
                }
                else
                    Console.WriteLine("\n\n\t\t\t\tCho chủ app 10k ăn sáng rồi tính tiếp!"); 
                    Console.WriteLine("\t\t\t\tOK nhé(Nhấn enter để đồng ý)!");
                    Console.ReadKey(); 
                    Console.WriteLine("\t\t\t\tEnter xong rồi thì gặp chủ app đưa 10k thôi!");
                    Console.ReadKey();
                    Console.Clear();
            }
        }
    }
}
