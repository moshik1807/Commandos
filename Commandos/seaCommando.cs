using System;
using System.Xml.Linq;
namespace comando
{
    public class SeaCommando: Commando
    {
        public SeaCommando(string name, string nameCode, List<string> tools, string status) : base( name, nameCode,  tools,  status)
        {
        }
        public void swimming()
        {
            Console.WriteLine("The soldier swims");
        }
        public override void Attack()
        {
            Console.WriteLine($"Marine commando soldier {NameCode} went on the attack");
        }
    }
   

}
