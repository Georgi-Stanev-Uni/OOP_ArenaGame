using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    public class DupnirSpear : ISpecialWeapon
    {
        public string Name { get; set; }

        public double DamageBooster { get; private set; }

        public double BlockBooster { get; private set; }

        public string SpecialPower { get; private set; }

        public double SpecialPowerStats { get; private set; }

        public DupnirSpear(string name)
        {
            Name = name;
            DamageBooster = 8;
            BlockBooster = 11;
            SpecialPower = "poison damage enemy for duration of 3 attack cycles";
            SpecialPowerStats = 1;
        }
    }
}
