namespace HorseCareerMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jogo jogo = new Jogo();
            //jogo.Start();

            string prompt = @"

_  _  ___  ___ ___ ___    ___   _   ___ ___ ___ ___   __  __  ___  ___  ___ 
| || |/ _ \| _ / __| __|  / __| /_\ | _ | __| __| _ \ |  \/  |/ _ \|   \| __|
| __ | (_) |   \__ | _|  | (__ / _ \|   | _|| _||   / | |\/| | (_) | |) | _| 
|_||_|\___/|_|_|___|___|  \___/_/ \_|_|_|___|___|_|_\ |_|  |_|\___/|___/|___|
                                                                              
 
Welcome to Horse Career Mode";
            string[] options = { "Jogar", "Sobre", "Sair" };


            Menu mainMenu = new Menu(prompt, options);
            mainMenu.Run();

            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    string prompt1 = @"
      .~~~~`\~~\
     ;       ~~ \
     |           ;
 ,--------,______|---.
/          \-----`    \  
`.__________`-_______-'
";
                    string[] opcoes1 = { "Cavalos", "Treinar", "Equipa", "Sessao Fotografica", "Voltar" };

                    Menu menu = new Menu(prompt1, opcoes1);
                    menu.Run();
                    int selectedIndex1 = menu.Run();

                    if (selectedIndex1 == 0)
                    {
                        Console.Clear();
                        Console.ReadKey(true);
                    }
                    if(selectedIndex1 == 1) { 
                            Console.Clear();
                            //a.Treino();
                            Console.ReadKey(true);
                            menu.Run();
                    }
                    if(selectedIndex1 == 2){
                        Console.Clear();
                        Console.ReadKey(true);
                        menu.Run();
                    }
                    if(selectedIndex1 == 3)
                    {
                        Console.Clear();
                        Console.ReadKey(true);
                        menu.Run();
                    }  
                    if(selectedIndex1 == 4) {
                            mainMenu.Run();
                            break;
                    }
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Jogo criado por:");
                    Console.WriteLine("");
                    Console.WriteLine("Eduardo Costa");
                    Console.WriteLine("Filipe Araujo");
                    Console.WriteLine("Gabriel Costa");
                    Console.WriteLine("Pedro Rodrigues");
                    Console.ReadKey(true);
                    break;
                case 2:
                    Console.Write("\nPress any key to exit...");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
        }
    }
}