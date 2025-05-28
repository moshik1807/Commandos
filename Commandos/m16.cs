using System;
namespace comando
{
    public class M16: Weapon,IShootable
    {
        public int NumberOfBalls = 29;
        public M16():base("m16", "COLT")
        {
        }
        public void Shoot()
        {
            Console.WriteLine("shot");
            NumberOfBalls --;
        }

    }
}
