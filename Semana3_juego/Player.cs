using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_juego
{
    internal class Player
    {
        int life;
        int damage;

        public Player(int life, int damage)
        {
            this.life = life;
            this.damage = damage;
        }   


        public void SetDamage(int value)     //value es la cantidad de daño recibido
        {
            if (life>=100)
            {
                life = 100;
            }
            else
            {
            life -=value;
            }

        }
        public int GetDamage()     //Daño que hace player
        {
            if (damage> 100)
            {
                damage = 100;   
            }
            return damage;
        }
    }
}
