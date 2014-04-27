using System;
using TemplateMethod.Weapons;

namespace TemplateMethod.Warriors
{
    public abstract class Warrior : IWarrior
    {
        public void Attack()
        {
            // Print out what's happening. We use a method from the derived class here.
            Console.WriteLine("{0} is attacking!", GetWarriorName());

            // Call a method in the derived class. This means that Attack() is a template method.
            var w = GetWeaponOfChoice();

            w.Use();
        }

        // This is defined in a derived class
        protected abstract string GetWarriorName();
        protected abstract IWeapon GetWeaponOfChoice();
    }
}
