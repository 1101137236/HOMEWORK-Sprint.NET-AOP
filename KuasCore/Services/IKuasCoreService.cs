using KuasCore.Dao;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services
{
    public interface IKuasCoreService
    {
        /// <summary>
        ///     取得所有課程資料.
        /// </summary>
        /// <returns>
        ///     所有課程資料
        /// </returns>
        IList<MyCore> GetAllCores();

        /// <summary>
        ///     依據 ID 取得課程資料.
        /// </summary>
        /// <returns>
        ///     該課程資料
        /// </returns>
        MyCore GetCoreByName(string name);
    }
}
