 class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 15;
            Pessoa[] p = new Pessoa[TAM];
            int c = 0;
            int op = 0;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        p[c++] = cadastrarPessoa();
                        break;
                    case 2:
                        listarPessoas(p, c);
                        break;
                    case 3:
                        exibirMediaPesoIdeal(p, "MASCULINO", c);
                        break;
                    case 4:
                        exibirMediaPesoIdeal(p, "FEMININO", c);
                        break;
                    case 0: break;

                    default: Console.WriteLine("Opção inválida."); break;
                }
                Console.SetCursorPosition(50, 20);
                Console.Write("Tecle algo para continuar");
                Console.ReadKey();
            } while (op != 0); 
            
        }
        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("1-Cadastrar\n2-Listar todas as pessoas\n3-Média do Peso Ideal dos Homens\n4-Média do Peso Ideal das Mulheres\n0-Sair");
            Console.WriteLine("\nDigite uma opção");
            return int.Parse(Console.ReadLine());
        }
        public static Pessoa cadastrarPessoa()
        {
            Console.Clear();
            Console.Write("Digite o nome da pessoa: ");
            string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}: ",n);
            int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}: ", n);
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite o seu Peso: ");
            double pe = double.Parse(Console.ReadLine());
            Console.Write("Digite a letra correspondente ao sexo (F/M): ");
            string s = Console.ReadLine();

            return new Pessoa(n, i, a, pe, s);
        }
        public static void exibirMediaPesoIdeal(Pessoa[] p, string sx, int t)
        {
            double soma = 0;
            int cont = 0;
            for(int x = 0; x < t; x++)
            {
                if ((p[x].Sexo).Equals(sx))
                {
                    soma += p[x].calcularPesoIdeal();
                    cont++;
                }
            }
            Console.WriteLine("Média do peso ideal - {0}: {1}", sx, soma / cont);
        }
        public static void listarPessoas(Pessoa[] ps, int cp)
        {
            Console.Clear();
            Console.WriteLine("\n\n*** Dados da Pessoa ***\n");
            for (int x = 0; x < cp; x++)
                Console.WriteLine(ps[x].ToString());
        }
    }
}
