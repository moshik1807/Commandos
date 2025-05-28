using System;
namespace comando
{
    public class Game
    {
        public static void creating()
        {
            for (int i = 0;i < 5;i++)
            {
                EnemyFactory.CreatEnemy("armed");
                EnemyFactory.CreatEnemy("unarmed");
                SoldiersFactory.CreatCommandos("commando");
                SoldiersFactory.CreatCommandos("seaCommando");
                SoldiersFactory.CreatCommandos("airCommando");
                WeaponFactory.CreatWeapon("m16");
                WeaponFactory.CreatWeapon("ak47");

            }
        }
    }
}
