using System;
namespace comando
{
    public class AK47: Weapon,IShootable
    {
        public int NumberOfBalls = 30;
        public AK47():base("ak47", "KALASHNIKOV")
        {
        }
        public void Shoot()
        {
            Console.WriteLine("shot");
            NumberOfBalls--;
        }
    }


}
