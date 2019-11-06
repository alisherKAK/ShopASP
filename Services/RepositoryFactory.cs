using AbstractModels;
using Models;

namespace Services
{
    public class RepositoryFactory
    {
        public IRepository<TType> GetDbRepository<TType>() where  TType : class 
        {
            return new DbRespository<TType>();
        }
    }
}
