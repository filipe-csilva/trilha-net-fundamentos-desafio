namespace DesafioFundamentos.Models
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
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite a placa do veículo para estacionar: ");
            string placa = Console.ReadLine().ToUpper();

            veiculos.Add(placa);

            Console.Clear();
            Console.WriteLine($"Veículo com a placa {placa} cadastrado com sucesso!\n");
        }

        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine().ToUpper();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

                int horas = int.Parse(Console.ReadLine());

                decimal valorTotal = precoInicial + (precoPorHora * horas); 

                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:\n");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
