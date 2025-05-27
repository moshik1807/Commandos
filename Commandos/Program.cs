namespace comando
{
    class Program
    {
        static void Main(string[] args)
        {
            Commando x = new Commando("moshe", "x1x1", ["Hammer", "chisel", "rope", "bag", "water bottle"], "walk");
            x.SayName("general");
        }
    }
}