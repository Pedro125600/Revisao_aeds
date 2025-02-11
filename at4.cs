using System.Reflection.Metadata;

namespace att4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase para criptogravar");
            string text = Console.ReadLine();
           string resultado = criptografar(text);

            Console.WriteLine(resultado);

            Console.ReadLine();

        }

        static void MostrarMatriz(char[,] matriz) // feito para ver se esta criptogravando certinho 
        {
            int linhas = matriz.GetLength(0);
            int colunas = matriz.GetLength(1);

            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static string criptografar(string text)
        {
            int particoes = 5;
            int linhas = (text.Length / particoes) + 1;
            char[,] criptografado = new char[linhas, particoes];

            int index = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < particoes; j++)
                {
                    if (index < text.Length)
                    {
                        criptografado[i, j] = text[index];
                        index++;
                    }
                    else
                    {
                        criptografado[i, j] = ' '; 
                    }
                }
            }

     
            MostrarMatriz(criptografado);

            string resultado = "";
            for (int j = 0; j < particoes; j++)  
            {
                for (int i = 0; i < linhas; i++)
                {
                    resultado += criptografado[i, j];
                }
                if (j < particoes - 1)
                {
                    resultado += "*"; 
                }
            }

            return resultado;
        }

    }
}
