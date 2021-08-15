using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.Modules.Utils
{
    class EmailSorter
    {
        public static string[] lines = File.ReadAllLines(Config.Config.fileName);
        public static List<string> Combo = new List<string>();

        public static string folderName;
        public static void edit()
        {
            Combo.Clear();
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.Purple);
            Colorful.Console.Write("Email Sorter", Color.White);
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
            Colorful.Console.Write(") What do u want the folder name to be: ", Color.White);
            folderName = Console.ReadLine();
            string path = "Results/" + folderName + "/";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }

            Colorful.Console.Write("\n  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Editing..\n\n", Color.White);

            foreach (string line in lines)
            {
                if (line.Contains(":"))
                {
                    string mail = line.Split(new string[]
                    {
                        ":"
                    }, StringSplitOptions.None)[0];
                    string password = line.Split(new string[]
                    {
                        ":"
                    }, StringSplitOptions.None)[1];

                    string[] domains = File.ReadAllLines("configuration\\Domains.txt");

                    foreach (string domain in domains)
                    {
                        if (mail.Contains(domain))
                        {

                            using (TextWriter sw = new StreamWriter(path + domain + ".txt", true))
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
            }
            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Done Saving! Press enter to go back to the main menu.", Color.White);
            Console.ReadLine();
            UI.Modules.modules();
        }
    }
}
