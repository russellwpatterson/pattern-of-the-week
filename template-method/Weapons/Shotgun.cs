using System;

namespace TemplateMethod.Weapons
{
    public class Shotgun : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Attack with shotgun!");
        }
    }
}
