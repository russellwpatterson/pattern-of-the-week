using TemplateMethod.Weapons;

namespace TemplateMethod.Warriors
{
    public class Grenadier : Warrior
    {
        protected override string GetWarriorName()
        {
            return "Grenadier";
        }

        protected override IWeapon GetWeaponOfChoice()
        {
            return new Grenade();
        }
    }
}
