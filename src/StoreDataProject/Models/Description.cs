using StoreDataProject.Interfaces;

namespace StoreDataProject.Models
{
    public class Description : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductDescription { get; set; }

        public Description(int productId, string productDescription)
        {
            ProductId = productId;
            ProductDescription = productDescription;
        }

        public override string ToString()
        {
            return $"ID: {Id} | ProductID: {ProductId} | Description: {ProductDescription}";
        }
    }
}
