using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;


namespace lab_1_Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>()
                    {
                        {2, 17 },
                        {6,28 },
                        {4,9 },
                        {1,3 }
                    };
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> el in dict)
            {
                int k = el.Key;
                int v = el.Value;
                dict2.Add(k + v, v);
            }
            
            string json = JsonConvert.SerializeObject(dict2);
            Console.WriteLine(json);

        }
    }
}
