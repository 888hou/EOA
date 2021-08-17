using EOA.Data;
using EOA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Repository.Impl
{
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly Context _context;
        public UserRepositoryImpl(Context context)
        {
            _context = context;
        }

        public async Task<int> Add(User user)
        {
            await _context.User
                .AddAsync(user);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Del(long id)
        {
            var User = _context.User.Where(u => u.UserId == id).First();
            _context.Remove(User);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit(User user)
        {
            _context.User.Update(user);
            return await _context.SaveChangesAsync();
        }
    }
}
