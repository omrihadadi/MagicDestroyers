using MagicDestroyers.Enums;
using MagicDestroyers.Interfaces;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters
 {
     public abstract class Character : IAttacking , IDefending
     {
        private Faction faction;

        private int healthPoints;
        private int level;
        private int scores;

        private Armor bodyArmor;
        private Weapon weapon;
        
        private bool isAlive;

        private string name; 

        public Armor BodyArmor
        { 
        get
        {
        return this.bodyArmor;
        }  
        set
        {
        this.bodyArmor = value;
        }
        }
        public Weapon Weapon
        { 
        get
        {
        return this.weapon;
        } 
        set
        {
        this.weapon = value;
        }
        }
        public Faction  Faction 
    { 
        get
        {
            return this.faction;
        } 
        set
        {
            this.faction = value;
        }
    }   
        public int Level 
    { 
        get
            {
                return this.level;
            }

            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, level should always be positive.");
                }
            }
    }
        public string Name 
    { 
         get
            {
                return this.name;
            }

            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException(string.Empty, "Inappropriate length of name, name should be between 3 and 12 characters.");
                }
            }
    }
        public virtual int HealthPoints
    { 
        get
            {
                return this.healthPoints;
            }

            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
    }
        public bool IsAlive
        { 
            get
            {
                return this.isAlive;
            }
             protected set
            {
                this.isAlive = value;
            } 
        }
        public int Scores 
        { 
            get
            {
            return this.scores;
            } 
             set
            {
                this.scores = value;
            } 
        }
        
        public virtual void Move (int steps)
                                            {
                                                for (int i=0; i < steps; i++)
                                                {
                                                    System.Console.WriteLine($@"{this.Name} just moved the {i} step");
                                                    Thread.Sleep(500);
                                                }
                                            }

        public abstract int Attack();
        public abstract int SpecialAttack();
        public abstract int Defend();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!", type);
            }
        }

        public void WonBattle()
        {
            this.scores++;

            if (this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }                                         
}
