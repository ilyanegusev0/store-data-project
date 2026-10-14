using StoreDataProject.Interfaces;

namespace StoreDataProject.Models
{
    public class OrderProduct : IEntity
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
