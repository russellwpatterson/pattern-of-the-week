namespace Strategy
{
    public class Warrior
    {
        private readonly IWeapon _primaryWeapon;
        public Warrior(IWeapon primaryWeapon)
        {
            _primaryWeapon = primaryWeapon;
        }

        public void Attack()
        {
            _primaryWeapon.Use();
        }
    }
}
