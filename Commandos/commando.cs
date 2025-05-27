using System;
namespace comando
{
    public class Commando
    {
        public string Name;
        public string NameCode;
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
    }
}

