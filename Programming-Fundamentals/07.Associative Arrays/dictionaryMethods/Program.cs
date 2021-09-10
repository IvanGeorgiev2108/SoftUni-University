using System;
using System.Collections.Generic;

namespace dictionaryMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyValuePair<string, int> pair = new KeyValuePair<string, int>("key",55);
            Console.WriteLine(pair.Key);
            Console.WriteLine(pair.Value);


            SortedDictionary<string, int> humanWeights = new SortedDictionary<string, int>();

            humanWeights.Add("Goshko", 130);
            humanWeights.Add("Abi", 130);
            humanWeights.Add("Bebi", 130);
            if (!humanWeights.ContainsKey("Goshko"))
                humanWeights.Add("Goshko", 23);
            else
                humanWeights["Goshko"] = 23;

            humanWeights.Add("Pepi", 68);
            
            foreach (var item in humanWeights)
            {
                Console.WriteLine($"Person: {item.Key} \n Weight: {item.Value}");
            }
        }
    }
}
