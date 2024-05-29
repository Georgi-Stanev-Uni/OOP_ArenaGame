using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public interface ISpecialWeapon
    {
        string Name { get; set; }
        double DamageBooster { get; }
        double BlockBooster { get; }
        string SpecialPower { get; }
    }
}
