using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Random rd = new Random();

namespace HorseCareerMode
{
    public class Corrida
    {
        //•	(Velocidade*0.80) + (Resistencia *0.70 )+ (Força*0.50) + (Sorte*0.50)
        static Cavalo cav;


        static public void Correr(Cavalo c)
        {
            Random rd = new Random();
            double pace;
            pace = c.Velocidade * 0.8 + c.Resistencia * 0.7 + c.Forca * 0.5 + rd.Next(0, 51) * 0.5;
        }
    }
}
