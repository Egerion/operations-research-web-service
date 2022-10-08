using ORMonll.Config;
using ORMonll.Entity;
using Quickwire.Attributes;

namespace ORMonll.Repository
{
    [RegisterService]
    public class UserRepository
    {
        [InjectService] private ApplicationDbContext _applicationDbContext { get; init; }

        public User findById(long Id)
        {
            return _applicationDbContext.ORM_USER.FirstOrDefault(u => u.Id == Id);
        }

        public User findByEmailAndPassword(string email, string password)
        {
            return _applicationDbContext.ORM_USER.FirstOrDefault(u => u.Email == email && u.Password == password);
        }

        public void deleteById(long Id)
        {
            var user = findById(Id);
            if (user == null)
            {
                return;
            }

            delete(user);
        }

        public void delete(User user)
        {
            _applicationDbContext.ORM_USER.Remove(user);
            _applicationDbContext.SaveChanges();
        }

        public void update(User user)
        {
            _applicationDbContext.ORM_USER.Update(user);
            _applicationDbContext.SaveChanges();
        }

        public User create(User user)
        {
            _applicationDbContext.ORM_USER.Add(user);
            _applicationDbContext.SaveChanges();
            return user;
        }
    }
}