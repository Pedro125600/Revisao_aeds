namespace att3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine("MENU DE OPERAÇÕES");
                Console.WriteLine("1 - Somar dois números");
                Console.WriteLine("2 - O maior de dois números");
                Console.WriteLine("3 - Somar N números");
                Console.WriteLine("4 - Contador de pares de uma sequência");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        SomarDoisNumeros();
                        break;
                    case 2:
                        MaiorDeDoisNumeros();
                        break;
                    case 3:
                        SomarNNumeros();
                        break;
                    case 4:
                        ContadorPares();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
                Console.WriteLine();
            } while (opcao != 0);
        }

        static void SomarDoisNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Soma: " + (a + b));
        }

        static void MaiorDeDoisNumeros()
        {
            Console.Write("Digite o primeiro número: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Maior número: " + Math.Max(a, b));
        }

        static void SomarNNumeros()
        {
            Console.Write("Quantos números deseja somar? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Soma total: " + soma);
        }

        static void ContadorPares()
        {
            Console.Write("Quantos números deseja inserir? ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um número: ");
                int nun = int.Parse(Console.ReadLine());
                if (nun % 2 == 0)
                    count++;
            }
            Console.WriteLine("Quantidade de números pares: " + count);
        }
    }
}