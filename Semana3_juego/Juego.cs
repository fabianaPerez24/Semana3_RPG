using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_juego
{
    internal class Juego
    {

        Player player;

        int enemies=0;
        public  Juego()
        {
            Enemylist.Add(new EMelee(50, 25));
            Enemylist.Add(new ERango(60, 30));
            Enemylist.Add(new EMelee(50, 25));


            Enemylist[0].SetDamage(player.GetDamage());
            Enemylist[1].SetDamage(player.GetDamage());
            Enemylist[2].SetDamage(player.GetDamage());
            enemies=Enemylist.Count;

        }

        List<EMelee> Enemylist = new List<EMelee>();
       
        public void SetPlayer()
        {
            Console.WriteLine("Asigna los datos al player");
            Console.WriteLine("Asigna la vida que tiene");
            int playerlife= int.Parse(Console.ReadLine());
            Console.WriteLine("Asigna el daño que causa");
            int playerdamage = int.Parse(Console.ReadLine());
            player = new Player(playerlife, playerdamage);
            
        }
        public void StartGame()
        {
            SetPlayer();

        while(enemies>0)
            {
                for (int i = 0; i < enemies; i--)
                {

                }
            }

        }

    }
}
