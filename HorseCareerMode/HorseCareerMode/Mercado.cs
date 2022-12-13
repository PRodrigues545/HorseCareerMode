using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Mercado
    {
        private List<Cavalo> cavalosVenda;

        public Mercado()
        {
            this.cavalosVenda = new List<Cavalo>();
        }

        public void InfoMercado()
        {
            foreach (Cavalo cavalo in cavalosVenda)
            {
                Console.WriteLine(cavalo);
            }
        }

        public List<Cavalo> CavalosVenda { get => cavalosVenda; set => cavalosVenda = value; }
    }
}
