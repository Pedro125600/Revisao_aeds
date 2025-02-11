namespace att1_Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De a largura:");
            int lar = int.Parse(Console.ReadLine());
            Console.WriteLine("De a Altura:");
            int alt = int.Parse(Console.ReadLine());

            string[,] retangulo = new string[lar,alt];


            for (int i = 0; i < retangulo.GetLength(0); i++)
            {
                for (int j = 0; j < retangulo.GetLength(1); j++)
                {
                    retangulo[i, j] = " ";
                }
            }

            for (int i = 0; i < retangulo.GetLength(0); i++)
            {
                for (int j = 0; j < retangulo.GetLength(1); j++)
                {
                    retangulo[0, j] = "x";
                    retangulo[retangulo.GetLength(0) - 1,j] = "x";
                }
                retangulo[i, 0] = "x";
                retangulo[i, retangulo.GetLength(1)-1] = "x";

            }
                
                for(int i = 0;i < retangulo.GetLength(0); i++)
            {
                for(int j = 0;j < retangulo.GetLength(1); j++)
                {
                    Console.Write(retangulo[i, j] + " ");
                }
                Console.WriteLine();
            }
                        
                   

                


            Console.ReadLine();
        }
    }
}
