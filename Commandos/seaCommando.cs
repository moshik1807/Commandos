using System;
using System.Xml.Linq;
namespace comando
{
    public class SeaCommando: Commando
    {
        public SeaCommando(string Name, string NameCode, string[] Tools, string Stetus) : base(string name, string nameCode, string[] tools, string status)
        {
        }
        public void swimming()
        {
            Console.WriteLine("The soldier swims");
        }
    }
   

}
