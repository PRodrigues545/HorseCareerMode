using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HorseCareerMode
{
    public class Animal
    {
        private string nome;
        private int velocidade;
        private int resistencia;
        private int forca;
        private string cor;

        public Animal(string nome, int velocidade, int resistencia, int forca, string cor)
        {
            this.nome = nome;
            this.velocidade = velocidade;
            this.resistencia = resistencia;
            this.forca = forca;
            this.cor = cor;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }
        public int Resistencia { get => resistencia; set => resistencia = value; }
        public int Forca { get => forca; set => forca = value; }
        public string Cor { get => cor; set => cor = value; }
    }
}
