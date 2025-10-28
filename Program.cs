using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rand
{
    class Program
    {
        private static string the_sdf = string.Empty;
        private const int minlen = 10;
        private const int maxlen = 20;
        static string build_thesdf(int size)
        {
            Random randomizer = new Random();
            string letters = "asdfghjkl";
            StringBuilder string_builder = new StringBuilder();
            for (int counter = 0; counter < size; counter++)
            {
                int idx = randomizer.Next(0, letters.Length);
                string_builder.Append(letters.Substring(idx, 1));
            }
            return string_builder.ToString();
        }

        private static List<string> make_words(int size)
        {
            Random randomizer = new Random();
            List<string> retval = new List<string>(size);
            int added = 0;
            while (added < size)
            {                
                int len = randomizer.Next(minlen, maxlen);
                int idx = randomizer.Next(0, the_sdf.Length - maxlen);
                try
                {
                    string one = the_sdf.Substring(idx, len);
                    if (!string.IsNullOrEmpty(one))
                        if (!retval.Contains(one))
                        {
                            retval.Add(one);
                            added++;
                        }
                }
                catch (Exception) { }
            }
            retval.Sort();
            return retval;
        }

        static List<string> reserved_words()
        {
            string[] wrds = {
                "abstract","add","alias","as","ascending","base","bool","break","byte","case","catch","char",
                "checked","class","const","continue","decimal","default","delegate","descending","do",
                "double","dynamic","else","enum","event","explicit","extern","false","finally","fixed",
                "float","for","foreach","from","get","global","goto","group","if","implicit","in","int",
                "interface","internal","into","is","join","let","lock","long","namespace","new","null",
                "object","operator","orderby","out","override","params","partial","private","protected",
                "public","readonly","ref","remove","return","sbyte","sealed","select","set","short","sizeof",
                "stackalloc","static","string","struct","switch","this","throw","true","try","typeof","uint",
                "ulong","unchecked","unsafe","ushort","using","value","var","virtual","void","volatile","where",
                "while","yield","System","Main","List"};
            return wrds.ToList();
        }

        static string thefile(string filename)
        {
            System.IO.StreamReader the_streamreader = new System.IO.StreamReader(filename);
            string retval = the_streamreader.ReadToEnd();
            the_streamreader.Close();
            return retval;
        }

        static List<string> get_toks(string filename)
        {
            string all = thefile(filename);
            char[] chars = { ' ',  '\n', '\r', '{', '}', '(', ')',';',',','\'','/','=','!','@',':','+','<','>','[',']' };
            Int64 i64;
            List<string> retval = new List<string>();
            foreach (string onestr in all.Split(chars).ToList())
            {
                if (string.IsNullOrEmpty(onestr))
                    continue;
                if (onestr.Length < 3)
                    continue;
                if (Int64.TryParse(onestr,out i64))
                    continue;
                if ((onestr.Substring(0, 1) == "\"") && (onestr.Substring(onestr.Length - 1, 1) == "\""))
                    continue;
                if (reserved_words().Contains(onestr))
                    continue;
                if (onestr.Contains("."))
                    continue;
                if (retval.Contains(onestr))
                    continue;
            
                retval.Add(onestr);
            }

            retval.Sort();
            return retval;
        }

        static void Main(string[] args)
        {
            the_sdf = build_thesdf(99999);

            string filename = @"c:\temp\Rand\Rand\Program.cs";
            //Console.WriteLine("Start with this file\n{0}",thefile(filename));
            //Console.WriteLine("Get these words");
           
            List<string> tokens = get_toks(filename);
            //foreach (string onestr in tokens) Console.WriteLine(onestr);

            List<string> new_words = make_words(tokens.Count + 2);
            string victim = thefile(filename);
            int counter = 0;
            foreach (string onestr in tokens)
            {
                victim = victim.Replace(onestr, new_words[counter++]);
            }

            System.IO.FileInfo ss = new System.IO.FileInfo(filename.Replace("Program", "Victim"));
            ss.Delete();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(filename.Replace("Program", "Victim"));
            sw.Write(victim);
            sw.Close();

            //Console.Read();
        }
    }
}
