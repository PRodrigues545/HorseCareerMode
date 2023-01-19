using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    [Serializable]
    public class Equipa
    {

        private List<Funcionario> team;
        private Perfil perfil;
        private Calendario calendario;

        public Equipa(Perfil perfil, Calendario calendario)
        {
            this.team = new List<Funcionario>();
            this.Perfil = perfil;
            this.Calendario = calendario;
        }

        public void InfoEquipa()
        {
            Console.WriteLine(@"
           x
.-. _______|
|=|/     /  \
| |_____|_""_|
|_|_[X]_|____|
");
            foreach (Funcionario f in team)
            {
                Console.WriteLine(f);
            }
        }




        public List<Funcionario> Team { get => team; set => team = value; }
        public Perfil Perfil { get => perfil; set => perfil = value; }
        public Calendario Calendario { get => calendario; set => calendario = value; }
    }
}
