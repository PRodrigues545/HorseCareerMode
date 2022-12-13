using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
public enum Profissao
    {
        Joquei = 1,
        Veterinario,
        Treinador,
        MembroDoEstabulo,
        Ferrador,
        TratadorDeCampo,
        RelacoesPublicas
    }
    public class Funcionario
    {
        private string nome;
        private int idade;
        private Profissao profissao;

        public Funcionario(string nome, int idade, Profissao profissao)
        {
            this.nome = nome;
            this.idade = idade;
            this.profissao = profissao;
        }

        public override string ToString()
        {
            return "O " + nome + " ,de "+idade+" anos, " +" é " + profissao;
        }




        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public Profissao Profissao { get => profissao; set => profissao = value; }
    }
}
