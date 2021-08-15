using Byte_Editor.Modules;
using Byte_Editor.Modules.Edits;
using Byte_Editor.Modules.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.UI
{
    class Modules
    {
        public static void modules()
        {
            Console.Clear();
            Colorful.Console.Title = "Byte_Editor Modules Menu";
            Program.PrintLogo();
            Colorful.Console.Write("  [ ", Color.White);
            Colorful.Console.Write("Modules", Color.Purple);
            Colorful.Console.Write(" ]\n\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("1", Color.Purple);
            Colorful.Console.Write(") Edits\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("2", Color.Purple);
            Colorful.Console.Write(") Utils\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("3", Color.Purple);
            Colorful.Console.Write(") Back\n", Color.White);
            Colorful.Console.Write("   > ", Color.Purple);
            string input = Console.ReadLine();

            if (input == "1")
            {
                Modules.Edits();
            }
            else if (input == "2")
            {
                Modules.Utils();
            }
            else if (input == "3")
            {
                Home.home();
            }
            else
            {
                Modules.modules();
            }

        }

        public static void Edits()
        {
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.White);
            Colorful.Console.Write("Edits", Color.Purple);
            Colorful.Console.Write(" ]\n\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("1", Color.Purple);
            Colorful.Console.Write(") Ultra Edits\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("2", Color.Purple);
            Colorful.Console.Write(") General Edits\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("3", Color.Purple);
            Colorful.Console.Write(") Gaming Edits\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("4", Color.Purple);
            Colorful.Console.Write(") Steam Edits\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("5", Color.Purple);
            Colorful.Console.Write(") Add Suffixes From File\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("6", Color.Purple);
            Colorful.Console.Write(") Baby Edits (just turns all password first case capital and adds ! at end fosent save origional combo)\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("7", Color.Purple);
            Colorful.Console.Write(") Back\n", Color.White);
            Colorful.Console.Write("   > ", Color.Purple);

            string input = Console.ReadLine();
            if (input == "1")
            {
                Ultra.edit();
            }
            else if (input == "2")
            {
                General.edit();
            }
            else if (input == "3")
            {
                Gaming.edit();
            }
            else if (input == "4")
            {
                Steam.edit();
            }
            else if (input == "5")
            {
                SuffixFromFile.edit();
            }
            else if (input == "6")
            {
                baby.edit();
            }
            else if (input == "7")
            {
                Modules.modules();
            }
        }

        public static void Utils()
        {
            Console.Clear();
            Program.PrintLogo();

            Colorful.Console.Write("  [ ", Color.White);
            Colorful.Console.Write("Utils", Color.Purple);
            Colorful.Console.Write(" ]\n\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("1", Color.Purple);
            Colorful.Console.Write(") Remove Duplicates\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("2", Color.Purple);
            Colorful.Console.Write(") Shuffle List\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("3", Color.Purple);
            Colorful.Console.Write(") Sort Lines A to Z\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("4", Color.Purple);
            Colorful.Console.Write(") Remove Empty Lines\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("5", Color.Purple);
            Colorful.Console.Write(") Split Combo (Example: 100k > 50k/50k\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("6", Color.Purple);
            Colorful.Console.Write(") Email:Pass to User:Pass\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("7", Color.Purple);
            Colorful.Console.Write(") User:Pass to Email:Pass\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("8", Color.Purple);
            Colorful.Console.Write(") Capture Remover <Simple Capture Only>\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("9", Color.Purple);
            Colorful.Console.Write(") Email Sorter\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("10", Color.Purple);
            Colorful.Console.Write(") Edu Mail Sorter\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("11", Color.Purple);
            Colorful.Console.Write(") Split Email and Pass in 2 files\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("12", Color.Purple);
            Colorful.Console.Write(") Domain Changer\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("13", Color.Purple);
            Colorful.Console.Write(") Add Custom Domain to User:Pass\n", Color.White);

            Colorful.Console.Write("  (", Color.White);
            Colorful.Console.Write("14", Color.Purple);
            Colorful.Console.Write(") Back\n", Color.White);

            Colorful.Console.Write("   > ", Color.Purple);

            string input = Console.ReadLine();
            if (input == "1")
            {
                RemoveDuplicates.edit();
            }
            else if (input == "2")
            {
                Shuffle.edit();
            }
            else if (input == "3")
            {
                SortAtoZ.edit();
            }
            else if (input == "4")
            {
                RemoveEmpty.edit();
            }
            else if (input == "5")
            {
                SplitCombo.edit();
            }
            else if (input == "6")
            {
                EmailPassToUserPass.edit();
            }
            else if (input == "7")
            {
                UserPassToEmailPass.edit();
            }
            else if (input == "8")
            {
                CaptureRemover.edit();
            }
            else if (input == "9")
            {
                EmailSorter.edit();
            }
            else if (input == "10")
            {
                EduMailSorter.edit();
            }
            else if (input == "11")
            {
                SplitEmailPass.edit();
            }
            else if (input == "12")
            {
                DomainChanger.edit();
            }
            else if (input == "13")
            {
                AddCustomDomain.edit();
            }
            else if (input == "14")
            {
                Modules.modules();
            }
        }


    }
}
