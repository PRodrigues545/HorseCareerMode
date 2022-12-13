using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Equipa
    {
        private List<Funcionario> team;

        public Equipa()
        {
            this.team = new List<Funcionario>();
        }

        public List<Funcionario> Team { get => team; set => team = value; }
    }
}
