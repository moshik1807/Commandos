using System;
namespace comando
{
    public class SoldiersFactory
    {
        public static Random rnd = new Random();
        public static List<string> tools = new List<string> { "Hammer", "chisel", "rope", "bag", "water bottle" };
        public static List<string> statuses = new List<string> { "Walking", "hiding", "attacking" };
        public static List<string> nams = new List<string> { "moshe", "david", "roni", "shlomo", "emanuel" };
        public static List<string> typs = new List<string> { "commando", "seaCommando", "airCommando" };

        public static List<Commando> Enemies = new List<Commando>();
        public static void CreatCommandos()
        {
            for (int i = 0;i < 5;i++)
            {
                string name = nams[rnd.Next(0, nams.Count-1)];
                string type = typs[rnd.Next( 0, typs.Count-1)];
                string nameCode = "x";
                string status = statuses[rnd.Next(0, statuses.Count-1)];
                switch (type)
                {
                    case "commando":
                        Enemies.Add(new Commando(name, nameCode, tools,status));
                        break;
                    case "seaCommando":
                        Enemies.Add(new SeaCommando(name, nameCode, tools, status));
                        break;
                    case "airCommando":
                        Enemies.Add(new AirCommando(name, nameCode, tools, status));
                        break;
                    default:
                        break;
                }
            }
        }


    }

}
