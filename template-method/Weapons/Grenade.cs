using System;

namespace TemplateMethod.Weapons
{
    public class Grenade : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Attack with a grenade! BOOM!");
        }
    }
}
