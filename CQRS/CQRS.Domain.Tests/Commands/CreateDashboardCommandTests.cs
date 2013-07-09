using CQRS.Domain.Commands;
using CQRS.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Commands
{
    [TestFixture]
    public class CreateDashboardCommandTests
    {       
        [Test]
        public void Execute_AddsToContext()
        {
            var dashboard = new Dashboard {Title = "dsdf"};
            var sut = new CreateDashboardCommand(dashboard);
            var cmdHelper = new CommandHelper<Dashboard>();

            sut.Execute(cmdHelper.DbContext);  

            cmdHelper.DbSetMock.Verify(x => x.Add(dashboard), Times.Once());
        }

        [Test]
        public void Sut_IsInstanceOfBaseDashboardCommand()
        {
            var sut = new CreateDashboardCommand(new Dashboard());
            Assert.IsInstanceOf<BaseDashboardCommand>(sut);
        }
    }
}
