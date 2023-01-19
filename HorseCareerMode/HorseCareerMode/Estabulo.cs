using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    [Serializable]
    public class Estabulo
    {
        private List<Cavalo> tropa;

        public Estabulo()
        {
            this.Tropa = new List<Cavalo>();
        }


        public void InfoEstabulo()
        {
            Console.WriteLine(@"
           x
.-. _______|
|=|/     /  \
| |_____|_""_|
|_|_[X]_|____|
");
            foreach (Cavalo cavalo in Tropa)
            {
                Console.WriteLine(cavalo);
            }
        }
        
        
        public List<Cavalo> Tropa { get => tropa; set => tropa = value; }
    }     
}
