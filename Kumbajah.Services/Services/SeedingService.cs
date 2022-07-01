using Kumbajah.Domain.Entities;
using Kumbajah.Infra.Context;
using System.Linq;

namespace Kumbajah.Services.Services
{
    public class SeedingService
    {
        private new KumbajahContext Context { get; }

        public SeedingService(KumbajahContext context)
        {
            Context = context;
        }

        public void Seed()
        {
            if (Context.Products.Any() ||
                Context.Users.Any() ||
                Context.Order.Any() ||
                Context.Addresses.Any() ||
                Context.OrderItems.Any() ||
                Context.OrderStatus.Any() ||
                Context.Categories.Any() ||
                Context.Brands.Any() ||
                Context.Colors.Any() ||
                Context.Stocks.Any())
            {
                return;
            }

            var c1 = new Color("Azul");
            var c2 = new Color("Cinza");
            var c3 = new Color("Rosa");
            var c4 = new Color("Verde");
            var c5 = new Color("Roxo");

            var ca1 = new Category("Bong");
            var ca2 = new Category("Seda");
            var ca3 = new Category("Slick");
            var ca4 = new Category("Case");
            var ca5 = new Category("Pipe");

            var b1 = new Brand("Raw");
            var b2 = new Brand("4i20");
            var b3 = new Brand("Smooking");
            var b4 = new Brand("Bem Bolado");
            var b5 = new Brand("Zomo");

            var os1 = new OrderStatus("Pago");
            var os2 = new OrderStatus("Arguardando Postagem");
            var os3 = new OrderStatus("Pedido Enviado");
            var os4 = new OrderStatus("Pedido em Rota de Entrega");
            var os5 = new OrderStatus("Produto Entregue");
            var os6 = new OrderStatus("Cancelado");

            //var a1 = new Address("22790-510", "Rua Desembargador Paulo Alonso", "Rio de Janeiro", "Rio de Janeiro", "RJ", 510, "rua esquina com a gilka", "apto 303");
            //var a2 = new Address("22790-701", "Rua Werneck da Silva", "Rio de Janeiro", "Rio de Janeiro", "RJ", 11, "do lado do prezunic", "bl 2/903");
            //var a3 = new Address("01311-000", "Avenida Paulista", "São Paulo", "São Paulo", "SP", 02, "do lado da droga raia");
            //var a4 = new Address("82590-300", "Rua Ernesto de Araújo", "Paraná", "Curitiba", "PR", 12, "perto do Kharina");
            //var a5 = new Address("20765-630", "Rua Ari Almeida", "Minas de Gerais", "Belo Horizonte", "MG", 103, "em frente ao jota lennon", "casa 2b");

            //falta Order, OrderItem, Stock, Products, Users
            Context.Colors.AddRange(c1, c2, c3, c4, c5);
            Context.Categories.AddRange(ca1, ca2, ca3, ca4, ca5);
            Context.OrderStatus.AddRange(os1, os2, os3, os4, os5, os6);
            //Context.Addresses.AddRange(a1, a2, a3, a4, a5);
            Context.Brands.AddRange(b1, b2, b3, b4, b5);

            Context.SaveChanges();
        }
    }
}
