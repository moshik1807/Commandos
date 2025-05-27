using System;
namespace comando
{
    public class Commando
    {
        private string Name;
        public string NameCode { get; set; }
        public List<string> tools;
        public string Status;
        public Commando(string name,string nameCode, List<string> tools,string status)
        {
            Name = name;
            NameCode = nameCode;
            this.tools = tools;
            Status = status;
        }
        public void Walk()
        {
            Console.WriteLine("The soldier goes");
            Status = "goes";
        }
        public void Hide()
        {
            Console.WriteLine("The soldier is hiding.");
            Status = "hiding";
        }
        public virtual void Attack()
        {
            Console.WriteLine($"The commando soldier {NameCode} went on the attack");
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

