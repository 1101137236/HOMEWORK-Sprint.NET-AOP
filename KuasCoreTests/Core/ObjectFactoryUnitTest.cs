using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spring.Testing.Microsoft;
using KuasCore.Models;
using KuasCore.Services.Impl;
using Core;
using Spring.Context;
using Spring.Context.Support;

namespace KuasCoreTests.Core
{
    [TestClass]
    public class ObjectFactoryUnitTest : AbstractDependencyInjectionSpringContextTests
    {

        #region Spring 單元測試必寫的內容

        override protected string[] ConfigLocations
        {
            get
            {
                return new String[] { 
                    //assembly://MyAssembly/MyNamespace/ApplicationContext.xml
                    "~/Config/KuasCoreDatabase.xml",
                    "~/Config/KuasCoreTests.xml" 
                };
            }
        }

        #endregion

        [TestMethod]
        public void TestObjectFactory_GetApplicationContext()
        {

            // 利用 Spring Object Name 來依賴尋找找出我們要的 Spring Object.
            IApplicationContext applicationContext = ObjectFactory.GetApplicationContext();
            KuasCoreService kuasCoreService = (KuasCoreService)applicationContext["kuasCoreService"];

            MyCore core = kuasCoreService.GetCoreByName("微積分");
            Assert.IsNotNull(core);

            Console.WriteLine("課程編號為 = " + core.CourseID);
            Console.WriteLine("課程名稱為 = " + core.CourseName);
            Console.WriteLine("課程描述為 = " + core.CourseDescription);

        }

        [TestMethod]
        public void TestObjectFactory_GetObject()
        {

            // 利用 Spring Object Name 來依賴尋找找出我們要的 Spring Object.
            KuasCoreService kuasCoreService = (KuasCoreService)ObjectFactory.GetObject("kuasCoreService");

            MyCore core = kuasCoreService.GetCoreByName("微積分");
            Assert.IsNotNull(core);

            Console.WriteLine("課程編號為 = " + core.CourseID);
            Console.WriteLine("課程名稱為 = " + core.CourseName);
            Console.WriteLine("課程描述為 = " + core.CourseDescription);
        }

    }
}
