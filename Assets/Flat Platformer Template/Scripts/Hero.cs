using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Flat_Platformer_Template.Scripts
{
    internal class Hero : Unit<Hero>
    {
        public Hero(int hp, float runSpeed = 10) : base(hp, runSpeed)
        {
        }
    }
}
