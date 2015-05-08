
using KuasCore.Dao.Base;
using KuasCore.Dao.Mapper;
using KuasCore.Models;
using Spring.Data.Common;
using Spring.Data.Generic;
using System.Collections.Generic;
using System.Data;

namespace KuasCore.Dao.Impl
{
    class KuasCoreDao : GenericDao<MyCore>, IKuasCoreDao
    {
        //override protected IRowMapper<Employee> GetRowMapper()
        //{
        //    return new KuasCoreRowMapper();
        //}

        public IList<MyCore> GetAllCores()
        {
            string command = @"SELECT * FROM KuasCore ORDER BY CourseID ASC";
            IList<MyCore> cores = ExecuteQueryWithRowMapper(command);
            return cores;
        }

        public MyCore GetCoreByName(string name)
        {
            string command = @"SELECT * FROM KuasCore WHERE CourseName = @Name";

            IDbParameters parameters = CreateDbParameters();
            parameters.Add("CourseName", DbType.String).Value = name;

            IList<MyCore> cores = ExecuteQueryWithRowMapper(command, parameters);
            if (cores.Count > 0)
            {
                return cores[0];
            }

            return null;
        }

        protected override IRowMapper<MyCore> GetRowMapper()
        {
            throw new System.NotImplementedException();
        }
    }
}
