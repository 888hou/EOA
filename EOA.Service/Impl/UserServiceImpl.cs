using EOA.Entity;
using EOA.Helper;
using EOA.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Service.Impl
{
    public class UserServiceImpl : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserServiceImpl(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<int> Add(User user)
        {
            user.Password = await MD5Helper.Md5Encoding64(user.Password);
            return await _userRepository.Add(user);
        }

        public async Task<int> Del(long id)
        {
            return await _userRepository.Del(id);
        }

        public async Task<int> Edit(User user)
        {
            return await _userRepository.Edit(user);
        }
    }
}
