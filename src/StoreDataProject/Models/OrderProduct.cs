using System;
using System.Collections.Generic;
using System.Text;

namespace StoreDataProject.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public OrderProduct(int orderId, int productId)
        {
            OrderId = orderId;
            ProductId = productId;
        }

        public override string ToString()
        {
            return $"ID: {Id} | OrderId: {OrderId} | ProductId: {ProductId}";
        }
    }
}
