using ExercicioFixacaoComp.Entities;
using ExercicioFixacaoComp.Entities.Enums;
using System;

namespace ExercicioFixacaoComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de Nascimento (DD/MM/AAAA): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);


            Console.WriteLine();
            Console.WriteLine("Entre com os dados do pedido: ");
            Console.Write("Status (PagamentoPendente/Processando/Enviado/Entregue): ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            Console.Write("Qual a quantidade de itens tem nesse pedido? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Entre com os dados do produto #" + i + ": ");
                Console.Write("Nome do produto: ");
                string productname = Console.ReadLine();
                Console.Write("Preço do produto: R$");
                double productprice = double.Parse(Console.ReadLine());
                Console.Write("Quantidade: ");
                int productquantity = int.Parse(Console.ReadLine());
                Product product = new Product(productname, productprice);
                OrderItem orderItem = new OrderItem(productquantity, productprice, product);
                order.AddItems(orderItem);
            }


            Console.WriteLine();
            Console.WriteLine(order);
        }
    }
}
