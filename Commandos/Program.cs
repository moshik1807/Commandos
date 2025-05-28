namespace comando
{
    class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory.CreatEnemy("armed");
            EnemyFactory.Enemies[0].identification();
            SoldiersFactory.CreatCommandos("commando");
            SoldiersFactory.CreatCommandos("seaCommando");
            Console.WriteLine(SoldiersFactory.Commandos[0].NameCode);
            Console.WriteLine(SoldiersFactory.Commandos[1].NameCode);

        }
    }
}