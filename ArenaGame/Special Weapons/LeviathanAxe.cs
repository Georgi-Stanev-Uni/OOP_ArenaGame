using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    public class LeviathanAxe : ISpecialWeapon
    {
        public string Name { get; set; }

        public double DamageBooster { get; private set; }

        public double BlockBooster { get; private set; }

        public string SpecialPower { get; private set; }

        public double SpecialPowerStats { get; private set; }

        public LeviathanAxe(string name)
        {
            Name = name;
            DamageBooster = 11;
            BlockBooster = 7;
            SpecialPower = "frost damage enemy for duration of 3 attack cycles";
            SpecialPowerStats = 5;
        }
    }
}
