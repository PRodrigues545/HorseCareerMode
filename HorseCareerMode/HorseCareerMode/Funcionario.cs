using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    [Serializable]
    public enum Profissao
        {
            Joquei = 1,
            Treinador,
            Veterinario,
            Ferrador,
            TratadorDeCampo,
            MembroDoEstabulo,
            RelacoesPublicas    
        }
    public class Funcionario
    {
        private string nome;
        private int idade;
        private Profissao profissao;
        private int preco;

        public Funcionario(string nome, int idade, Profissao profissao, int preco)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
            this.preco = preco;
        }

        public override string ToString()
        {
            return ""+ this.nome + " ,de "+this.idade+" anos, " +" é " + this.profissao +"." +
                " Valor de mercado de " + this.preco + " euros";
        }




        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public Profissao Profissao { get => profissao; set => profissao = value; }
        public int Preco { get => preco; set => preco = value; }
    }
}
