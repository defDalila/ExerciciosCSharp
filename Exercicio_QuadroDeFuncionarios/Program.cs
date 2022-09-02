namespace Exercicio_ListagemFuncionarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerenciamento de Funcionários");
            Console.WriteLine();

            Console.Write("Quantos funcionários deseja registrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < quantidade; i++)
            {

                Console.WriteLine();
                Console.WriteLine($"Funcionário #{i + 1}:");
                int id = 0;
                

                while (true)
                {
                    Console.Write("ID: ");
                    int idTeste = int.Parse(Console.ReadLine());

                    bool idEmUso = funcionarios.Exists(funcionario => funcionario.Id == idTeste);

                    if (idEmUso)
                    {
                        Console.WriteLine("Este ID já está em uso! Insira um ID diferente...");
                        continue;
                    }

                    else
                        id = idTeste;
                        break;
                }
                

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionario(id, nome, salario));

            }

            Console.WriteLine();
            Console.Write("Entre com o ID do funcionário que ganhará aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            int posicao = funcionarios.FindIndex(funcionario => funcionario.Id == idAumento);

            if (posicao == -1)
            {
                Console.WriteLine("ID não encontrado!");
            }
            else
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine());

                funcionarios[posicao].AumentarSalario(porcentagem);
            }

                

            Console.WriteLine();
            Console.WriteLine("Quadro de funcionários atualizado: ");

            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine(funcionario);
            }
        }
    }
}