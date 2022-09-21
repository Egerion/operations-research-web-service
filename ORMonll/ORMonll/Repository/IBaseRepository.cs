using System.Collections.Generic;

namespace ORMonll.Repository
{
    public interface IBaseRepository<T>
    {
        T findByEmailAndPassword(long id);

        List<T> findFirstNumberOf(int amount);

        void deleteById(long id);

        void update(T t);
    }
}