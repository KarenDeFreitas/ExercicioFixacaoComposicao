using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoComp.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }


        public OrderItem()
        {
        }


        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.Product = product;
        }


        public double SubTotal()
        {
            return Price * Quantity;
        }


        public override string ToString()
        {
            return Product
                + ", R$"
                + Price.ToString("F2")
                + ", quatidade: "
                + Quantity
                + ", subtotal: R$"
                + SubTotal().ToString("F2");
        }
    }
}
