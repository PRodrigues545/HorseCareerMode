using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HorseCareerMode
{
    [Serializable]
    public class Calendario
    {
        private int dia;

        public Calendario()
        {
            this.dia = 1;
        }

        public void AvançarDia()
        {
            this.dia++;

            if(this.dia > 7)
            {
                this.dia = 1;
            }
        }
        public void MostrarDia()
        {
            switch (this.dia)
            {
                case 1: Console.WriteLine(@"

   _____                            _       
  / ____|                          | |      
 | (___   ___  __ _ _   _ _ __   __| | __ _ 
  \___ \ / _ \/ _` | | | | '_ \ / _` |/ _` |
  ____) |  __/ (_| | |_| | | | | (_| | (_| |
 |_____/ \___|\__, |\__,_|_| |_|\__,_|\__,_|
               __/ |                        
              |___/                         
");
                    break;
                case 2:
                    Console.WriteLine(@"

  _______                 
 |__   __|                
    | | ___ _ __ ___ __ _ 
    | |/ _ \ '__/ __/ _` |
    | |  __/ | | (_| (_| |
    |_|\___|_|  \___\__,_|
                 )_)      
                          
");
                    break;
                case 3:
                    Console.WriteLine(@"


   ____                   _        
  / __ \                 | |       
 | |  | |_   _  __ _ _ __| |_ __ _ 
 | |  | | | | |/ _` | '__| __/ _` |
 | |__| | |_| | (_| | |  | || (_| |
  \___\_\\__,_|\__,_|_|   \__\__,_|
                                   
                                   
         
");
                    break;
                case 4:
                    Console.WriteLine(@"

   ____        _       _        
  / __ \      (_)     | |       
 | |  | |_   _ _ _ __ | |_ __ _ 
 | |  | | | | | | '_ \| __/ _` |
 | |__| | |_| | | | | | || (_| |
  \___\_\\__,_|_|_| |_|\__\__,_|
                                
                                
                 
");
                    break;
                case 5:
                    Console.WriteLine(@"


   _____           _        
  / ____|         | |       
 | (___   _____  _| |_ __ _ 
  \___ \ / _ \ \/ / __/ _` |
  ____) |  __/>  <| || (_| |
 |_____/ \___/_/\_\\__\__,_|
                            
                            
                      
");
                    break;
                case 6:
                    Console.WriteLine(@"


   _____       _               _       
  / ____|     | |             | |      
 | (___   __ _| |__   __ _  __| | ___  
  \___ \ / _` | '_ \ / _` |/ _` |/ _ \ 
  ____) | (_| | |_) | (_| | (_| | (_) |
 |_____/ \__,_|_.__/ \__,_|\__,_|\___/ 
                                       
                                       
                      
");
                    break;
                case 7:
                    Console.WriteLine(@"

  _____                  _                   
 |  __ \                (_)                  
 | |  | | ___  _ __ ___  _ _ __   __ _  ___  
 | |  | |/ _ \| '_ ` _ \| | '_ \ / _` |/ _ \ 
 | |__| | (_) | | | | | | | | | | (_| | (_) |
 |_____/ \___/|_| |_| |_|_|_| |_|\__, |\___/ 
                                  __/ |      
                                 |___/       
                      
");
                    break;
            }
        }



        public int Dia { get => dia; set => dia = value; }
    }
}
