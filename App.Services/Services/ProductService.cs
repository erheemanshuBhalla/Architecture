using Architecture_V4.Core.Entities;
using Architecture_V4.Core.Interfaces;

namespace Architecture_V4.BusinessLogic.Services
{
    public class ProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }

        public async Task<int> CreateAsync(Product product)
        {
            var id = await _unitOfWork.Products.AddAsync(product);
            _unitOfWork.Commit();
            return id;
        }

        public async Task UpdateAsync(Product product)
        {
            await _unitOfWork.Products.UpdateAsync(product);
            _unitOfWork.Commit();
        }

        public async Task DeleteAsync(int id)
        {
            await _unitOfWork.Products.DeleteAsync(id);
            _unitOfWork.Commit();
        }

        public async Task<IEnumerable<Product>> GetProductsInStockAsync()
        {
            return await _unitOfWork.Products.GetProductsInStockAsync();
        }
    }

}
