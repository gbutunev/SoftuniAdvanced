using System;
using System.Collections.Generic;
using E3_7_MilitaryElite.Models;

namespace E3_7_MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, ISoldier> soldiers = new Dictionary<string, ISoldier>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] parts = input.Split();
                string type = parts[0];
                string id = parts[1];
                string fname = parts[2];
                string lname = parts[3];
                decimal salary;
                switch (type)
                {
                    case nameof(Private):
                        salary = decimal.Parse(parts[4]);
                        soldiers[id] = new Private(id, fname, lname, salary);
                        break;
                    case nameof(LieutenantGeneral):
                        salary = decimal.Parse(parts[4]);
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, fname, lname, salary);
                        for (int i = 5; i < parts.Length; i++)
                        {
                            string privateId = parts[i];
                            if (soldiers.ContainsKey(privateId))
                            {
                                lieutenantGeneral.AddPrivate((IPrivate)soldiers[privateId]);
                            }
                        }

                        soldiers[id] = lieutenantGeneral;
                        break;
                    case nameof(Engineer):
                        salary = decimal.Parse(parts[4]);
                        if (!Enum.TryParse(parts[5], out Corps corps))
                        {
                            break;
                        }

                        Engineer engineer = new Engineer(id, fname, lname, salary, corps);
                        for (int i = 6; i < parts.Length; i+=2)
                        {
                            string part = parts[i];
                            int hours = int.Parse(parts[i + 1]);
                            engineer.AddRepair(new Repair(part, hours));
                        }
                        soldiers[id] = engineer;
                        break;
                    case nameof(Commando):
                        salary = decimal.Parse(parts[4]);
                        if (!Enum.TryParse(parts[5], out Corps corps1))
                        {
                            break;
                        }
                        Commando commando = new Commando(id, fname, lname, salary, corps1);
                        for (int i = 6; i < parts.Length; i += 2)
                        {
                            string codeName = parts[i];
                            string state = parts[i + 1];

                            if (!Enum.TryParse(state, out State state1))
                            {
                                continue;
                            }

                            Mission mission = new Mission(codeName, state1);
                            commando.AddMission(mission);
                        }
                        soldiers[id] = commando;
                        break;
                    case nameof(Spy):
                        int codeNum = int.Parse(parts[4]);
                        Spy spy = new Spy(id, fname, lname, codeNum);
                        soldiers[id] = spy;
                        break;
                }
                input = Console.ReadLine();
            }

            foreach (var item in soldiers.Values)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
