using CQRS.Domain.Commands;
using CQRS.Domain.Core;
using CQRS.Domain.Entities;
using CQRS.Domain.Queries;
using CQRS.Web.Controllers;
using Moq;
using NUnit.Framework;

namespace CQRS.Web.Tests.Controllers
{
    [TestFixture]
    public class DashboardControllerTests
    {
        private Mock<ICommandHandler> commandMock;
        private Mock<IQueryHandler> queryMock;
        private DashboardController sut;

        [SetUp]
        public void Setup()
        {
            this.commandMock = new Mock<ICommandHandler>();
            this.queryMock = new Mock<IQueryHandler>();
            this.sut = new DashboardController(this.commandMock.Object, this.queryMock.Object);
        }

        [Test]
        public void Get_CallsGetAllQuery()
        {
            this.sut.Get();
            this.queryMock.Verify(x => x.Handle(It.IsAny<GetAllQuery<Dashboard>>()), Times.Once());
        }

        [Test]
        public void Post_UsesCreateDashboardCommand()
        {
            // Arrange
            var dashboard = new Dashboard { Title = "shane was here" };

            // Act
            var updated = this.sut.Post(dashboard);

            // Verify the add command called and the dashboard is returned
            this.commandMock.Verify(x =>
                x.Execute(It.Is<CreateDashboardCommand>(d => d.Dashboard.Equals(dashboard))), Times.Once());
            Assert.AreEqual(dashboard, updated);
        }

        [Test]
        public void Put_UsesUpdateDashboardCommand()
        {
            // Arrange
            var dashboard = new Dashboard { Title = "shane was here" };

            // Act
            var updated = this.sut.Put(dashboard);

            // Verify the add command called and the dashboard is returned
            this.commandMock.Verify(x =>
                x.Execute(It.Is<UpdateDashboardCommand>(d => d.Dashboard.Equals(dashboard))), Times.Once());
            Assert.AreEqual(dashboard, updated);
        }
    }
}
