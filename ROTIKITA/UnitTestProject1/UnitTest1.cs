using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ROTIKITA;
using ROTIKITA.Controller;
using ROTIKITA.Contracts;
using ROTIKITA.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var users = new DbC
            bool isLogin = UserHandler.LoginHandler("Kasir00001", "kasir");
            Assert.IsTrue(isLogin);
        }
    }
}
