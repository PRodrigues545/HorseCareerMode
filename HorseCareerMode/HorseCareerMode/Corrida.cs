using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HorseCareerMode
{
    public static class Corrida
    {
 
        static private double Correr(Cavalo c)
        {
            Random rd = new Random();
            double pace;
            int sorte = rd.Next(0, 51);
            pace = c.Velocidade * 0.8 + c.Resistencia * 0.7 + c.Forca * 0.5 + sorte * 0.5;

            if(sorte < 5)
            {
                c.Resistencia = 0;
                Console.WriteLine("O teu cavalo lesionou-se, a resistencia ficou a 0");
            }

            return pace;
        }

        public static void Resultado(Cavalo C, Perfil p1)
        {
            Random rd = new Random();
            double pace = Correr(C);
            if (pace >= rd.Next(135, 236))
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
            C.Resistencia -= 10;
            if(C.Resistencia < 0)
            {
                C.Resistencia = 0;
            }
        }
    }
}
