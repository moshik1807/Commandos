using comando;
using System;
namespace comando
{
    public class EnemyFactory
    {
        public static Random rnd = new Random();
        public static List<Enemy> Enemies = new List<Enemy>();
        public static List<string> namesList = new List<string> { "Ahmed","nOmar","nKhalid","nHassan","nNasser","nAli","nMohammed","nSamir","nBilal","nKarim"};
        public static void CreatEnemy(string type)
        {
            switch (type)
            {
                case "armed":
                    Enemies.Add(new ArmedEnemy(namesList[rnd.Next(0,namesList.Count-1)]));
                    break;
                case "unarmed":
                    Enemies.Add(new Enemy(namesList[rnd.Next(0, namesList.Count - 1)]));
                    break;
                default:
                    break;
            }
        }
    }
}
