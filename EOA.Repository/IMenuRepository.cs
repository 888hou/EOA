using EOA.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Repository
{
    public interface IMenuRepository
    {
        Task<int> Add(Menu menu);
        Task<int> Del(long id);
        Task<int> Edit(Menu menu);
    }
}
