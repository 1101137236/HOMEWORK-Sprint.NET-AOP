using KuasCore.Models;
using Spring.Data.Generic;
using System.Data;

namespace KuasCore.Dao.Mapper
{
    class KuasCoreRowMapper : IRowMapper<MyCore>
    {
        public MyCore MapRow(IDataReader dataReader, int rowNum)
        {
            MyCore target = new MyCore();

            target.CourseID = dataReader.GetString(dataReader.GetOrdinal("CourseID"));
            target.CourseName = dataReader.GetString(dataReader.GetOrdinal("CourseName"));
            target.CourseDescription = dataReader.GetInt32(dataReader.GetOrdinal("CourseDescription"));

            return target;
        }
    }
}
