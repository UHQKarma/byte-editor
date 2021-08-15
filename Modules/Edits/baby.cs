using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Byte_Editor.Modules.Edits
{
    class baby
    {
        public static string FirstCharToUpper(string input)
        {
            string result;
            try
            {
                result = input.First<char>().ToString().ToUpper() + input.Substring(1);
            }
            catch
            {
                result = input;
            }
            return result;
        }

        public static List<string> Combo = new List<string>();
        public static string[] lines = File.ReadAllLines(Config.Config.fileName);
        public static string folderName;

        public static void edit()
        {
            Combo.Clear();
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.Purple);
            Colorful.Console.Write("Ultra", Color.White);
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

            foreach (string line in lines)
            {
                if (line.Contains(":"))
                {
                    string user = line.Split(new string[]
                    {
                        ":"
                    }, StringSplitOptions.None)[0];
                    string pass = line.Split(new string[]
                    {
                        ":"
                    }, StringSplitOptions.None)[1];

                    int length = pass.Length;
                    if (length > 0)
                    {
                        char c = pass[length - 1];
                        Match match = Regex.Match(pass, "(.{1})\\s*$");
                        bool flag3 = c.ToString().All(new Func<char, bool>(char.IsLetter));
                        if (flag3)
                        {
                            Combo.Add(user + ":" + FirstCharToUpper(pass) + "!");
                        }



                    }
                }

                Colorful.Console.Write("  (", Color.White);
                Colorful.Console.Write("+", Color.Purple);
                Colorful.Console.Write(") Done Editing! What do u want the foldername to be: ", Color.White);
                folderName = Console.ReadLine();

                Random r = new Random();
                string[] result;
                if (Config.Config.autoShuffle == "true")
                {
                    result = Combo.OrderBy(x => r.Next()).ToArray();
                }
                else
                {
                    result = Combo.ToArray();
                }
                string path = "Results/" + folderName + "/";
                Directory.CreateDirectory(path);
                using (TextWriter sw = new StreamWriter(path + "Combo.txt"))
                {
                    foreach (string line1 in result)
                    {
                        sw.WriteLine(line1);
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
}
