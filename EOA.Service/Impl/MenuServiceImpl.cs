using EOA.Entity;
using EOA.Helper;
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

        public async Task<Menu> GetMenuById(long id)
        {
            return await _menuRepository.GetMenuById(id);
        }

        public async Task<List<Menu>> ListMenu()
        {
            List<Menu> menus = await _menuRepository.ListMenus();
            var data = menus.ToTree<Menu>((r, c) =>
            {
                return c.ParentId == 0;
            }, (r, c) =>
            {
                return c.ParentId == r.MenuId;
            }, (r, dataList) =>
            {
                r.Children = r.Children ?? new List<Menu>();
                r.Children.AddRange(dataList);
            });
            return data;
        }
    }
}
