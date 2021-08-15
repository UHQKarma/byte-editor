using AuthGG;
using Byte_Editor.UI;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows;

namespace Byte_Editor.Login
{
    class Auth
    {
        public static void login()
        {
            Console.Title = "Byte_Editor Auth";
            OnProgramStart.Initialize("Byte Editor", "921262", "8Q7yEuecxiu8SjW2Z7qE5pLQI4rEsSQw8lF", "1.0");
            if (ApplicationSettings.Freemode)
            {
                
            }
            if (!ApplicationSettings.Status)
            {
                Process.GetCurrentProcess().Kill(); // closes the application
            }
            if (File.Exists("LoginDetails.xml"))
            {
                string[] lines = File.ReadAllLines("LoginDetails.XML");
                foreach (string line in lines)
                {
                    string user = line.Split(new string[]
                    {
                            ":"
                    }, StringSplitOptions.None)[0];
                    string pass = line.Split(new string[]
                    {
                            ":"
                    }, StringSplitOptions.None)[1];
                    if (API.Login(user, pass))
                    {
                        Home.home();
                    }
                    else
                    {
                    }

                }
            }
            else
            {
                Program.PrintLogo();
                Colorful.Console.Write("  (", Color.White);
                Colorful.Console.Write("1", Color.Purple);
                Colorful.Console.Write(") Login\n", Color.White);

                Colorful.Console.Write("  (", Color.White);
                Colorful.Console.Write("2", Color.Purple);
                Colorful.Console.Write(") Register\n", Color.White);
                Colorful.Console.Write("   > ", Color.Purple);
                string option = Console.ReadLine();
                if (option == "1")
                {
                    if (!ApplicationSettings.Login)
                    {
                       Process.GetCurrentProcess().Kill(); //closes the application
                    }
                    else if (File.Exists("LoginDetails.xml"))
                    {
                        string[] lines = File.ReadAllLines("LoginDetails.XML");
                        foreach (string line in lines)
                        {
                            string user = line.Split(new string[]
                            {
                            ":"
                            }, StringSplitOptions.None)[0];
                            string pass = line.Split(new string[]
                            {
                            ":"
                            }, StringSplitOptions.None)[1];
                            if (API.Login(user, pass))
                            {
                                Home.home();
                            }
                            else
                            {
                                
                            }

                        }
                    }
                    else
                    {
                        Console.Clear();
                        Program.PrintLogo();
                        Colorful.Console.Write("  [ ", Color.Purple);
                        Colorful.Console.Write("Login");
                        Colorful.Console.Write(" ]\n\n", Color.Purple);
                        Colorful.Console.Write("  (", Color.White);
                        Colorful.Console.Write("+", Color.Purple);
                        Colorful.Console.Write(") Username: ", Color.White);
                        string username = Console.ReadLine();
                        Colorful.Console.Write("\n  (", Color.White);
                        Colorful.Console.Write("+", Color.Purple);
                        Colorful.Console.Write(") Password: ", Color.White);
                        string password = Console.ReadLine();
                        if (API.Login(username, password))
                        {
                            using (TextWriter sw = new StreamWriter("LoginDetails.xml"))
                            {
                                sw.WriteLine(username + ":" + password);
                            }
                            Home.home();
                        }
                    }
                }
                else if (option == "2")
                {
                    if (!ApplicationSettings.Register)
                    {
                        Process.GetCurrentProcess().Kill();
                    }
                    else
                    {
                        Console.Clear();
                        Program.PrintLogo();
                        Colorful.Console.Write("  [ ", Color.Purple);
                        Colorful.Console.Write("Register");
                        Colorful.Console.Write(" ]\n\n", Color.Purple);
                        Colorful.Console.Write("  (", Color.White);
                        Colorful.Console.Write("+", Color.Purple);
                        Colorful.Console.Write(") Username: ", Color.White);
                        string username = Console.ReadLine();
                        Colorful.Console.Write("\n  (", Color.White);
                        Colorful.Console.Write("+", Color.Purple);
                        Colorful.Console.Write(") Password: ", Color.White);
                        string password = Console.ReadLine();
                        Colorful.Console.Write("\n  (", Color.White);
                        Colorful.Console.Write("+", Color.Purple);
                        Colorful.Console.Write(") Email: ", Color.White);
                        string email = Console.ReadLine();
                        Colorful.Console.Write("\n  (", Color.White);
                        Colorful.Console.Write("+", Color.Purple);
                        Colorful.Console.Write(") License: ", Color.White);
                        string license = Console.ReadLine();
                        if (API.Register(username, password, email, license))
                        {
                            using (TextWriter sw = new StreamWriter("LoginDetails.xml"))
                            {
                                sw.WriteLine(username + ":" + password);
                            }
                            Home.home();
                        }
                    }
                }
            }
        }
    }
}
