using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Byte_Editor.Modules.Utils
{
    class SplitCombo
    {
        public static int fileNameCounter;
        public static int lineCounter;
        public static List<string> Combo = new List<string>();

        public static string amount;
        public static string folderName;

        public static int lastCounter;
        public static void edit()
        {
            string[] lines = File.ReadAllLines(Config.Config.fileName);

            Combo.Clear();
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.Purple);
            Colorful.Console.Write("Split Combo", Color.White);
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
            Colorful.Console.Write(") How many lines do u want per file: \n\n", Color.White);
            amount = Console.ReadLine();

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") What do u want the folder name to be: \n\n", Color.White);
            folderName = Console.ReadLine();

            string path = "Results/" + folderName + "/";
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach(string file in files)
                {
                    File.Delete(file);
                }
            }
            else
            {
                Directory.CreateDirectory(path);
            }

            foreach(string line in lines)
            {
                lineCounter++;
                Combo.Add(line);
                if(int.Parse(amount) == lineCounter)
                {
                    File.WriteAllLines(path + "Combo_Part_" + fileNameCounter + ".txt", Combo);
                    fileNameCounter++;
                    lineCounter = 0;
                    lastCounter++;
                    Combo.Clear();
                }
            }
            File.WriteAllLines(path + "Combo_Part_" + lastCounter + 1 + ".txt", Combo);
            fileNameCounter = 0;
            lastCounter = 0;

            Colorful.Console.Write("\n  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Done Saving! Press enter to go back to the main menu.", Color.White);
            Console.ReadLine();
            UI.Modules.modules();
        }
    }
}
