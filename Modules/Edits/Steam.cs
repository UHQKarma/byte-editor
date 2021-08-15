using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.Modules.Edits
{
    class Steam
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
            Colorful.Console.Write("Steam", Color.White);
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
                string user = line.Split(new string[] {
                        ":"
                    }, StringSplitOptions.None)[0];
                string password = line.Split(new string[]
                {
                        ":"
                }, StringSplitOptions.None)[1];

                int length = password.Length;

                if (length > 0)
                {
                    if (Config.Config.keepOld.Contains("true"))
                    {
                        Combo.Add(user + ":" + password);
                    }


                    if (!password.EndsWith("1"))
                    {
                        Combo.Add(user + ":" + password + "1");
                    }
                    if (!password.EndsWith("123"))
                    {
                        Combo.Add(user + ":" + password + "123");
                    }
                    if (!password.EndsWith("69"))
                    {
                        Combo.Add(user + ":" + password + "69");
                    }
                    Combo.Add(user + ":" + password + "lol");
                    Combo.Add(user + ":" + password + "!");
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
