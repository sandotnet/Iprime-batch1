using SMSAPI.Entities;
using SMSAPI.Models;

namespace SMSAPI.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly MyContext _context;

        public UserRepository(MyContext context)
        {
            _context = context;
        }

        public void Add(User entity)
        {
           _context.Users.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
        public User Validate(LoginUser loginUser)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == loginUser.Username && u.Password == loginUser.Password);
        }
    }
}
