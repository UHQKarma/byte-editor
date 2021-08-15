using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Byte_Editor.Config
{
    class Config
    {
        public static string fileName;
        public static string keepOld;
        public static string autoShuffle;
        public static void readConfig()
        {
            using(StreamReader sr = new StreamReader("configuration\\Config.json"))
            {
                string json = sr.ReadToEnd();

                fileName = Parse(json, "\"Combo\": \"", "\",");
                keepOld = Parse(json, "\"Keep_Old_Lines\": ", ",");
                autoShuffle = Parse(json, "\"Auto_Shuffle\": ", ",");
            }
        }

        private static string Parse(string source, string left, string right)
        {
            return source.Split(new string[1] { left }, StringSplitOptions.None)[1].Split(new string[1]
            {
                right
            }, StringSplitOptions.None)[0];
        }
    }
}
