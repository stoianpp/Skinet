using Core.Entities;
using Core.Specifications;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public Task<IReadOnlyList<ProductBrand>> GetBrands();
        public Task<IReadOnlyList<ProductType>> GetTypes();
        public Task<T> GetEntityWithSpec(ISpecification<T> spec);
        public Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec);
    }
}
