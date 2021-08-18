using EOA.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EOA.Service
{
    public interface IMenuService
    {
        Task<int> Add(Menu menu);
        Task<int> Del(long id);
        Task<int> Edit(Menu menu);
    }
}
