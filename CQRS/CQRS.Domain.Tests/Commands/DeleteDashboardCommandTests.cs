using CQRS.Domain.Commands;
using CQRS.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Commands
{
    [TestFixture]
    public class DeleteDashboardCommandTests
    {
        [Test]
        public void Execute_RemovesById()
        {
            var sut = new DeleteDashboardCommand(10);
            var cmdHelper = new CommandHelper<Dashboard>();

            sut.Execute(cmdHelper.DbContext);

            cmdHelper.DbSetMock.Verify(x => x.Remove(It.Is<Dashboard>(d => d.Id == 10)), Times.Once());
        }
    }
}
