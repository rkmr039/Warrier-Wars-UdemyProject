﻿using WarriorWars.Enum;

namespace WarriorWars.Equipments
{
    internal class Weapon
    {
        private int GOOD_GUY_DAMAGE = 5;
        private int BAD_GUY_DAMAGE = 5;
        private int damage;

        public int Damage
        {
            get { return damage; }
        }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    damage = GOOD_GUY_DAMAGE;
                    break;
                case Faction.BadGuy:
                    damage = BAD_GUY_DAMAGE;
                    break;
                default:
                    break;
            }


        }
    }
}