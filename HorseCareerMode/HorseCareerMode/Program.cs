namespace HorseCareerMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun1 = new Funcionario("Armindo", 45, Profissao.Treinador, 150);
            Funcionario fun2 = new Funcionario("David", 27, Profissao.Joquei, 200);
            Funcionario fun3 = new Funcionario("João", 38, Profissao.Treinador, 150);
            Funcionario fun4 = new Funcionario("Vitor", 25, Profissao.Joquei, 200);
            Funcionario fun5 = new Funcionario("Rodrigo", 36, Profissao.Veterinario, 300);
            Funcionario fun6 = new Funcionario("Beatriz", 32, Profissao.Veterinario, 300);
            Funcionario fun7 = new Funcionario("Martim", 29, Profissao.Ferrador, 150);
            Funcionario fun8 = new Funcionario("Afonso", 41, Profissao.Ferrador, 150);
            Funcionario fun9 = new Funcionario("Sofia", 23, Profissao.MembroDoEstabulo, 50);
            Funcionario fun10 = new Funcionario("Catarina", 25, Profissao.MembroDoEstabulo, 50);
            Funcionario fun11 = new Funcionario("Armingo", 56, Profissao.TratadorDeCampo, 100);
            Funcionario fun12 = new Funcionario("Matilde", 40, Profissao.TratadorDeCampo, 100);
            Funcionario fun13 = new Funcionario("Miguel", 19, Profissao.RelacoesPublicas, 100);
            Funcionario fun14 = new Funcionario("Leonor", 22, Profissao.RelacoesPublicas, 100);

            Cavalo cav1 = new Cavalo("Ambicioso", 50, 40, 60, "Castanho", 30);
            Cavalo cav2 = new Cavalo("Donatelo", 60, 30, 55, "Branco", 45);
            Cavalo cav3 = new Cavalo("Impetuoso", 65, 30, 30, "Castanho", 55);
            Cavalo cav4 = new Cavalo("Zorro", 55, 35, 35, "Preto", 40);
            Cavalo cav5 = new Cavalo("Tormento", 45, 45, 60, "Preto", 60);
            Cavalo cav6 = new Cavalo("Trono", 70, 20, 35, "Cinza", 70);
            Cavalo cav7 = new Cavalo("Relâmpago", 55, 30, 60, "Branco", 55);
            Cavalo cav8 = new Cavalo("Silvestre", 60, 50, 25, "Branco", 65);
            Cavalo cav9 = new Cavalo("Victoriano", 66, 20, 63, "Cinza", 45);
            Cavalo cav10 = new Cavalo("Pegaso", 44, 47, 63, "Cinza", 77);
            Cavalo cav11 = new Cavalo("Rubi", 50, 50, 50, "Castanho", 50);
            Cavalo cav12 = new Cavalo("Raio", 66, 20, 63, "Preto", 45);
            Cavalo cav13 = new Cavalo("Sargento", 60, 40, 40, "Cinza", 45);
            Cavalo cav14 = new Cavalo("Genovevo", 50, 35, 60, "Cinza", 54);
            Cavalo cav15 = new Cavalo("Buenaventura", 55, 45, 65, "Castanho", 60);

            Mercado mercado = new Mercado();

            mercado.CavalosVenda.Add(cav1);
            mercado.CavalosVenda.Add(cav2);
            mercado.CavalosVenda.Add(cav3);
            mercado.CavalosVenda.Add(cav4);
            mercado.CavalosVenda.Add(cav5);
            mercado.CavalosVenda.Add(cav6);
            mercado.CavalosVenda.Add(cav7);
            mercado.CavalosVenda.Add(cav8);
            mercado.CavalosVenda.Add(cav9);
            mercado.CavalosVenda.Add(cav10);
            mercado.CavalosVenda.Add(cav11);
            mercado.CavalosVenda.Add(cav12);
            mercado.CavalosVenda.Add(cav13);
            mercado.CavalosVenda.Add(cav14);
            mercado.CavalosVenda.Add(cav15);

            Estabulo est1 = new Estabulo();
            CentroDeEmprego ce = new CentroDeEmprego();
            //est1.tropa.Add(cav1);
            //est1.tropa.Add(cav2);
            //est1.tropa.Add(cav3);
            //est1.tropa.Add(cav4);
            ce.Empregados.Add(fun1);
            //Jogo jogo = new Jogo();
            //jogo.Start();

            Perfil p1= new Perfil("Player", 5000);
           
            
            
            
            
            
            
            
            
            int selectedIndex = 0;
            int selectedIndex1 = 0;
            int selectedIndex2 = 0;
            int selectedIndex3 = 0;

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
                            string[] opcoes1 = {"Cavalos", "Treinar", "Equipa", "Sessao Fotografica","Mercado", "Banco", "Voltar" };

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
                                    //cav1.Treino();
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
                                            case 1:
                                                do
                                                {
                                                    string prompt3 = @"
           ,--,
     _ ___/ /\|
 ,;'( )__, )  ~
//  //   '--; 
'   \     | ^
     ^    ^                                                     
";

                                                    int i = 0;
                                                    string[] opcoes3 = new string[mercado.CavalosVenda.Count+1];
                                                    foreach (Cavalo c in mercado.CavalosVenda)
                                                    {
                                                        opcoes3[i] = c.ToString();
                                                        i++;
                                                    }
                                                    opcoes3.Append("Voltar");

                                                    Menu menuMercadoCavalos = new Menu(prompt3, opcoes3);

                                                    selectedIndex3 = menuMercadoCavalos.Run();

                                                    
                                                } while (selectedIndex3 != mercado.CavalosVenda.Count);
                                                break;

                                        }
                                            



                                    }while (selectedIndex2 != 2);
                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.WriteLine(p1.ToString());
                                    Console.ReadKey(true);
                                    break;
                            }
                        } while (selectedIndex1 != 6);
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