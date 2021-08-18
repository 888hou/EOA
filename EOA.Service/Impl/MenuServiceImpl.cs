using EOA.Entity;
using EOA.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Service.Impl
{
    public class MenuServiceImpl : IMenuService
    {
        private readonly IMenuRepository _menuRepository;
        public MenuServiceImpl(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public async Task<int> Add(Menu menu)
        {
            return await _menuRepository.Add(menu);
        }

        public async Task<int> Del(long id)
        {
            return await _menuRepository.Del(id);
        }

        public async Task<int> Edit(Menu menu)
        {
            return await _menuRepository.Edit(menu);
        }
    }
}
