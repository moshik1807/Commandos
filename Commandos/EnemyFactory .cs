using comando;
using System;
namespace comando
{
    public class EnemyFactory
    {
        public static List<Enemy> Enemies = new List<Enemy>();

        public static void CreatEnemy(string name,string type)
        {
            switch (type)
            {
                case "ARMED":
                    Enemies.Add(new ArmedEnemy(name));
                    break;
                case "UNARMED":
                    Enemies.Add(new Enemy(name));
                    break;
                default:
                    break;
            }
        }
    }
}
