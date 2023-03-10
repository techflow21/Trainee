using System.Threading.Tasks;

namespace TraineeManagementApp.DAL.Repository;

public interface IUnitOfWork
{
    IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
    int SaveChanges();
    void Dispose();
    Task<int> SaveChangesAsync();
}