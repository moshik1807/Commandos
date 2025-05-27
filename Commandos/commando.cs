using System;
namespace comando
{
    public class Commando
    {
        private string Name;
        public string NameCode { get; set; }
        public string[] Tools;
        public string Stetus;
        public Commando(string name,string nameCode, string[] tools,string status)
        {
            Name = name;
            NameCode = nameCode;
            Tools = tools;
            Stetus = status;
        }
        public void Walk()
        {
            Console.WriteLine("The soldier goes");
            Stetus = "goes";
        }
        public void Hide()
        {
            Console.WriteLine("The soldier is hiding.");
            Stetus = "hiding";
        }
        public void Attack()
        {
            Console.WriteLine($"{NameCode} went on the attack");
        }
        public void SayName(string commanderRank)
        {
            if (commanderRank == "general")
            {
                Console.WriteLine(Name);
            }
            else if (commanderRank == "colonel")
            {
                Console.WriteLine(NameCode);
            }
            else
            {
                Console.WriteLine("Unable to provide information");
            }
        }
        
    }
}

