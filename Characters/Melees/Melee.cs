using MagicDestroyers.Characters;

namespace MagicDestroyers.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;

        public int AbilityPoints 
    {
           get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 10.");
                }
            }
    }
        public override int HealthPoints
         {
             get => base.HealthPoints;
             set
             {
                if ( value >= 0 && value <= 150)
                {
                    base.HealthPoints = value;
                }
                else
                {
                 throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 150.");
                }
                
             }
             

             
         }

        public override void Move(int steps)
        {
            for (int i=0; i < steps; i++)
            {
                System.Console.WriteLine($@"I am a Melee Character, my name is {this.Name} and I just moves the {i} step");
                Thread.Sleep(500);
            }
        }

    }
    
}