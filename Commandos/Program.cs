namespace comando
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tools =new List<string> {"Hammer", "chisel", "rope", "bag", "water bottle"};
            Commando X = new Commando("moshe", "x1x1",tools, "walk");
            SeaCommando Y = new SeaCommando("david", "2y2y",tools, "hiding");
            AirCommando V = new AirCommando("yosef", "v3v3",tools, "walk");
            Commando[] soldiers = [X,Y,V];
            foreach (var solder in soldiers)
            {
                solder.Attack();
            }
        }
    }
}