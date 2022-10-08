using ORMonll.Entity;
using ORMonll.Repository;
using Quickwire.Attributes;

namespace ORMonll.Service
{
    [RegisterService]
    public class UserService
    {
        [InjectService]
        private UserRepository userRepository { get; init; }
        
        public User findById(long Id)
        {
            return userRepository.findById(Id);
        }
        
        public User findByEmailAndPassword(string email, string password)
        {
            return userRepository.findByEmailAndPassword(email, password);
        }
        
        public void deleteById(long Id)
        {
            userRepository.deleteById(Id);
        }
        
        public void delete(User user)
        {
            userRepository.delete(user);
        }

        public void update(User user)
        {
            userRepository.update(user);
        }
        
        public User create(User user)
        {
            return userRepository.create(user);
        }
    }
}