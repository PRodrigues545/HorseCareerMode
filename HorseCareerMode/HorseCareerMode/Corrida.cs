using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HorseCareerMode
{
    public class Corrida
    {
 
        static private double Correr(Cavalo c)
        {
            Random rd = new Random();
            double pace;
            pace = c.Velocidade * 0.8 + c.Resistencia * 0.7 + c.Forca * 0.5 + rd.Next(0, 51) * 0.5;

            return pace;
        }

        public static void Resultado(Cavalo C, Perfil p1)
        {
            Random rd = new Random();
            double pace = Correr(C);
            if (pace >= rd.Next(150, 200))
            {
                Console.WriteLine(@"
  _______
 |       |
(|       |)
 |       |
  \     /
   `---'
   _|_|_");
                Console.WriteLine("INCRIVEL!!");
                Console.WriteLine("O cavalo " + C.Nome + " é o grande vencedor e leva para casa 750");

                p1.Dinheiro += 750;
            }
            else
            {
                Console.WriteLine(@"
     .-""""""-.
   .'          '.
  /   O      O   \
 :           `    :
 |                |   
 :    .------.    :
  \  '        '  /
   '.          .'
     '-......-'");
                Console.WriteLine("Perdeste");
                C.Popularidade -= 10;
            }
        }
    }
}
