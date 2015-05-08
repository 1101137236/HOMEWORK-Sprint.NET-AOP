using KuasCore.Dao;
using KuasCore.Models;
using KuasCore.Services;
using KuasCore.Services.Impl;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using System;

namespace KuasCoreTests.Services.Impl
{
     [TestClass]
    class KuasCoreServiceUnitTest : AbstractDependencyInjectionSpringContextTests
    {
        public IKuasCoreService KuasCoreService { get; set; }

        [TestMethod]
        public void TestKuasCoreService_GetCoreByName()
        {
            MyCore core = KuasCoreService.GetCoreByName("微積分");
            Assert.IsNotNull(core);

            Console.WriteLine("課程編號為 = " + core.CourseID);
            Console.WriteLine("課程名稱為 = " + core.CourseName);
            Console.WriteLine("課程描述為 = " + core.CourseDescription);
        }
    }
}
