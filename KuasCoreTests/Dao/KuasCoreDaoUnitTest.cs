using KuasCore.Dao;
using KuasCore.Dao.Impl;
using KuasCore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KuasCoreTests.Dao
{
    [TestClass]
    class KuasCoreDaoUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        public IKuasCoreDao KuasCoreDao { get; set; }

        [TestMethod]
        public void TestEmployeeDao_GetEmployeeByName()
        {
            MyCore core = KuasCoreDao.GetCoreByName("微積分");
            Assert.IsNotNull(core);

            Console.WriteLine("課程編號為 = " + core.CourseID);
            Console.WriteLine("課程名稱為 = " + core.CourseName);
            Console.WriteLine("課程描述為 = " + core.CourseDescription);
        }
    }
}
