using EOA.Data;
using EOA.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Repository.Impl
{
    public class MenuRepositoryImpl : IMenuRepository
    {
        private readonly Context _context;
        public MenuRepositoryImpl(Context context)
        {
            _context = context;
        }

        public async Task<int> Add(Menu menu)
        {
            await _context.AddAsync(menu);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Del(long id)
        {
            _context.Remove(new Menu { MenuId = id });
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit(Menu menu)
        {
            _context.Update(menu);
            return await _context.SaveChangesAsync();
        }

        public Task<List<Menu>> ListMenus()
        {
            List<Menu> menus = _context.Menu
                .OrderBy(m => m.SortOrder)
                .ToList();
            return Task.FromResult<List<Menu>>(menus);
        }
    }
}
