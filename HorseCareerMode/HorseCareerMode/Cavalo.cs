using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Cavalo : Animal
    {
        public Cavalo(string nome, int velocidade, int resistencia, int forca, string cor):base(nome, velocidade, resistencia, forca, cor)
        {
        }



        public void Treino()
        {
            this.Velocidade += 5;
            this.Resistencia += 2;
            this.Forca += 4;
            Console.WriteLine(@"
            .''
  ._.-.___.' (`\
 //(        ( `'
'/ )\ ).__. ) 
' <' `\ ._/'\
   `   \     \
");
            Console.WriteLine("O Cavalo aumentou 5 de velocidade");
            Console.WriteLine("O Cavalo aumentou 2 de resistencia");
            Console.WriteLine("O Cavalo aumentou 4 de força");
            Console.WriteLine();
            ToString();
        }



        public override string ToString()
        {
            return "O cavalo " + Nome + " tem " + Velocidade + " de velocidade, " + Resistencia + " de resistência e " + Forca + " de força";
        }

    }
}
