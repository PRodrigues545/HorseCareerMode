using System;
using System.Reflection.Emit;

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
            Estabulo est1 = new Estabulo();
            CentroDeEmprego cde = new CentroDeEmprego();
            Equipa equipa1 = new Equipa();

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

            cde.Empregados.Add(fun1);
            cde.Empregados.Add(fun2);
            cde.Empregados.Add(fun3);
            cde.Empregados.Add(fun4);
            cde.Empregados.Add(fun8);
            cde.Empregados.Add(fun6);
            cde.Empregados.Add(fun7);
            cde.Empregados.Add(fun8);
            cde.Empregados.Add(fun9);
            cde.Empregados.Add(fun10);
            cde.Empregados.Add(fun11);
            cde.Empregados.Add(fun12);
            cde.Empregados.Add(fun13);
            cde.Empregados.Add(fun14);





            //est1.tropa.Add(cav1);
            //est1.tropa.Add(cav2);
            //est1.tropa.Add(cav3);
            //est1.tropa.Add(cav4);
            //Jogo jogo = new Jogo();
            //jogo.Start();

            Perfil p1= new Perfil("Player", 5000);
           
            
            
            
            
            
            
            
            
            int selectedIndex = 0;
            int selectedIndex1 = 0;
            int selectedIndex2 = 0;
            int selectedIndex3 = 0;
            int selectedIndex4 = 0;
            int selectedIndex5 = 0;

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
                                    Console.Clear();
                                    equipa1.InfoEquipa();
                                    Console.ReadKey(true);
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
                                        string[] opcoes2 = { "Contratar Funcionarios", "Comprar Cavalos","Vender Cavalos", "Voltar" };

                                        Menu menuMercado = new Menu(prompt2, opcoes2);

                                        selectedIndex2 = menuMercado.Run();

                                        switch (selectedIndex2)
                                        {
                                            case 0:
                                                do
                                                {
                                                    string prompt4 = @"
    &&&
   (+.+)
 ___\=/___
(|_ ~~~ _|)
   |___|
   / _ \
  /_/ \_\
 /_)   (_\                                                     
";

                                                    int i1 = 0;
                                                    string[] opcoes4 = new string[cde.Empregados.Count + 1];
                                                    foreach (Funcionario f in cde.Empregados)
                                                    {
                                                        opcoes4[i1] = f.ToString();
                                                        i1++;
                                                    }
                                                    opcoes4[i1] = "Voltar";

                                                    Menu menuMercadoFuncionarios = new Menu(prompt4, opcoes4);

                                                    selectedIndex4 = menuMercadoFuncionarios.Run();

                                                    int ba = Array.IndexOf(opcoes4, fun1.ToString());
                                                    int bb = Array.IndexOf(opcoes4, fun2.ToString());
                                                    int bc = Array.IndexOf(opcoes4, fun3.ToString());
                                                    int bd = Array.IndexOf(opcoes4, fun4.ToString());
                                                    int be = Array.IndexOf(opcoes4, fun5.ToString());
                                                    int bf = Array.IndexOf(opcoes4, fun6.ToString());
                                                    int bg = Array.IndexOf(opcoes4, fun7.ToString());
                                                    int bh = Array.IndexOf(opcoes4, fun8.ToString());
                                                    int bi = Array.IndexOf(opcoes4, fun9.ToString());
                                                    int bj = Array.IndexOf(opcoes4, fun10.ToString());
                                                    int bk = Array.IndexOf(opcoes4, fun11.ToString());
                                                    int bl = Array.IndexOf(opcoes4, fun12.ToString());
                                                    int bm = Array.IndexOf(opcoes4, fun13.ToString());
                                                    int bn = Array.IndexOf(opcoes4, fun14.ToString());

                                                    if (selectedIndex4 == ba)
                                                    {
                                                        if (p1.Dinheiro > fun1.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun1);
                                                            equipa1.Team.Add(fun1);
                                                            p1.Dinheiro -= fun1.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bb)
                                                    {
                                                        if (p1.Dinheiro > fun2.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun2);
                                                            equipa1.Team.Add(fun2);
                                                            p1.Dinheiro -= fun2.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bc)
                                                    {
                                                        if (p1.Dinheiro > fun3.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun3);
                                                            equipa1.Team.Add(fun3);
                                                            p1.Dinheiro -= fun3.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bd)
                                                    {
                                                        if (p1.Dinheiro > fun4.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun4);
                                                            equipa1.Team.Add(fun4);
                                                            p1.Dinheiro -= fun4.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == be)
                                                    {
                                                        if (p1.Dinheiro > fun5.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun5);
                                                            equipa1.Team.Add(fun5);
                                                            p1.Dinheiro -= fun5.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bf)
                                                    {
                                                        if (p1.Dinheiro > fun6.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun6);
                                                            equipa1.Team.Add(fun6);
                                                            p1.Dinheiro -= fun6.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bg)
                                                    {
                                                        if (p1.Dinheiro > fun7.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun7);
                                                            equipa1.Team.Add(fun7);
                                                            p1.Dinheiro -= fun7.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bh)
                                                    {
                                                        if (p1.Dinheiro > fun8.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun8);
                                                            equipa1.Team.Add(fun8);
                                                            p1.Dinheiro -= fun8.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bi)
                                                    {
                                                        if (p1.Dinheiro > fun9.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun8);
                                                            equipa1.Team.Add(fun9);
                                                            p1.Dinheiro -= fun9.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bj)
                                                    {
                                                        if (p1.Dinheiro > fun10.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun10);
                                                            equipa1.Team.Add(fun10);
                                                            p1.Dinheiro -= fun10.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bk)
                                                    {
                                                        if (p1.Dinheiro > fun11.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun11);
                                                            equipa1.Team.Add(fun11);
                                                            p1.Dinheiro -= fun11.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bl)
                                                    {
                                                        if (p1.Dinheiro > fun12.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun12);
                                                            equipa1.Team.Add(fun12);
                                                            p1.Dinheiro -= fun12.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bm)
                                                    {
                                                        if (p1.Dinheiro > fun13.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun13);
                                                            equipa1.Team.Add(fun13);
                                                            p1.Dinheiro -= fun13.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex4 == bn)
                                                    {
                                                        if (p1.Dinheiro > fun14.Preco)
                                                        {
                                                            cde.Empregados.Remove(fun14);
                                                            equipa1.Team.Add(fun14);
                                                            p1.Dinheiro -= fun14.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }


                                                } while (selectedIndex4 != cde.Empregados.Count);
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

                                                    int i2 = 0;
                                                    string[] opcoes3 = new string[mercado.CavalosVenda.Count+1];
                                                    foreach (Cavalo c in mercado.CavalosVenda)
                                                    {
                                                        opcoes3[i2] = c.ToString();
                                                        i2++;
                                                    }
                                                    opcoes3[i2] = "Voltar";

                                                    Menu menuMercadoCavalos = new Menu(prompt3, opcoes3);

                                                    selectedIndex3 = menuMercadoCavalos.Run();

                                                    int aa = Array.IndexOf(opcoes3, cav1.ToString());
                                                    int ab = Array.IndexOf(opcoes3, cav2.ToString());
                                                    int ac = Array.IndexOf(opcoes3, cav3.ToString());
                                                    int ad = Array.IndexOf(opcoes3, cav4.ToString());
                                                    int ae = Array.IndexOf(opcoes3, cav5.ToString());
                                                    int af = Array.IndexOf(opcoes3, cav6.ToString());
                                                    int ag = Array.IndexOf(opcoes3, cav7.ToString());
                                                    int ah = Array.IndexOf(opcoes3, cav8.ToString());
                                                    int ai = Array.IndexOf(opcoes3, cav9.ToString());
                                                    int aj = Array.IndexOf(opcoes3, cav10.ToString());
                                                    int ak = Array.IndexOf(opcoes3, cav11.ToString());
                                                    int al = Array.IndexOf(opcoes3, cav12.ToString());
                                                    int am = Array.IndexOf(opcoes3, cav13.ToString());
                                                    int an = Array.IndexOf(opcoes3, cav14.ToString());
                                                    int ao = Array.IndexOf(opcoes3, cav15.ToString());

                                                    if (selectedIndex3 == aa)
                                                    {
                                                        if (p1.Dinheiro > cav1.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav1);
                                                            est1.Tropa.Add(cav1);
                                                            p1.Dinheiro -= cav1.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ab)
                                                    {
                                                        if (p1.Dinheiro > cav2.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav2);
                                                            est1.Tropa.Add(cav2);
                                                            p1.Dinheiro -= cav2.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ac)
                                                    {
                                                        if (p1.Dinheiro > cav3.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav3);
                                                            est1.Tropa.Add(cav3);
                                                            p1.Dinheiro -= cav3.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ad)
                                                    {
                                                        if (p1.Dinheiro > cav4.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav4);
                                                            est1.Tropa.Add(cav4);
                                                            p1.Dinheiro -= cav4.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ae)
                                                    {
                                                        if (p1.Dinheiro > cav5.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav5);
                                                            est1.Tropa.Add(cav5);
                                                            p1.Dinheiro -= cav5.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == af)
                                                    {
                                                        if (p1.Dinheiro > cav6.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav6);
                                                            est1.Tropa.Add(cav6);
                                                            p1.Dinheiro -= cav6.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ag)
                                                    {
                                                        if (p1.Dinheiro > cav7.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav7);
                                                            est1.Tropa.Add(cav7);
                                                            p1.Dinheiro -= cav7.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ah)
                                                    {
                                                        if (p1.Dinheiro > cav8.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav8);
                                                            est1.Tropa.Add(cav8);
                                                            p1.Dinheiro -= cav8.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ai)
                                                    {
                                                        if (p1.Dinheiro > cav9.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav9);
                                                            est1.Tropa.Add(cav9);
                                                            p1.Dinheiro -= cav9.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }   
                                                    if (selectedIndex3 == aj)
                                                    {
                                                        if (p1.Dinheiro > cav10.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav10);
                                                            est1.Tropa.Add(cav10);
                                                            p1.Dinheiro -= cav10.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ak)
                                                    {
                                                        if (p1.Dinheiro > cav11.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav11);
                                                            est1.Tropa.Add(cav11);
                                                            p1.Dinheiro -= cav11.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == al)
                                                    {
                                                        if (p1.Dinheiro > cav12.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav12);
                                                            est1.Tropa.Add(cav12);
                                                            p1.Dinheiro -= cav12.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == am)
                                                    {
                                                        if (p1.Dinheiro > cav13.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav13);
                                                            est1.Tropa.Add(cav13);
                                                            p1.Dinheiro -= cav13.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == an)
                                                    {
                                                        if (p1.Dinheiro > cav14.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav14);
                                                            est1.Tropa.Add(cav14);
                                                            p1.Dinheiro -= cav14.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex3 == ao)
                                                    {
                                                        if (p1.Dinheiro > cav15.Preco)
                                                        {
                                                            mercado.CavalosVenda.Remove(cav15);
                                                            est1.Tropa.Add(cav15);
                                                            p1.Dinheiro -= cav15.Preco;
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao tem dinheiro suficiente");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                } while (selectedIndex3 != mercado.CavalosVenda.Count);
                                                break;
                                            case 2:
                                                Console.Clear();
                                                string prompt5 = @"
           ,--,
     _ ___/ /\|
 ,;'( )__, )  ~
//  //   '--; 
'   \     | ^
     ^    ^                                                     
";

                                                int i = 0;
                                                string[] opcoes5 = new string[est1.Tropa.Count + 1];
                                                foreach (Cavalo c in est1.Tropa)
                                                {
                                                    opcoes5[i] = c.ToString();
                                                    i++;
                                                }
                                                opcoes5[i] = "Voltar";

                                                Menu menuMercadoVenderCavalos = new Menu(prompt5, opcoes5);

                                                selectedIndex5 = menuMercadoVenderCavalos.Run();

                                                int ca = Array.IndexOf(opcoes5, cav1.ToString());
                                                int cb = Array.IndexOf(opcoes5, cav2.ToString());
                                                int cc = Array.IndexOf(opcoes5, cav3.ToString());
                                                int cd = Array.IndexOf(opcoes5, cav4.ToString());
                                                int ce = Array.IndexOf(opcoes5, cav5.ToString());
                                                int cf = Array.IndexOf(opcoes5, cav6.ToString());
                                                int cg = Array.IndexOf(opcoes5, cav7.ToString());
                                                int ch = Array.IndexOf(opcoes5, cav8.ToString());
                                                int ci = Array.IndexOf(opcoes5, cav9.ToString());
                                                int cj = Array.IndexOf(opcoes5, cav10.ToString());
                                                int ck = Array.IndexOf(opcoes5, cav11.ToString());
                                                int cl = Array.IndexOf(opcoes5, cav12.ToString());
                                                int cm = Array.IndexOf(opcoes5, cav13.ToString());
                                                int cn = Array.IndexOf(opcoes5, cav14.ToString());
                                                int co = Array.IndexOf(opcoes5, cav15.ToString());

                                                if (selectedIndex5 == ca)
                                                {
                                                    est1.Tropa.Remove(cav1);
                                                    mercado.CavalosVenda.Add(cav1);
                                                    p1.Dinheiro += cav1.Preco - 100;
                                                }
                                                if (selectedIndex5 == cb)
                                                {
                                                  est1.Tropa.Remove(cav2);
                                                   p1.Dinheiro += cav2.Preco - 100;
                                                }
                                                if (selectedIndex5 == cc)
                                                {
                                                    est1.Tropa.Remove(cav3);
                                                    mercado.CavalosVenda.Add(cav3);
                                                    p1.Dinheiro += cav3.Preco - 100;
                                                }
                                                if (selectedIndex5 == cd)
                                                {
                                                    est1.Tropa.Remove(cav4);
                                                    mercado.CavalosVenda.Add(cav4);
                                                    p1.Dinheiro += cav4.Preco - 100;
                                                }
                                                if (selectedIndex5 == ce)
                                                {
                                                    est1.Tropa.Remove(cav5);
                                                    mercado.CavalosVenda.Add(cav5);
                                                    p1.Dinheiro += cav5.Preco - 100;
                                                }
                                                if (selectedIndex5 == cf)
                                                {
                                                    est1.Tropa.Remove(cav6);
                                                    mercado.CavalosVenda.Add(cav6);
                                                    p1.Dinheiro += cav6.Preco - 100;
                                                }
                                                if (selectedIndex5 == cg)
                                                {
                                                    est1.Tropa.Remove(cav7);
                                                    mercado.CavalosVenda.Add(cav7);
                                                    p1.Dinheiro += cav7.Preco - 100;
                                                }
                                                if (selectedIndex5 == ch)
                                                {
                                                    est1.Tropa.Remove(cav8);
                                                    mercado.CavalosVenda.Add(cav8);
                                                    p1.Dinheiro += cav8.Preco - 100;
                                                }
                                                if (selectedIndex5 == ci)
                                                {
                                                    est1.Tropa.Remove(cav9);
                                                    mercado.CavalosVenda.Add(cav9);
                                                    p1.Dinheiro += cav9.Preco - 100;
                                                }
                                                if (selectedIndex5 == cj)
                                                {
                                                    est1.Tropa.Remove(cav10);
                                                    mercado.CavalosVenda.Add(cav10);
                                                    p1.Dinheiro += cav10.Preco - 100;
                                                }
                                                if (selectedIndex5 == ck)
                                                {
                                                    est1.Tropa.Remove(cav11);
                                                    mercado.CavalosVenda.Add(cav11);
                                                    p1.Dinheiro += cav11.Preco - 100;
                                                }
                                                if (selectedIndex5 == cl)
                                                {
                                                    est1.Tropa.Remove(cav12);
                                                    mercado.CavalosVenda.Add(cav12);
                                                    p1.Dinheiro += cav12.Preco - 100;
                                                }
                                                if (selectedIndex5 == cm)
                                                {
                                                    est1.Tropa.Remove(cav13);
                                                    mercado.CavalosVenda.Add(cav13);
                                                    p1.Dinheiro += cav13.Preco - 100;
                                                }
                                                if (selectedIndex5 == cn)
                                                {
                                                    est1.Tropa.Remove(cav14);
                                                    mercado.CavalosVenda.Add(cav14);
                                                    p1.Dinheiro += cav14.Preco - 100;
                                                }
                                                if (selectedIndex5 == co)
                                                {
                                                    est1.Tropa.Remove(cav15);
                                                    mercado.CavalosVenda.Add(cav15);
                                                    p1.Dinheiro += cav15.Preco - 100;
                                                }
                                                break;
                                        }
                                    }while (selectedIndex2 != 3);
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