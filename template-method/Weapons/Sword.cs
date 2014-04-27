using System;

namespace TemplateMethod.Weapons
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Attack with Sword!");
        }
    }
}
