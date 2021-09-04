using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace KeepNote
{
    class Menu
    {
        private int selectedIndex;
        private string[] options;
        private string prompt;
        public Menu(string prompt, string[] options)
        {
            this.prompt = prompt;
            this.options = options;
            selectedIndex = 0;
        }

        #region DisplayOptions
        public void DisplayOptions()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.WriteLine("\t\t\t\t\t\t" + prompt + "\n");
            //options = new string[] { "Danh Mục", "Thông tin cá nhân", "Thoát" };
            for (int i = 0; i < options.Length; i++)
            {
                string currentOption = options[i];
                string prefix;
                if (i == selectedIndex)
                {
                    prefix = "► ";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = "  ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($"\t\t\t\t\t\t{prefix}{currentOption}");
            }
            Console.ResetColor();
        }                    
        #endregion           

        #region Run
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayOptions();
                //ExitMenu();
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex == options.Length)
                    {
                        selectedIndex = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex;
        }
        #endregion
    }
}
