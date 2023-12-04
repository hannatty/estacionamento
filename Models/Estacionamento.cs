using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace fundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();

            if (placa != null && placa != ""){
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"Veículo de placa {placa} cadastrado com sucesso.");
            } else {
                Console.WriteLine("Conteúdo digitado inválido. Tente Novamente");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

            string userInput;
            int horas;
            decimal valorTotal = 0;

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                while (true){
                    Console.WriteLine("Digite o número de horas que o veículo permaneceu estacionado:" );
                    userInput = Console.ReadLine();
                    if (int.TryParse(userInput, out horas)){
                    valorTotal = precoInicial + precoPorHora*horas;
                        break;
                    } else {
                        Console.WriteLine("Número de horas informado é inválido. Tente novamente...");
                    }
                }
                
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"VEÍCULO REMOVIDO. Preço Total foi de R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                Console.WriteLine("Os veículos estacionados são:");
                for(int counter = 0; counter < veiculos.Count; counter++ ){
                    Console.WriteLine(veiculos[counter]);

                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
