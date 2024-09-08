using System;
using System.Collections.Generic;

class Estacionamento
{
    // Lista para armazenar os veículos
    private List<string> veiculos = new List<string>();

    // Valor inicial e por hora
    private decimal valorInicial = 5.00m;
    private decimal valorPorHora = 3.00m;

    // Método para adicionar veículo
    public void AdicionarVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para estacionar:");
        string placa = Console.ReadLine();
        veiculos.Add(placa.ToUpper());
        Console.WriteLine($"Veículo com placa {placa.ToUpper()} foi adicionado.");
    }

    // Método para remover veículo e calcular o valor a pagar
    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = Console.ReadLine().ToUpper();

        // Verifica se o veículo existe
        if (veiculos.Contains(placa))
        {
            Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
            int horas = int.Parse(Console.ReadLine());

            decimal valorTotal = valorInicial + (valorPorHora * horas);
            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o valor total foi de: R${valorTotal:F2}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
        }
    }

    // Método para listar os veículos estacionados
    public void ListarVeiculos()
    {
        if (veiculos.Count > 0)
        {
            Console.WriteLine("Os veículos estacionados são:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}

class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.WriteLine("\nEscolha uma opção:");
            Console.WriteLine("1 - Adicionar veículo");
            Console.WriteLine("2 - Remover veículo");
            Console.WriteLine("3 - Listar veículos");
            Console.WriteLine("4 - Encerrar");

            switch (Console.ReadLine())
            {
                case "1":
                    estacionamento.AdicionarVeiculo();
                    break;
                case "2":
                    estacionamento.RemoverVeiculo();
                    break;
                case "3":
                    estacionamento.ListarVeiculos();
                    break;
                case "4":
                    exibirMenu = false;
                    Console.WriteLine("Encerrando o programa.");
                    break;
                default:
                    Console.WriteLine("Opção inválida! Escolha uma opção válida.");
                    break;
            }
        }
    }
}
