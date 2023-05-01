using System;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers.Enums;

namespace MagicDestroyers.Characters.Spellcasters
{

    public class Mage : SpellCaster
    {
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        private readonly Staff DEFAULT_WEAPON = new Staff();

        public Mage()
            : this(Consts.Mage.NAME, 1)
        {
        }

        public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTH_POINTS)
        {
        }

        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.Weapon = DEFAULT_WEAPON;
            base.Faction = Faction.Spellcasters;
            base.IsAlive = true;
            base.Scores = 0;
        }

        public int Fireball()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }

        public override int Defend()
        {
            return this.Meditation();
        }
    }
}