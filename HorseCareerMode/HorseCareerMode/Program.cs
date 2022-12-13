namespace HorseCareerMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun1 = new Funcionario("Armingo", 45, Profissao.Treinador);
            Cavalo cav1 = new Cavalo("Geremias", 50, 20, 50, "Castanho");
            Cavalo cav2 = new Cavalo("Joao", 50, 20, 50, "Castanho");
            Cavalo cav3 = new Cavalo("Pedro", 50, 20, 50, "Branco");
            Cavalo cav4 = new Cavalo("Ze", 50, 20, 50, "Castanho");
            Estabulo est1 = new Estabulo();
            CentroDeEmprego ce = new CentroDeEmprego();
            est1.tropa.Add(cav1);
            est1.tropa.Add(cav2);
            est1.tropa.Add(cav3);
            est1.tropa.Add(cav4);
            ce.Empregados.Add(fun1);
            //Jogo jogo = new Jogo();
            //jogo.Start();
            int selectedIndex = 0;
            int selectedIndex1 = 0;
            int selectedIndex2 = 0;
            do
            {
                string prompt = @"

_  _  ___  ___ ___ ___    ___   _   ___ ___ ___ ___   __  __  ___  ___  ___ 
| || |/ _ \| _ / __| __|  / __| /_\ | _ | __| __| _ \ |  \/  |/ _ \|   \| __|
| __ | (_) |   \__ | _|  | (__ / _ \|   | _|| _||   / | |\/| | (_) | |) | _| 
|_||_|\___/|_|_|___|___|  \___/_/ \_|_|_|___|___|_|_\ |_|  |_|\___/|___/|___|
                                                                              
 
Welcome to Horse Career Mode";
                string[] options = { "Jogar", "Sobre", "Sair" };


                Menu mainMenu = new Menu(prompt, options);

                selectedIndex = mainMenu.Run();

                switch (selectedIndex)
                {
                    case 0:
                        do
                        {
                            string prompt1 = @"
      .~~~~`\~~\
     ;       ~~ \
     |           ;
 ,--------,______|---.
/          \-----`    \  
`.__________`-_______-'
";
                            string[] opcoes1 = {"Cavalos", "Treinar", "Equipa", "Sessao Fotografica","Mercado", "Voltar" };

                            Menu menu = new Menu(prompt1, opcoes1);

                            selectedIndex1 = menu.Run();

                            switch (selectedIndex1)
                            {
                                case 0:
                                    Console.Clear();
                                    est1.InfoEstabulo();
                                    Console.ReadKey(true);

                                    break;
                                case 1:
                                    Console.Clear();
                                    cav1.Treino();
                                    Console.ReadKey(true);

                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    do
                                    {
                                        string prompt2 = @"

  __  __ ______ _____   _____          _____   ____  
 |  \/  |  ____|  __ \ / ____|   /\   |  __ \ / __ \ 
 | \  / | |__  | |__) | |       /  \  | |  | | |  | |
 | |\/| |  __| |  _  /| |      / /\ \ | |  | | |  | |
 | |  | | |____| | \ \| |____ / ____ \| |__| | |__| |
 |_|  |_|______|_|  \_\\_____/_/    \_\_____/ \____/ 
                                                     
                                                     
";
                                        string[] opcoes2 = { "Funcionarios", "Cavalos", "Voltar" };

                                        Menu menuMercado = new Menu(prompt2, opcoes2);

                                        selectedIndex2 = menuMercado.Run();

                                        switch (selectedIndex2)
                                        {
                                            case 0:
                                                Console.Clear();
                                                ce.InfoCentroDeEmprego();
                                                Console.ReadKey(true);
                                                break;

                                        }
                                            



                                    }while (selectedIndex2 != 2);
                                    break;
                            }
                        } while (selectedIndex1 != 5);
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
            } while (selectedIndex != 2);
        }
    }
}