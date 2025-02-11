namespace att3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            Console.WriteLine("Notas dos Exercícios:");
            total += Notas(4) * 0.20;

            Console.WriteLine("Notas das Provas:");
            total += Notas(2) * 0.60;

            Console.WriteLine("Nota do Trabalho Prático:");
            total += Notas(1) * 5;

            Console.WriteLine($"Nota final: {total:F2}");
        }

        static double Notas(int n)
        {
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nota {i + 1}: ");
                total += double.Parse(Console.ReadLine());
            }
            return total / n;
        }
    }
}
