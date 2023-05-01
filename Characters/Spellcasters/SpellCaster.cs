using System;

namespace MagicDestroyers.Characters.Spellcasters
{
    public abstract class SpellCaster : Character
    {
        private int manaPoints;
        
        public int ManaPoints
    {
          get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
                }
            }
    }

        public override void Move(int steps)
        {
            for (int i=0; i < steps; i++)
            {
                System.Console.WriteLine($@"I am a Spellcaster Character, my name is {this.Name} and I just moves the {i} step");
                Thread.Sleep(500);
            }
        }
    }   
}