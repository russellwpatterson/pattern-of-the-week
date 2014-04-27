using TemplateMethod.Weapons;

namespace TemplateMethod.Warriors
{
    public sealed class Infantry : Warrior
    {
        protected override string GetWarriorName()
        {
            return "Infantry Soldier";
        }

        protected override IWeapon GetWeaponOfChoice()
        {
            return new Shotgun();
        }
    }
}
