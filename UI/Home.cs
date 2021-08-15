using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.UI
{
    class Home
    {
        public static void home()
        {
            Console.Clear();
            Colorful.Console.Title = "Byte Editor Home Menu";
            Program.PrintLogo();
            Colorful.Console.Write("  [ ", Color.White);
            Colorful.Console.Write("Menu", Color.Purple);
            Colorful.Console.Write(" ]\n\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("1", Color.Purple);
            Colorful.Console.Write(") Modules\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("2", Color.Purple);
            Colorful.Console.Write(") Settings\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("3", Color.Purple);
            Colorful.Console.Write(") Exit\n", Color.White);
            Colorful.Console.Write("   > ", Color.Purple);

            string input = Console.ReadLine();
            if(input == "1")
            {
                Modules.modules();
            }else if(input == "2")
            {
                Settings.settings();
            }else if(input == "3")
            {
                //Exit
                Environment.Exit(0);
            }
            else
            {
                Home.home();
            }

        }
    }
}
