using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var warrior1 = new Warrior(new Sword());
            warrior1.Attack();

            var warrior2 = new Warrior(new Grenade());
            warrior2.Attack();

            var warrior3 = new Warrior(new Shotgun());
            warrior3.Attack();

            Console.Read();
        }
    }
}
