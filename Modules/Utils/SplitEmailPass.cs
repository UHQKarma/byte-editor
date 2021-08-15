using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.Modules.Utils
{
    class SplitEmailPass
    {
        public static List<string> Users = new List<string>();
        public static List<string> Passwords = new List<string>();

        public static string[] lines = File.ReadAllLines(Config.Config.fileName);
        public static string folderName;

        public static void edit()
        {
            Passwords.Clear();
            Users.Clear();
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.Purple);
            Colorful.Console.Write("Split Email and Pass", Color.White);
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

                    Users.Add(user);
                    Passwords.Add(pass);
                }
            }

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Done Editing! What do u want the foldername to be: ", Color.White);
            folderName = Console.ReadLine();


            string[] result = Passwords.ToArray();
            string path = "Results/" + folderName + "/";
            Directory.CreateDirectory(path);

            using (TextWriter writer = new StreamWriter(path + "Passwords.txt"))
            {
                foreach (string text in result)
                {
                    writer.WriteLine(text);
                }
            }

            result = Users.ToArray();
            using (TextWriter writer = new StreamWriter(path + "Users.txt"))
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
