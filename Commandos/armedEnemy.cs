using System;
namespace comando
{
    public class ArmedEnemy:Enemy
    {
        public ArmedEnemy(string name):base(name)
        {
        }
        public void identification()
        {
            Console.WriteLine("I am an armed enemy");
        }
    }
}

