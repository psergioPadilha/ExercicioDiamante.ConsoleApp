namespace ExercicioDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("PROGRAMA DIAMANTE");

                //input
                Console.WriteLine("Digite um valor ímpar: ");
                int numeroImpar = int.Parse(Console.ReadLine());

                GerarDiamante(numeroImpar);

                Console.ReadLine();
            }
        }

        private static void GerarDiamante(int numeroImpar)
        {
            //fazendo a parte superior do diamante
            for (int i = 1; i <= numeroImpar; i += 2)
            {
                //espacamento antes do x
                for (int j = 0; j < (numeroImpar - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                //imprimindo o x
                for (int k = 0; k < i; k++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

            //desenhando a parte de baixo do diamante
            for (int i = numeroImpar - 2; i > 0; i -= 2)
            {
                //fazendo o espaçamento
                for (int j = 0; j < (numeroImpar - i) / 2; j++)
                {
                    Console.Write(" ");
                }

                //desenhando os "x"
                for (int j = 0; j < i; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}
