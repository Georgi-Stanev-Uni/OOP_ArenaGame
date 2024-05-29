using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Special_Weapons
{
    public class BladesOfChaos : ISpecialWeapon
    {
        public string Name { get; set; }

        public double DamageBooster { get; private set; }

        public double BlockBooster { get; private set; }

        public string SpecialPower { get; private set; }

        public double SpecialPowerStats { get; private set; }

        public BladesOfChaos(string name)
        {
            Name = name;
            DamageBooster = 15;
            BlockBooster = 6;
            SpecialPower = "fire damage enemy for duration of 2 attack cycles";
            SpecialPowerStats = 10;
        }
    }
}
