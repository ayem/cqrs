using CQRS.Web.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Web.Tests
{
    [TestFixture]
    public class HomeControllerTests
    {
        [Test]
        public void Get_SaysHello()
        {
            var sut = new HomeController();
            Assert.AreEqual("CQRS API - Hello World", sut.Get());
        }
    }
}
