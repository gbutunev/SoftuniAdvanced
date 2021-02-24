using System;
using System.Collections.Generic;
using System.Linq;

namespace E3_7_TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            //hs1 = followers
            //hs2 = following
            Dictionary<string, HashSet<string>[]> vloggers = new Dictionary<string, HashSet<string>[]>();

            string cmd = Console.ReadLine();
            while (cmd != "Statistics")
            {
                if (cmd.Contains("joined"))
                {
                    string name = cmd.Split()[0];
                    if (!vloggers.ContainsKey(name))
                    {
                        vloggers.Add(name, new HashSet<string>[] { new HashSet<string>(), new HashSet<string>() });
                    }
                }
                else if (cmd.Contains("followed"))
                {
                    string[] people = cmd.Split();
                    string p1 = people[0]; //follower
                    string p2 = people[2]; //following

                    if (vloggers.ContainsKey(p1) && vloggers.ContainsKey(p2) && p1 != p2)
                    {
                        vloggers[p1][1].Add(p2);
                        vloggers[p2][0].Add(p1);
                    }
                }
                cmd = Console.ReadLine();
            }

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");
            var top = vloggers.OrderByDescending(x => x.Value[0].Count).ThenBy(x => x.Value[1].Count).First();

            Console.WriteLine($"1. {top.Key} : {top.Value[0].Count} followers, {top.Value[1].Count} following");
            top.Value[0].OrderBy(x => x).ToList().ForEach(x => Console.WriteLine($"*  {x}"));
            int num = 2;
            vloggers
                .OrderByDescending(x => x.Value[0].Count)
                .ThenBy(x => x.Value[1].Count)
                .Skip(1)
                .ToList()
                .ForEach(x => Console.WriteLine($"{num++}. {x.Key} : {x.Value[0].Count} followers, {x.Value[1].Count} following"));
        }
    }
}
