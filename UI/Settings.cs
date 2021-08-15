using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.UI
{
    class Settings
    {
        public static void settings()
        {
            Console.Clear();
            Program.PrintLogo();
            Colorful.Console.Write("  [ ", Color.Purple);
            Colorful.Console.Write("Current Settings", Color.White);
            Colorful.Console.Write(" ]\n\n", Color.Purple);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") File Name: " + Config.Config.fileName + "\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Auto Shuffle: " + Config.Config.autoShuffle + "\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("+", Color.Purple);
            Colorful.Console.Write(") Keep Old Lines: " + Config.Config.keepOld + "\n\n", Color.White);

            Colorful.Console.Write("   > ", Color.Purple);
            Colorful.Console.Write("Press any button to go back to the main menu", Color.White);
            Console.ReadKey();
            Home.home();
        }
    }
}
