using System;
namespace MektonCore
{
    public class Armor
    {
        public string ArmorType { get; set; }
        public int BaseArmorStoppingPower { get; set; }
        public int CurrentArmorStoppingPower { get; set; }
        public double ArmorCost { get; set; }
        public double ArmorWeight { get; set; }
        public string ArmorModification { get; set; }
        public int ArmorBreakPoint { get; set; }
        public Armor(string ArmorType, string ArmorMod )
        {
            
        }
        public int ArmorDamage(int kills){
            int damageReceived = kills - CurrentArmorStoppingPower;
            if(kills>=ArmorBreakPoint){
                CurrentArmorStoppingPower--;
            }
            return damageReceived;
        }
    }
}
