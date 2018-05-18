using WarriorWars.Enum;

namespace WarriorWars.Equipments
{
    internal class Armor
    { 
        private int GOOD_GUY_ARMOR = 5;
        private int BAD_GUY_ARMOR = 5;
        private int armorPoint;

        public int ArmorPoint
        {
            get { return armorPoint; }
        }
        public Armor(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    armorPoint = GOOD_GUY_ARMOR;
                    break;
                case Faction.BadGuy:
                    armorPoint = BAD_GUY_ARMOR;
                    break;
                default:
                    break;
            }
        }
    }
}