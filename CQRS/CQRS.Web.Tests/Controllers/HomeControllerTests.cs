using CQRS.Web.Controllers;
using NUnit.Framework;

namespace CQRS.Web.Tests.Controllers
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
