using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Perfil
    {
        private string userName;
        private int dinheiro;

        public Perfil(string userName, int dinheiro)
        {
            this.userName = userName;
            this.dinheiro = dinheiro;
        }


        public override string ToString()
        {
            return "O jogador tem " + this.dinheiro + " euros";
        }




        public string UserName { get => userName; set => userName = value; }
        public int Dinheiro { get => dinheiro; set => dinheiro = value; }
    }
}
