namespace ORMonll.Repository
{
    public interface IBaseRepository<T>
    {
        T findById(long id);

        T findByEmailAndPassword(long id);

        List<T> findFirstNumberOf(int amount);

        void deleteById(long id);

        void update(T t);
    }
}