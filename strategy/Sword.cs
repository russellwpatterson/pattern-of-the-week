using System;

namespace Strategy
{
    public class Sword : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Attack with Sword!");
        }
    }
}
