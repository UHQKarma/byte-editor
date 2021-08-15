using Byte_Editor.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Config.Config.readConfig();
            Login.Auth.login();

        }
        public static void PrintLogo()
        {
            Colorful.Console.Write("██████╗░██╗░░░██╗████████╗███████╗  ███████╗██████╗░██╗████████╗░█████╗░██████╗░\n", Color.Purple);
            Colorful.Console.Write("██╔══██╗╚██╗░██╔╝╚══██╔══╝██╔════╝  ██╔════╝██╔══██╗██║╚══██╔══╝██╔══██╗██╔══██╗\n", Color.Purple);
            Colorful.Console.Write("██████╦╝░╚████╔╝░░░░██║░░░█████╗░░  █████╗░░██║░░██║██║░░░██║░░░██║░░██║██████╔╝\n", Color.Purple);
            Colorful.Console.Write("██╔══██╗░░╚██╔╝░░░░░██║░░░██╔══╝░░  ██╔══╝░░██║░░██║██║░░░██║░░░██║░░██║██╔══██╗\n", Color.Purple);
            Colorful.Console.Write("██████╦╝░░░██║░░░░░░██║░░░███████╗  ███████╗██████╔╝██║░░░██║░░░╚█████╔╝██║░░██║\n", Color.Purple);
            Colorful.Console.Write("╚═════╝░░░░╚═╝░░░░░░╚═╝░░░╚══════╝  ╚══════╝╚═════╝░╚═╝░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝\n\n", Color.Purple);
            Console.WriteLine("| Made With Love By Rachel#1337\n\n", Color.Purple);
        }
    }
}
