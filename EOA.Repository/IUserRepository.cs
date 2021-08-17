using EOA.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Repository
{
    public interface IUserRepository
    {
        Task<int> Add(User user);
        Task<int> Del(long id);
        Task<int> Edit(User user);
        
    }
}
