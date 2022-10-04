using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
                Dictionary<int, string> dic = new Dictionary<int, string>();
                dic.Add(48, "my rabbit");
                dic.Add(20, "my pig");
                dic.Add(18, "my pony");

                Console.WriteLine(dic[48]);

                for (int i = 0; i < dic.Count; i++)
                {
                    Console.WriteLine(dic[i]);
                }
                foreach(KeyValuePair<int, string> kvp in dic)
            {
                Console.WriteLine(kvp.Key);
            }

                Console.ReadKey();
        }
    }
}
