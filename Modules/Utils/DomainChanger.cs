﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.Modules.Utils
{
    class DomainChanger
    {
        public static List<string> Combo = new List<string>();
        public static string[] lines = File.ReadAllLines(Config.Config.fileName);
        public static string folderName;

        public static void edit()
        {
            Combo.Clear();
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.Purple);
            Colorful.Console.Write("Domain Changer", Color.White);
            Colorful.Console.Write(" ]\n\n", Color.Purple);

            DateTime time = DateTime.Now;
            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Succesfully loaded: ", Color.White);
            Colorful.Console.Write(lines.Length.ToString(), Color.Purple);
            Colorful.Console.Write(" ~ Took: ", Color.White);
            Colorful.Console.Write(DateTime.Now.Subtract(time).TotalMilliseconds.ToString("#,###") + "ms\n\n", Color.Purple);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Editing..\n\n", Color.White);

            foreach(string line in lines)
            {
                string mail = line.Split(new string[]
                {
                    ":"
                }, StringSplitOptions.None)[0];
                string password = line.Split(new string[] {
                    ":"
                }, StringSplitOptions.None)[1];
                string user = mail.Split(new string[]
                {
                    "@"
                }, StringSplitOptions.None)[1];

                string[] domains = File.ReadAllLines("configuration\\Domains.txt");
                foreach(string domain in domains)
                {
                    Combo.Add(user + domain + ":" + password);
                }
            }
            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Done Editing! What do u want the foldername to be: ", Color.White);
            folderName = Console.ReadLine();


            string[] result = Combo.ToArray();
            string path = "Results/" + folderName + "/";
            Directory.CreateDirectory(path);

            using (TextWriter writer = new StreamWriter(path + "Combo.txt"))
            {
                foreach (string text in result)
                {
                    writer.WriteLine(text);
                }
            }

            Colorful.Console.Write("\n  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Done Saving! Press enter to go back to the main menu.", Color.White);
            Console.ReadLine();
            UI.Modules.modules();
        }
    }
}
