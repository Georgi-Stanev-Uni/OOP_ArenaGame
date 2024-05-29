using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Paladin : Hero
    {
        private double hitCount;
        private double damageCoef;

        public Paladin(string name, double armor, double strenght, IWeapon weapon, ISpecialWeapon? specialWeapon) : base(name, armor, strenght, weapon, specialWeapon)
        {
            hitCount = 0;
            damageCoef = 0.9;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
