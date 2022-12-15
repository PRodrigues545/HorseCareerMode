using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    public class Estabulo
    {
        public List<Cavalo> tropa;

        public Estabulo()
        {
            this.tropa = new List<Cavalo>();
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
            foreach (Cavalo cavalo in tropa)
            {
                Console.WriteLine(cavalo);
            }
        }
    }
}
