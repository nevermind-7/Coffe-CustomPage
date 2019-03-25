using System.Collections.Generic;

namespace CustomPage.Repositories.Contacts.Commons
{
    public interface IRepository<T> where T : class, IEntity
    {
        void Create(T entity);

        IEnumerable<T> GetAll();
    }
}