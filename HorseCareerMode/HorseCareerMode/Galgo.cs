using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Galgo: Animal
    {
        public Galgo(string nome, int velocidade, int resistencia, int forca, string cor):base(nome, velocidade, resistencia, forca, cor)
        {
        }

        public override string ToString()
        {
            return "O galgo " + Nome + " tem " + Velocidade + " de velocidade, " + Resistencia + " de resistência e " + Forca + " de força";
        }
    }
}
