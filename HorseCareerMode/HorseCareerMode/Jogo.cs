using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HorseCareerMode
{
    public class Jogo
    {
        Cavalo a = new Cavalo("Mario", 80, 60, 56, "castanho");
        Estabulo e = new Estabulo();

        public void Start()
        {
            Console.Title = "HORSE CAREER MODE";
            RunMainMenu();
        }

        public void RunMainMenu()
        {
            string prompt = @"

_  _  ___  ___ ___ ___    ___   _   ___ ___ ___ ___   __  __  ___  ___  ___ 
| || |/ _ \| _ / __| __|  / __| /_\ | _ | __| __| _ \ |  \/  |/ _ \|   \| __|
| __ | (_) |   \__ | _|  | (__ / _ \|   | _|| _||   / | |\/| | (_) | |) | _| 
|_||_|\___/|_|_|___|___|  \___/_/ \_|_|_|___|___|_|_\ |_|  |_|\___/|___/|___|
                                                                              
 
Welcome to Horse Career Mode";
            string[] options = { "Jogar", "Sobre", "Sair" };


            Menu mainMenu = new Menu(prompt, options);

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunFirstChoice();
                    break;
                case 1:
                    DisplayAboutInfo();
                    break;
                case 2:
                    ExitGame();
                    break;
            }
        }

        public void RunMenu()
        {
            string prompt = @"
      .~~~~`\~~\
     ;       ~~ \
     |           ;
 ,--------,______|---.
/          \-----`    \  
`.__________`-_______-'
";
            string[] opcoes = { "Cavalos", "Treinar", "Equipa", "Sessao Fotografica", "Voltar" };

            Menu menu = new Menu(prompt, opcoes);

            int selectedIndex = menu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Console.Clear();
                    Console.ReadKey(true);
                    RunMenu();
                    break;
                case 1:
                    Console.Clear();
                    a.Treino();
                    Console.ReadKey(true);
                    RunMenu();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    RunMainMenu();
                    break;
            }

        }

        void ExitGame()
        {
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
            Environment.Exit(0);
        }

        private void DisplayAboutInfo()
        {
            Console.Clear();
            Console.WriteLine("Jogo criado por:");
            Console.WriteLine("");
            Console.WriteLine("Eduardo Costa");
            Console.WriteLine("Filipe Araujo");
            Console.WriteLine("Gabriel Costa");
            Console.WriteLine("Pedro Rodrigues");
            Console.ReadKey(true);
            RunMainMenu();
        }
        private void RunFirstChoice()
        {
            RunMenu();
        }    
    }
}
