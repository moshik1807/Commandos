using System;
namespace comando
{
    public class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int NumberOfBalls;
        public Weapon(string name,string manufacturer,int numberOfBalls)
        {
            Name = name;
            Manufacturer = manufacturer;
            NumberOfBalls = numberOfBalls;
        }
        public void Shoot()
        {
            Console.WriteLine("shot");
            NumberOfBalls -= 1;
        }
    }
}

