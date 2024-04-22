using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_juego
{
    internal class ERango : EMelee
    {
        int bullets =5;

        public ERango(int life, int damage) : base(life, damage)
        {
        }

        public override int GetDamage()   //Override es para señarlar lo sobre escrito del virtual en el padre
        {
            if(bullets>0)
            {
                bullets--;
                return damage;
            }
            else
            {
                return 0;
            }
        }

    }
}
