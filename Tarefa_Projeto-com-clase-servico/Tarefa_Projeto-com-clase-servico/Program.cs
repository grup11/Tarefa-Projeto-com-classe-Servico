using System;
using Tarefa_Projeto_com_clase_servico.Model;

namespace Tarefa_Projeto_com_clase_servico
{
    class Program
    {
        static void Main(string[] args)
        {
            Servico servico = new Servico();
            Console.Write("Informe o nome do serviço: ");
            servico.Nome = Console.ReadLine();
            Console.Write($"Informe o preço do serviço de {servico.Nome}: ");
            servico.Preco = Console.ReadLine();
            Console.WriteLine($"Nome do serviço: {servico.Nome}\nSeu preço é: R${servico.Preco}");
        }
    }
}
