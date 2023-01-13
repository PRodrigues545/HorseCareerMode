using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Cavalo : Animal
    {
        private int popularidade;
        private int preco;

        public Cavalo(string nome, int velocidade, int resistencia, int forca, string cor, int popularidade):base(nome, velocidade, resistencia, forca, cor)
        {
            this.popularidade = popularidade;
            this.preco = 1000 + this.Velocidade * 13 + this.Resistencia * 12  + this.Forca * 11 + this.Popularidade * 15;
        }



        public void Treino()
        {

            this.Velocidade += 3;
            if(this.Velocidade > 100)
            {
                this.Velocidade = 100;
            }
            this.Resistencia += 2;
            if (this.Resistencia > 100)
            {
                this.Resistencia = 100;
            }
            this.Forca += 4;
            if (this.Forca > 100)
            {
                this.Forca = 100;
            }
            Console.WriteLine(@"
 ~,  O
 /)\~_/\
'  \ \~_\__ ~
  _|_)_\_( )~~~
//   /|   \|\
  ()//|     \`
  ||/||
  ||
  || 
");
            Console.WriteLine("O Cavalo "+ this.Nome + " aumentou 5 de velocidade");
            Console.WriteLine("O Cavalo "+ this.Nome + " aumentou 2 de resistencia");
            Console.WriteLine("O Cavalo "+ this.Nome + " aumentou 4 de força");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(ToString());
        }

        public void SessaoFotografica()
        {
            this.Popularidade += 7;
            if (this.Popularidade > 100)
            {
                this.Popularidade= 100;
            }
            Console.WriteLine(@"
         ___
       [|   |=|{)__
        |___| \/   )
         /|\      /|
        / | \     | \
");
            Console.WriteLine("O Cavalo " + this.Nome + " aumentou 7 de popularidade");
            Console.WriteLine();
            Console.WriteLine("O Cavalo " + this.Nome + " tem " + this.Popularidade + " de popularidade");
        }

        public void Limpeza()
        {
            this.Resistencia += 9;
            if(this.Resistencia > 100)
            {
                this.Resistencia = 100;
            }

            Console.WriteLine(@"
       _ ____
     /( ) _   \
    / //   /\` \,  ||--||--||-
      \|   |/  \|  ||--||--||-
~^~^~^~~^~~~^~~^^~^^^^^^^^^^^^");
            Console.WriteLine("O Cavalo " + this.Nome + " aumentou 9 de resistencia");
        }


        public void Visita() 
        {
            this.Popularidade += 5;
            if(this.Popularidade > 100)
            {
                this.Popularidade = 100;
            }
            this.Resistencia += 2;
            if(this.Resistencia > 100)
            {
                this.Resistencia = 100;
            }
            Console.WriteLine(@"
            .''
  ._.-.___.' (`\
 //(        ( `'
'/ )\ ).__. ) 
' <' `\ ._/'\
   `   \     \
");
            Console.WriteLine("O Cavalo " + this.Nome + " aumentou 5 de popularidade");
            Console.WriteLine("O Cavalo " + this.Nome + " aumentou 2 de resistencia");
        }

        public override string ToString()
        {
            return "O cavalo " + this.Nome + " tem " + this.Velocidade + " de velocidade, " + this.Resistencia +
                " de resistência, " + this.Forca + " de força e " + this.Popularidade + " de popularidade" ;
        }

        public int Preco { get => preco; set => preco = value; }
        public int Popularidade { get => popularidade; set => popularidade = value; }
    }
}
