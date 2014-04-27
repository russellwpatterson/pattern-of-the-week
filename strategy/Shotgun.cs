using System;

namespace Strategy
{
    public class Shotgun : IWeapon
    {
        public void Use()
        {
            Console.WriteLine("Attack with shotgun!");
        }
    }
}
