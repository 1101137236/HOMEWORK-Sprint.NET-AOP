using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using System.Collections.Generic;

namespace KuasCore.Services.Impl
{
    class KuasCoreService : IKuasCoreService
    {
        public IKuasCoreDao KuasCoreDao { get; set; }

        public IList<MyCore> GetAllCores()
        {
            return KuasCoreDao.GetAllCores();
        }

        public MyCore GetCoreByName(string name)
        {
            return KuasCoreDao.GetCoreByName(name);
        }

    }
}
