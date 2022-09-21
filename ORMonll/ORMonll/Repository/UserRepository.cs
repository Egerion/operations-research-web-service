using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using ORMonll.Config;
using ORMonll.Entity;
using Quickwire.Attributes;

namespace ORMonll.Repository
{
    [RegisterService(ServiceLifetime.Transient)]
    public class UserRepository : IBaseRepository<User>
    {
        [InjectService] private ApplicationDbContext applicationDbContext { get; init; }

        public User findByEmailAndPassword(long id)
        {
            return applicationDbContext.ORM_USER.FirstOrDefault(u => u.Id == id);
        }

        public List<User> findFirstNumberOf(int amount)
        {
            return applicationDbContext.ORM_USER.AsEnumerable().Take(amount).ToList();
        }

        public void deleteById(long id)
        {
            var user = applicationDbContext.ORM_USER.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return;
            }

            applicationDbContext.ORM_USER.Remove(user);
            applicationDbContext.SaveChanges();
        }

        public void update(User user)
        {
            applicationDbContext.ORM_USER.Update(user);
            applicationDbContext.SaveChanges();
        }
    }
}