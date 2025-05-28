using System;
namespace comando
{
    public class WeaponFactory
    {
        public static List<Weapon> weapons = new List<Weapon>();
        public static void CreatWeapon(string type)
        {
            switch (type)
            {
                case "m16":
                    weapons.Add(M16());
                    break;
                case "ak47";
                    weapons.Add(AK47());
            }
        }
    }

}
