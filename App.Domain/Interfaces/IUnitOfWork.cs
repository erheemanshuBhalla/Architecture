namespace Architecture_V4.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IProductRepository Products { get; }

        void Commit();
        void Rollback();
    }

}
