using System;
namespace comando
{
    public class Ston
    {
        string Name;
        double Weight;
        string Color;
        bool Status;
        int ResistantTo;
        int BlowsGiven;

        public Ston(double weight, string color)
        {
            Name = "ston";
            Weight = weight;
            Color = color;
            Status = true;
            ResistantTo = 5;
            BlowsGiven = 5;
        }
    }

}

