using BlogSite.DataAccess.Repositories;
using BlogSite.Entities;

namespace BlogSite.Business
{
    public class UserManager : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetByUsername(string username)
        {
            return _userRepository.GetByUsername(username);
        }
    }

    public interface IUserService
    {
        User GetByUsername(string username);
    }
}
