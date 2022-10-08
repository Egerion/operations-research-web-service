using Microsoft.Extensions.DependencyInjection;
using ORMonll.Repository;
using Quickwire.Attributes;

namespace ORMonll.Service
{
    [RegisterService]
    public class UserService
    {
        [InjectService] private UserRepository userRepository { get; init; }
    }
}