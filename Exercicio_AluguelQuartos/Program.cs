namespace Exercicio_AluguelQuartos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de gerenciamento de aluguel dos quartos");

            Console.Write("\nQuantos quartos serão alugados? ");
            int qtde = int.Parse(Console.ReadLine());

            Estudante[] estudantes = new Estudante[10];

            for (int i = 0; i < qtde; i++)
            {
                Console.WriteLine();
                Console.Write($"Nome do Estudante #{i + 1}: ");
                string nome = Console.ReadLine();

                Console.Write("E-mail: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                estudantes[quarto] = new Estudante(nome, email);

            }

            Console.WriteLine("\nQuartos Ocupados:");
            for (int i = 0; i < estudantes.Length; i++)
            {
                if (estudantes[i] != null)
                    Console.WriteLine($"{i}: {estudantes[i]}");
            }

        }
    }
}