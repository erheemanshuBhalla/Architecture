using Architecture_V4.Core.Entities;

namespace Architecture_V4.Core.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        Task<IEnumerable<Product>> GetProductsInStockAsync();
    }

}
