using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    [Serializable]
    public class CentroDeEmprego
    {
        private List<Funcionario> empregados;

        public CentroDeEmprego()
        {
            this.empregados = new List<Funcionario>();
        }

        public void InfoCentroDeEmprego()
        {
            foreach (Funcionario funcionario in empregados)
            {
                Console.WriteLine(funcionario);
            }
        }
        public List<Funcionario> Empregados { get => empregados; set => empregados = value; }
    }
}
