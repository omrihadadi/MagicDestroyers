using System;

namespace MagicDestroyers.Equipment.Armors
{
    public abstract class Armor 
    {
        
        private int armorPoints;
        
        public virtual int ArmorPoints
         {
            get
            {
                return this.armorPoints;

            } 
            set
            {
                if ( value >= 0 )
                {
                    this.armorPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(String.Empty, "Armor Points value should be a positive number");
                }
            } 
        }
    }
}