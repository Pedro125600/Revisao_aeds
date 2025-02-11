namespace att5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a frase para Descriptografar");
            string text = Console.ReadLine();
            string resultado = Descriptografar(text);

            Console.WriteLine(resultado);

            Console.ReadLine();
        }

        static string Descriptografar(string textoDescriptografado)
        {
            string[] colunas = textoDescriptografado.Split('*');
            int linhas = colunas[0].Length;
            int particoes = colunas.Length;

            char[,] matriz = new char[linhas, particoes];

            for (int j = 0; j < particoes; j++)
            {
                for (int i = 0; i < linhas; i++)
                {
                    if (i < colunas[j].Length)
                    {
                        matriz[i, j] = colunas[j][i];
                    }
                    else
                    {
                        matriz[i, j] = ' '; 
                    }
                }
            }

            string resultado = "";
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < particoes; j++)
                {
                    resultado += matriz[i, j];
                }
            }

            return resultado;
        }
    }
}
