using System;
using System.Reflection.Emit;

namespace HorseCareerMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario fun1 = new Funcionario("Armindo", 45, Profissao.Treinador, 350);
            Funcionario fun2 = new Funcionario("David", 27, Profissao.Joquei, 400);
            Funcionario fun3 = new Funcionario("João", 38, Profissao.Treinador, 350);
            Funcionario fun4 = new Funcionario("Vitor", 25, Profissao.Joquei, 400);
            Funcionario fun5 = new Funcionario("Rodrigo", 36, Profissao.Veterinario, 600);
            Funcionario fun6 = new Funcionario("Beatriz", 32, Profissao.Veterinario, 600);
            Funcionario fun7 = new Funcionario("Martim", 29, Profissao.Ferrador, 150);
            Funcionario fun8 = new Funcionario("Afonso", 41, Profissao.Ferrador, 150);
            Funcionario fun9 = new Funcionario("Sofia", 23, Profissao.MembroDoEstabulo, 50);
            Funcionario fun10 = new Funcionario("Catarina", 25, Profissao.MembroDoEstabulo, 50);
            Funcionario fun11 = new Funcionario("Armingo", 56, Profissao.TratadorDeCampo, 100);
            Funcionario fun12 = new Funcionario("Matilde", 40, Profissao.TratadorDeCampo, 100);
            Funcionario fun13 = new Funcionario("Miguel", 19, Profissao.RelacoesPublicas, 400);
            Funcionario fun14 = new Funcionario("Leonor", 22, Profissao.RelacoesPublicas, 400);

            Cavalo cav1 = new Cavalo("Ambicioso", 47, 25, 30, "Castanho", 30);
            Cavalo cav2 = new Cavalo("Donatelo", 40, 25, 34, "Branco", 45);
            Cavalo cav3 = new Cavalo("Impetuoso", 65, 30, 30, "Castanho", 25);
            Cavalo cav4 = new Cavalo("Zorro", 55, 35, 35, "Preto", 40);
            Cavalo cav5 = new Cavalo("Tormento", 45, 45, 25, "Preto", 30);
            Cavalo cav6 = new Cavalo("Trono", 40, 20, 35, "Cinza", 40);
            Cavalo cav7 = new Cavalo("Relâmpago", 55, 30, 40, "Branco", 25);
            Cavalo cav8 = new Cavalo("Silvestre", 40, 50, 25, "Branco", 35);
            Cavalo cav9 = new Cavalo("Victoriano", 66, 20, 53, "Cinza", 45);
            Cavalo cav10 = new Cavalo("Pegaso", 35, 40, 23, "Cinza", 10);
            Cavalo cav11 = new Cavalo("Rubi", 50, 20, 20, "Castanho", 35);
            Cavalo cav12 = new Cavalo("Raio", 60, 20, 33, "Preto", 25);
            Cavalo cav13 = new Cavalo("Sargento", 70, 60, 70, "Cinza", 85);
            Cavalo cav14 = new Cavalo("Genovevo", 80, 55, 65, "Cinza", 90);
            Cavalo cav15 = new Cavalo("Buenaventura", 70, 75,65, "Castanho", 80);

            Mercado mercado = new Mercado();
            Estabulo est1 = new Estabulo();
            CentroDeEmprego cde = new CentroDeEmprego();
            Equipa equipa1 = new Equipa();
            Calendario calendario = new Calendario();

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

            Perfil p1= new Perfil("Player", 5000);
          
            int selectedIndex = 0;
            int selectedIndex1 = 0;
            int selectedIndex2 = 0;
            int selectedIndex3 = 0;
            int selectedIndex4 = 0;
            int selectedIndex5 = 0;
            int selectedIndex6 = 0;
            int selectedIndex7 = 0;
            int selectedIndex8 = 0;
            int selectedIndex9 = 0;
            int selectedIndex10 = 0;
            int selectedIndex11 = 0;


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
                            string[] opcoes1 = {"Cavalos", "Atividades", "Equipa", "Mercado", "Banco", "Voltar" };

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
                                    do {
                                    string prompt6 = @"

        _______ _______      _______ _____          _____  ______  _____ 
     /\|__   __|_   _\ \    / /_   _|  __ \   /\   |  __ \|  ____|/ ____|
    /  \  | |    | |  \ \  / /  | | | |  | | /  \  | |  | | |__  | (___  
   / /\ \ | |    | |   \ \/ /   | | | |  | |/ /\ \ | |  | |  __|  \___ \ 
  / ____ \| |   _| |_   \  /   _| |_| |__| / ____ \| |__| | |____ ____) |
 /_/    \_\_|  |_____|   \/   |_____|_____/_/    \_\_____/|______|_____/                                                                         
                                                                                                                          
";
                                    string[] opcoes6 = { "Treinar", "Sessão Fotografica","Calendario" ,"Limpeza", "Visitas","Corrida","Voltar"};

                                    Menu menuAtividades = new Menu(prompt6, opcoes6);

                                    selectedIndex6 = menuAtividades.Run();
           
                                        switch (selectedIndex6)
                                        {
                                            case 0:
                                                
                                                    do
                                                    {
                                                        if (calendario.Dia != 7)
                                                        {
                                                            Console.Clear();
                                                            string prompt7 = @"
           ,--,
     _ ___/ /\|
 ,;'( )__, )  ~
//  //   '--; 
'   \     | ^
     ^    ^                                                     
    ";

                                                            int i3 = 0;
                                                            string[] opcoes7 = new string[est1.Tropa.Count + 1];
                                                            foreach (Cavalo c in est1.Tropa)
                                                            {
                                                                opcoes7[i3] = c.ToString();
                                                                i3++;
                                                            }
                                                            opcoes7[i3] = "Voltar";

                                                            Menu menuTreinoCavalos = new Menu(prompt7, opcoes7);
                                                            selectedIndex7 = menuTreinoCavalos.Run();

                                                            int da = Array.IndexOf(opcoes7, cav1.ToString());
                                                            int db = Array.IndexOf(opcoes7, cav2.ToString());
                                                            int dc = Array.IndexOf(opcoes7, cav3.ToString());
                                                            int dd = Array.IndexOf(opcoes7, cav4.ToString());
                                                            int de = Array.IndexOf(opcoes7, cav5.ToString());
                                                            int df = Array.IndexOf(opcoes7, cav6.ToString());
                                                            int dg = Array.IndexOf(opcoes7, cav7.ToString());
                                                            int dh = Array.IndexOf(opcoes7, cav8.ToString());
                                                            int di = Array.IndexOf(opcoes7, cav9.ToString());
                                                            int dj = Array.IndexOf(opcoes7, cav10.ToString());
                                                            int dk = Array.IndexOf(opcoes7, cav11.ToString());
                                                            int dl = Array.IndexOf(opcoes7, cav12.ToString());
                                                            int dm = Array.IndexOf(opcoes7, cav13.ToString());
                                                            int dn = Array.IndexOf(opcoes7, cav14.ToString());
                                                            int dp = Array.IndexOf(opcoes7, cav15.ToString());

                                                            if (selectedIndex7 == da)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav1.Treino();

                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == db)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav2.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dc)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav3.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dd)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav4.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == de)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav5.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == df)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav6.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dg)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav7.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dh)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav8.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == di)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav9.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dj)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav10.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dk)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav11.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dl)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav12.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dm)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav13.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dn)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav14.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex7 == dp)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun1) || equipa1.Team.Contains(fun3))
                                                                {
                                                                    Console.Clear();
                                                                    cav15.Treino();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel treinar! Compre um treinador!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {  
                                                            Console.Clear();
                                                            Console.WriteLine("É DIA DE CORRIDA!!");
                                                            Console.ReadKey(true);
                                                            break;
   
                                                        }
                                                    } while (selectedIndex7 != est1.Tropa.Count);

                                                break;
                                            case 1:
                                                    do
                                                    {
                                                        if (calendario.Dia != 7) {
                                                            Console.Clear();
                                                            string prompt8 = @"
           ,--,
     _ ___/ /\|
 ,;'( )__, )  ~
//  //   '--; 
'   \     | ^
     ^    ^                                                     
";

                                                            int i4 = 0;
                                                            string[] opcoes8 = new string[est1.Tropa.Count + 1];
                                                            foreach (Cavalo c in est1.Tropa)
                                                            {
                                                                opcoes8[i4] = c.ToString();
                                                                i4++;
                                                            }
                                                            opcoes8[i4] = "Voltar";

                                                            Menu menuFotoCavalos = new Menu(prompt8, opcoes8);
                                                            selectedIndex8 = menuFotoCavalos.Run();

                                                            int ea = Array.IndexOf(opcoes8, cav1.ToString());
                                                            int eb = Array.IndexOf(opcoes8, cav2.ToString());
                                                            int ec = Array.IndexOf(opcoes8, cav3.ToString());
                                                            int ed = Array.IndexOf(opcoes8, cav4.ToString());
                                                            int ee = Array.IndexOf(opcoes8, cav5.ToString());
                                                            int ef = Array.IndexOf(opcoes8, cav6.ToString());
                                                            int eg = Array.IndexOf(opcoes8, cav7.ToString());
                                                            int eh = Array.IndexOf(opcoes8, cav8.ToString());
                                                            int ei = Array.IndexOf(opcoes8, cav9.ToString());
                                                            int ej = Array.IndexOf(opcoes8, cav10.ToString());
                                                            int ek = Array.IndexOf(opcoes8, cav11.ToString());
                                                            int el = Array.IndexOf(opcoes8, cav12.ToString());
                                                            int em = Array.IndexOf(opcoes8, cav13.ToString());
                                                            int en = Array.IndexOf(opcoes8, cav14.ToString());
                                                            int eo = Array.IndexOf(opcoes8, cav15.ToString());

                                                        
                                                            if (selectedIndex8 == ea)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav1.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == eb)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav2.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ec)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav3.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ed)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav4.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ee)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav5.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ef)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav6.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == eg)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav7.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == eh)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav8.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ei)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav9.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ej)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav10.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == ek)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav11.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == el)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav12.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == em)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav13.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == en)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav14.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex8 == eo)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                                {
                                                                    Console.Clear();
                                                                    cav15.SessaoFotografica();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel fazer a sessão! Contrate um RP!");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("É DIA DE CORRIDA!!");
                                                            Console.ReadKey(true);
                                                            break;
                                                        }
                                                } while (selectedIndex8 != est1.Tropa.Count);
                                                break;
                                            case 2:
                                                Console.Clear();
                                                calendario.MostrarDia();
                                                Console.ReadKey(true);
                                                break;
                                            case 3:
                                                    do
                                                    {
                                                        if (calendario.Dia != 7)
                                                        {
                                                            string prompt10 = @"
  |
  |
  |
  |
  |
  | 
 /X\
//X\\                                                   
";

                                                            int i6 = 0;
                                                            string[] opcoes10 = new string[est1.Tropa.Count + 1];
                                                            foreach (Cavalo c in est1.Tropa)
                                                            {
                                                                opcoes10[i6] = c.ToString();
                                                                i6++;
                                                            }
                                                            opcoes10[i6] = "Voltar";

                                                            Menu menuLimpeza = new Menu(prompt10, opcoes10);
                                                            selectedIndex10 = menuLimpeza.Run();

                                                            int ga = Array.IndexOf(opcoes10, cav1.ToString());
                                                            int gb = Array.IndexOf(opcoes10, cav2.ToString());
                                                            int gc = Array.IndexOf(opcoes10, cav3.ToString());
                                                            int gd = Array.IndexOf(opcoes10, cav4.ToString());
                                                            int ge = Array.IndexOf(opcoes10, cav5.ToString());
                                                            int gf = Array.IndexOf(opcoes10, cav6.ToString());
                                                            int gg = Array.IndexOf(opcoes10, cav7.ToString());
                                                            int gh = Array.IndexOf(opcoes10, cav8.ToString());
                                                            int gi = Array.IndexOf(opcoes10, cav9.ToString());
                                                            int gj = Array.IndexOf(opcoes10, cav10.ToString());
                                                            int gk = Array.IndexOf(opcoes10, cav11.ToString());
                                                            int gl = Array.IndexOf(opcoes10, cav12.ToString());
                                                            int gm = Array.IndexOf(opcoes10, cav13.ToString());
                                                            int gn = Array.IndexOf(opcoes10, cav14.ToString());
                                                            int go = Array.IndexOf(opcoes10, cav15.ToString());

                                                            if (selectedIndex10 == ga)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav1.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gb)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav2.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gc)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav3.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gd)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav4.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == ge)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav5.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gf)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav6.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gg)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav7.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gh)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav8.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gi)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav9.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gj)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav10.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gk)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav11.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gl)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav12.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gm)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav13.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == gn)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav14.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                            if (selectedIndex10 == go)
                                                            {
                                                                calendario.AvançarDia();
                                                                if (equipa1.Team.Contains(fun9) || equipa1.Team.Contains(fun10))
                                                                {
                                                                    Console.Clear();
                                                                    cav15.Limpeza();
                                                                    Console.ReadKey(true);
                                                                }
                                                                else
                                                                {
                                                                    Console.Clear();
                                                                    Console.WriteLine("Impossivel limpar o cavalo, contrata um membro para o estabulo");
                                                                    Console.ReadKey(true);
                                                                }
                                                            }
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("É DIA DE CORRIDA!!");
                                                            Console.ReadKey(true);
                                                            break;
                                                        }
                                                } while (selectedIndex10 != est1.Tropa.Count);
                                                break;
                                            case 4:
                                                do
                                                {
                                                    if (calendario.Dia != 7)
                                                    {

                                                        string prompt11 = @"
   _____,,;;;`;       ;';;;,,_____
,~(  )  , )~~\|       |/~~( ,  (  )~;
' / / --`--,             .--'-- \ \ `
 /  \    | '             ` |    /  \                                                  
";

                                                        int i7 = 0;
                                                        string[] opcoes11 = new string[est1.Tropa.Count + 1];
                                                        foreach (Cavalo c in est1.Tropa)
                                                        {
                                                            opcoes11[i7] = c.ToString();
                                                            i7++;
                                                        }
                                                        opcoes11[i7] = "Voltar";

                                                        Menu menuVisita = new Menu(prompt11, opcoes11);
                                                        selectedIndex11 = menuVisita.Run();

                                                        int ha = Array.IndexOf(opcoes11, cav1.ToString());
                                                        int hb = Array.IndexOf(opcoes11, cav2.ToString());
                                                        int hc = Array.IndexOf(opcoes11, cav3.ToString());
                                                        int hd = Array.IndexOf(opcoes11, cav4.ToString());
                                                        int he = Array.IndexOf(opcoes11, cav5.ToString());
                                                        int hf = Array.IndexOf(opcoes11, cav6.ToString());
                                                        int hg = Array.IndexOf(opcoes11, cav7.ToString());
                                                        int hh = Array.IndexOf(opcoes11, cav8.ToString());
                                                        int hi = Array.IndexOf(opcoes11, cav9.ToString());
                                                        int hj = Array.IndexOf(opcoes11, cav10.ToString());
                                                        int hk = Array.IndexOf(opcoes11, cav11.ToString());
                                                        int hl = Array.IndexOf(opcoes11, cav12.ToString());
                                                        int hm = Array.IndexOf(opcoes11, cav13.ToString());
                                                        int hn = Array.IndexOf(opcoes11, cav14.ToString());
                                                        int ho = Array.IndexOf(opcoes11, cav15.ToString());

                                                        if (selectedIndex11 == ha)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav1.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hb)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav2.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hc)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav3.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hd)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav4.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == he)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav5.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hf)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav6.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hg)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav7.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hh)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav8.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hi)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav9.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hj)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav10.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hk)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav11.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hl)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav12.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hm)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav13.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == hn)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav14.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                        if (selectedIndex11 == ho)
                                                        {
                                                            calendario.AvançarDia();
                                                            if (equipa1.Team.Contains(fun13) || equipa1.Team.Contains(fun14))
                                                            {
                                                                Console.Clear();
                                                                cav15.Visita();
                                                                Console.ReadKey(true);
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                Console.WriteLine("Impossivel ter este cavalo aberto para visitas");
                                                                Console.WriteLine("Contrata um relações públicas");
                                                                Console.ReadKey(true);
                                                            }
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        Console.WriteLine("É DIA DE CORRIDA!!");
                                                        Console.ReadKey(true);
                                                        break;
                                                    }
                                                } while (selectedIndex11 != est1.Tropa.Count);
                                                break;
                                            case 5:
                                                if (calendario.Dia == 7)
                                                {
                                                    string prompt9 = @"
 -------------------+--+--+--+--+--
                    |  |##|  |##|
                    |  |##|  |##|
                    +--+--+--+--+
                    |##|  |##|  |
                    |##|  |##|  |
                    +--+--+--+--+
                    |  |##|  |##|
                    |  |##|  |##|
                    +--+--+--+--+
                    |##|  |##|  |
                    |##|  |##|  |
                    +--+--+--+--+

Escolha o cavalo para competir!
";

                                                    int i5 = 0;
                                                    string[] opcoes9 = new string[est1.Tropa.Count + 1];
                                                    foreach (Cavalo c in est1.Tropa)
                                                    {
                                                        opcoes9[i5] = c.ToString();
                                                        i5++;
                                                    }
                                                    opcoes9[i5] = "Voltar";

                                                    Menu menuCorrida = new Menu(prompt9, opcoes9);
                                                    selectedIndex9 = menuCorrida.Run();

                                                    int fa = Array.IndexOf(opcoes9, cav1.ToString());
                                                    int fb = Array.IndexOf(opcoes9, cav2.ToString());
                                                    int fc = Array.IndexOf(opcoes9, cav3.ToString());
                                                    int fd = Array.IndexOf(opcoes9, cav4.ToString());
                                                    int fe = Array.IndexOf(opcoes9, cav5.ToString());
                                                    int ff = Array.IndexOf(opcoes9, cav6.ToString());
                                                    int fg = Array.IndexOf(opcoes9, cav7.ToString());
                                                    int fh = Array.IndexOf(opcoes9, cav8.ToString());
                                                    int fi = Array.IndexOf(opcoes9, cav9.ToString());
                                                    int fj = Array.IndexOf(opcoes9, cav10.ToString());
                                                    int fk = Array.IndexOf(opcoes9, cav11.ToString());
                                                    int fl = Array.IndexOf(opcoes9, cav12.ToString());
                                                    int fm = Array.IndexOf(opcoes9, cav13.ToString());
                                                    int fn = Array.IndexOf(opcoes9, cav14.ToString());
                                                    int fo = Array.IndexOf(opcoes9, cav15.ToString());

                                                    if (selectedIndex9 == fa)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav1, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fb)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav2, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fc)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav3, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fd)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav4, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fe)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav5, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == ff)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav6, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fg)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav7, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fh)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav8, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fi)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav9, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fj)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav10, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fk)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav11, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fl)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav12, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fm)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav13, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fn)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav14, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                    if (selectedIndex9 == fo)
                                                    {
                                                        calendario.AvançarDia();
                                                        if (equipa1.Team.Contains(fun2) || equipa1.Team.Contains(fun4))
                                                        {
                                                            Console.Clear();
                                                            Corrida.Resultado(cav15, p1);
                                                            Console.ReadKey(true);
                                                        }
                                                        else
                                                        {
                                                            Console.Clear();
                                                            Console.WriteLine("Nao podes correr porque não tens um joquei!");
                                                            Console.ReadKey(true);
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Não é dia de corrida!");
                                                    Console.ReadKey(true);
                                                }
                                                break;
                                        }
                                    } while (selectedIndex6 != 6);



                                    break;
                                case 2:
                                    Console.Clear();
                                    equipa1.InfoEquipa();
                                    Console.ReadKey(true);
                                    break;
                                case 3:
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
                                                        opcoes3[i2] = c.Nome+ ", tem "+ c.Popularidade+" de popularidade" + " e custa " + c.Preco;
                                                        i2++;
                                                    }
                                                    opcoes3[i2] = "Voltar";

                                                    Menu menuMercadoCavalos = new Menu(prompt3, opcoes3);

                                                    selectedIndex3 = menuMercadoCavalos.Run();

                                                    int aa = Array.IndexOf(opcoes3, cav1.Nome + ", tem " + cav1.Popularidade + " de popularidade" + " e custa " + cav1.Preco);
                                                    int ab = Array.IndexOf(opcoes3, cav2.Nome + ", tem " + cav2.Popularidade + " de popularidade" + " e custa " + cav2.Preco);
                                                    int ac = Array.IndexOf(opcoes3, cav3.Nome + ", tem " + cav3.Popularidade + " de popularidade" + " e custa " + cav3.Preco);
                                                    int ad = Array.IndexOf(opcoes3, cav4.Nome + ", tem " + cav4.Popularidade + " de popularidade" + " e custa " + cav4.Preco);
                                                    int ae = Array.IndexOf(opcoes3, cav5.Nome + ", tem " + cav5.Popularidade + " de popularidade" + " e custa " + cav5.Preco);
                                                    int af = Array.IndexOf(opcoes3, cav6.Nome + ", tem " + cav6.Popularidade + " de popularidade" + " e custa " + cav6.Preco);
                                                    int ag = Array.IndexOf(opcoes3, cav7.Nome + ", tem " + cav7.Popularidade + " de popularidade" + " e custa " + cav7.Preco);
                                                    int ah = Array.IndexOf(opcoes3, cav8.Nome + ", tem " + cav8.Popularidade + " de popularidade" + " e custa " + cav8.Preco);
                                                    int ai = Array.IndexOf(opcoes3, cav9.Nome + ", tem " + cav9.Popularidade + " de popularidade" + " e custa " + cav9.Preco);
                                                    int aj = Array.IndexOf(opcoes3, cav10.Nome + ", tem " + cav10.Popularidade + " de popularidade" + " e custa " + cav10.Preco);
                                                    int ak = Array.IndexOf(opcoes3, cav11.Nome + ", tem " + cav11.Popularidade + " de popularidade" + " e custa " + cav11.Preco);
                                                    int al = Array.IndexOf(opcoes3, cav12.Nome + ", tem " + cav12.Popularidade + " de popularidade" + " e custa " + cav12.Preco);
                                                    int am = Array.IndexOf(opcoes3, cav13.Nome + ", tem " + cav13.Popularidade + " de popularidade" + " e custa " + cav13.Preco);
                                                    int an = Array.IndexOf(opcoes3, cav14.Nome + ", tem " + cav14.Popularidade + " de popularidade" + " e custa " + cav14.Preco);
                                                    int ao = Array.IndexOf(opcoes3, cav15.Nome + ", tem " + cav15.Popularidade + " de popularidade" + " e custa " + cav15.Preco);

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
                                                    opcoes5[i] = c.ToString() +" , esta a valer " + (c.Preco - 100);
                                                    i++;
                                                }
                                                opcoes5[i] = "Voltar";

                                                Menu menuMercadoVenderCavalos = new Menu(prompt5, opcoes5);

                                                selectedIndex5 = menuMercadoVenderCavalos.Run();

                                                int ca = Array.IndexOf(opcoes5, cav1.ToString()+ " , esta a valer " + (cav1.Preco - 100));
                                                int cb = Array.IndexOf(opcoes5, cav2.ToString()+ " , esta a valer " + (cav2.Preco - 100));
                                                int cc = Array.IndexOf(opcoes5, cav3.ToString()+ " , esta a valer " + (cav3.Preco - 100));
                                                int cd = Array.IndexOf(opcoes5, cav4.ToString() + " , esta a valer " + (cav4.Preco - 100));
                                                int ce = Array.IndexOf(opcoes5, cav5.ToString() + " , esta a valer " + (cav5.Preco - 100));
                                                int cf = Array.IndexOf(opcoes5, cav6.ToString() + " , esta a valer " + (cav6.Preco - 100));
                                                int cg = Array.IndexOf(opcoes5, cav7.ToString() + " , esta a valer " + (cav7.Preco - 100));
                                                int ch = Array.IndexOf(opcoes5, cav8.ToString() + " , esta a valer " + (cav8.Preco - 100));
                                                int ci = Array.IndexOf(opcoes5, cav9.ToString() + " , esta a valer " + (cav9.Preco - 100));
                                                int cj = Array.IndexOf(opcoes5, cav10.ToString() + " , esta a valer " + (cav10.Preco - 100));
                                                int ck = Array.IndexOf(opcoes5, cav11.ToString() + " , esta a valer " + (cav11.Preco - 100));
                                                int cl = Array.IndexOf(opcoes5, cav12.ToString() + " , esta a valer " + (cav12.Preco - 100));
                                                int cm = Array.IndexOf(opcoes5, cav13.ToString() + " , esta a valer " + (cav13.Preco - 100));
                                                int cn = Array.IndexOf(opcoes5, cav14.ToString() + " , esta a valer " + (cav14.Preco - 100));
                                                int co = Array.IndexOf(opcoes5, cav15.ToString() + " , esta a valer " + (cav15.Preco - 100));

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
                                case 4:
                                    Console.Clear();
                                    Console.WriteLine(@"
___________________________________
|#######====================#######|
|#(1)*****HORSE MONEY BANK*****(1)#|
|#**               ,--,         **#|
|*#          _ ___/ /\|          #*|
|            ;( )__, )             |
|#*                              #*|
|#*  ******               ******  #|
|#(1)                          (1)#|
|##==============================##|
------------------------------------");
                                    Console.WriteLine(p1.ToString());
                                    Console.ReadKey(true);
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