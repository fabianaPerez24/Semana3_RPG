using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_juego
{
    internal class EMelee
    {
        protected int life;
        protected int damage;
        //Protected solo comparte entre herencias

        public EMelee(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }

        public void SetDamage(int value)
        {
            life -= value;
        }

        public virtual int GetDamage()    //virtual es para sobreescribir una funcion
        {
            return damage;
        }

        public bool IsAlive()
        {
            return life > 0;
        }
    }
}
