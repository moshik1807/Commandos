using System;
using System.Xml.Linq;
namespace comando
{
    public class AirCommando: Commando
    {
        public AirCommando(string Name, string NameCode, string[] Tools, string Stetus):base(string name, string nameCode, string[] tools, string status)
        {
        }
        public void parachuting()
        {
            Console.WriteLine("The soldier falls");
        }
    }

}
