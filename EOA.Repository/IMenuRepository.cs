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
        #region
        /// <summary>
        /// 获取所有有效Menu，并按照SortOrder排序
        /// </summary>
        /// <returns></returns>
        Task<List<Menu>> ListMenus();
        #endregion
    }
}
