using System;
namespace comando
{
    public class Enemy
    {
        string Name;
        int Life;
        bool Status;

        public Enemy(string name)
        {
            Name = name;
            Life = 100;
            Status = true;
        }
        public void identification()
        {
            Console.WriteLine("I am an enemy");
        }
    }

}
