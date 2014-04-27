using TemplateMethod.Weapons;

namespace TemplateMethod.Warriors
{
    public sealed class Samurai : Warrior
    {
        protected override string GetWarriorName()
        {
            return "Samurai";
        }

        protected override IWeapon GetWeaponOfChoice()
        {
            return new Sword();
        }
    }
}
