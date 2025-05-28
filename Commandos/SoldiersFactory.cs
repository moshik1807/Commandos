using System;
namespace comando
{
    public class SoldiersFactory
    {
        public static Random rnd = new Random();
        public static List<string> tools = new List<string> { "Hammer", "chisel", "rope", "bag", "water bottle" };
        public static List<string> statuses = new List<string> { "Walking", "hiding", "attacking" };
        public static List<string> nams = new List<string> { "moshe", "david", "roni", "shlomo", "emanuel" };

        public static List<Commando> Commandos = new List<Commando>();
        public static void CreatCommandos(string type)
        {
                string name = nams[rnd.Next(0, nams.Count-1)];
                string nameCode = "x";
                string status = statuses[rnd.Next(0, statuses.Count-1)];
                switch (type)
                {
                    case "commando":
                        Commandos.Add(new Commando(name, nameCode, tools,status));
                        break;
                    case "seaCommando":
                        Commandos.Add(new SeaCommando(name, nameCode, tools, status));
                        break;
                    case "airCommando":
                        Commandos.Add(new AirCommando(name, nameCode, tools, status));
                        break;
                    default:
                        break;
                }
        }
    }
}
