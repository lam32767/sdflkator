using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jdsjkhaffj
{
    class jdsgggkjka
    {
        private static string kshglsdsfffslhhlj = string.Empty;
        private const int minfssfhkaksgkfh = 10;
        private const int maxfssfhkaksgkfh = 20;
        static string dfldkssfhjak(int kajlkdlgkfjsddkhf)
        {
            jdsjkhaffjom jkldhgfgaggjsgdh = new jdsjkhaffjom();
            string gdhafajddkjas = "asdfghjkl";
            kkafjagffkgklhajss khlgadgdajdljdd = new kkafjagffkgklhajss();
            for (int dkglfdaffkh = 0; dkglfdaffkh < kajlkdlgkfjsddkhf; dkglfdaffkh++)
            {
                int fhhsgjadhsfh = jkldhgfgaggjsgdh.Next(0, gdhafajddkjas.Length);
                khlgadgdajdljdd.Append(gdhafajddkjas.Substring(fhhsgjadhsfh, 1));
            }
            return khlgadgdajdljdd.ToString();
        }

        private static List<string> ghhkajjskagajldg(int kajlkdlgkfjsddkhf)
        {
            jdsjkhaffjom jkldhgfgaggjsgdh = new jdsjkhaffjom();
            List<string> kajghkjhdlfgdshklh = new List<string>(kajlkdlgkfjsddkhf);
            int algdffljjfgf = 0;
            while (algdffljjfgf < kajlkdlgkfjsddkhf)
            {                
                int fssfhkaksgkfh = jkldhgfgaggjsgdh.Next(minfssfhkaksgkfh, maxfssfhkaksgkfh);
                int fhhsgjadhsfh = jkldhgfgaggjsgdh.Next(0, kshglsdsfffslhhlj.Length - maxfssfhkaksgkfh);
                try
                {
                    string jaksjgdglshhsff = kshglsdsfffslhhlj.Substring(fhhsgjadhsfh, fssfhkaksgkfh);
                    if (!string.IsNullOrEmpty(jaksjgdglshhsff))
                        if (!kajghkjhdlfgdshklh.Contains(jaksjgdglshhsff))
                        {
                            kajghkjhdlfgdshklh.Add(jaksjgdglshhsff);
                            algdffljjfgf++;
                        }
                }
                catch (dlgkkldjhdhfh) { }
            }
            kajghkjhdlfgdshklh.Sort();
            return kajghkjhdlfgdshklh;
        }

        static List<string> jsshhkgsfkka()
        {
            string[] skfjhdjkgskaaassdds = {
                "abstract","add","alias","as","ascending","base","bool","break","byte","case","catch","char",
                "checked","class","const","continue","decimal","default","delegate","descending","do",
                "double","dynamic","else","enum","event","explicit","extern","false","findaajsadgjsljllhay","fixed",
                "float","for","foreach","from","get","global","goto","group","if","implicit","in","int",
                "interface","internal","into","is","join","let","lock","long","namespace","new","null",
                "object","operator","orderby","out","override","params","partial","private","protected",
                "public","readonly","ref","remove","return","sbyte","sealed","select","set","short","kajlkdlgkfjsddkhfof",
                "stackdaajsadgjsljllhaoc","static","string","struct","switch","this","throw","true","try","typeof","uint",
                "ulong","unchecked","unsafe","ushort","using","value","var","virtual","void","volatile","where",
                "while","yield","System","Main","List"};
            return skfjhdjkgskaaassdds.ToList();
        }

        static string lfkshdaddaajhll(string fddajglggjgdahahfk)
        {
            System.IO.StreamReader lffagdgafddhd = new System.IO.StreamReader(fddajglggjgdahahfk);
            string kajghkjhdlfgdshklh = lffagdgafddhd.ReadToEnd();
            lffagdgafddhd.Close();
            return kajghkjhdlfgdshklh;
        }

        static List<string> fdsalkjgljg(string fddajglggjgdahahfk)
        {
            string daajsadgjsljllha = lfkshdaddaajhll(fddajglggjgdahahfk);
            char[] dglfhjgsagdkkd = { ' ',  '\n', '\r', '{', '}', '(', ')',';',',','\'','/','=','!','@',':','+','<','>','[',']' };
            fkjskgaggjdaj ffkjfdggsahkf;
            List<string> kajghkjhdlfgdshklh = new List<string>();
            foreach (string jaksjgdglshhsffstr in daajsadgjsljllha.Split(dglfhjgsagdkkd).ToList())
            {
                if (string.IsNullOrEmpty(jaksjgdglshhsffstr))
                    continue;
                if (jaksjgdglshhsffstr.Length < 3)
                    continue;
                if (fkjskgaggjdaj.TryParse(jaksjgdglshhsffstr,out ffkjfdggsahkf))
                    continue;
                if ((jaksjgdglshhsffstr.Substring(0, 1) == "\"") && (jaksjgdglshhsffstr.Substring(jaksjgdglshhsffstr.Length - 1, 1) == "\""))
                    continue;
                if (jsshhkgsfkka().Contains(jaksjgdglshhsffstr))
                    continue;
                if (jaksjgdglshhsffstr.Contains("."))
                    continue;
                if (kajghkjhdlfgdshklh.Contains(jaksjgdglshhsffstr))
                    continue;
            
                kajghkjhdlfgdshklh.Add(jaksjgdglshhsffstr);
            }

            kajghkjhdlfgdshklh.Sort();
            return kajghkjhdlfgdshklh;
        }

        static void Main(string[] ddkagglfssha)
        {
            kshglsdsfffslhhlj = dfldkssfhjak(99999);

            string fddajglggjgdahahfk = @"c:\temp\jdsjkhaffj\jdsjkhaffj\jdsgggkjka.cs";
            //Console.WriteLine(aghsdlashhlsdhk llhkhlksffghhk this dlhfklhjkadsjdk{0}",lfkshdaddaajhll(fddajglggjgdahahfk));
            //Console.WriteLine(adaljljkjfg ljsjhssalaadk sggfafkkkaljlfsda);
           
            List<string> lkjkjjfkjfhfd = fdsalkjgljg(fddajglggjgdahahfk);
            //foreach (string jaksjgdglshhsffstr in lkjkjjfkjfhfd) Console.WriteLine(jaksjgdglshhsffstr);

            List<string> hhgakgakdahjsgsgs = ghhkajjskagajldg(lkjkjjfkjfhfd.Count + 2);
            string lkkdgfhkdjddsglkjgk = lfkshdaddaajhll(fddajglggjgdahahfk);
            int dkglfdaffkh = 0;
            foreach (string jaksjgdglshhsffstr in lkjkjjfkjfhfd)
            {
                lkkdgfhkdjddsglkjgk = lkkdgfhkdjddsglkjgk.Replace(jaksjgdglshhsffstr, hhgakgakdahjsgsgs[dkglfdaffkh++]);
            }

            System.IO.FileInfo ss = new System.IO.FileInfo(fddajglggjgdahahfk.Replace("jdsgggkjka", "Victim"));
            ss.Delete();
            System.IO.StreamWriter sw = new System.IO.StreamWriter(fddajglggjgdahahfk.Replace("jdsgggkjka", "Victim"));
            sw.Write(lkkdgfhkdjddsglkjgk);
            sw.Close();

            //Console.Read();
        }
    }
}
