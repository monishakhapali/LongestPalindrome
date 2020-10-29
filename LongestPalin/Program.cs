using System;
using System.Collections.Generic;

namespace LongestPalin
{
    class Program
    {
        static Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s = "babad";
           
            int max = 0;
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 1; j <= s.Length - i; j++)
                {
                    string p = s.Substring(i, j);
                    if (p.Length > 1)
                    {
                        checkpalin(p);
                    }
                }
            }
            
            if(keyValuePairs.Count!=0)
            {
                foreach(var d in keyValuePairs)
                {
                    if(d.Value > max)
                    {
                        max = d.Value;
                        res = d.Key.ToString();
                    }
                }
            }
            Console.WriteLine(res);
            Console.ReadLine();
        }
        static void checkpalin(string s)
        {
            string res = "";
            
            for(int i=s.Length-1;i>=0;i--)
            {
                res += s[i].ToString();
            }
            if(s==res)
            {
                if (!keyValuePairs.ContainsKey(s))
                {
                    keyValuePairs.Add(s, s.Length);
                }
            }
        }
    }
}
