using KuasCore.Models;
using System;
using System.Collections.Generic;

namespace KuasCore.Dao
{
    public interface IKuasCoreDao
    {
        IList<MyCore> GetAllCores();
        MyCore GetCoreByName(string name);
    }
}
