using System;
using System.Xml.Linq;
namespace comando
{
    public class AirCommando: Commando
    {
        public AirCommando(string name, string nameCode, List<string> tools, string status):base( name,  nameCode,  tools,  status)
        {
        }
        public void parachuting()
        {
            Console.WriteLine("The soldier falls");
        }
        public override void Attack()
        {
            Console.WriteLine($"Air Commando Soldier {NameCode} went on the attack"); ;
        }
    }

}
