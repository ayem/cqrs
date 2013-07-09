using System.Collections.Generic;
using System.Data.Entity;
using CQRS.Domain.Commands;
using CQRS.Domain.Core;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Commands
{
    [TestFixture]
    public class AddDashboardCommandTests
    {
        [Test]
        public void ValidateFails_NoDashboardTitle()
        {
            var expectedResult = new ValidationResult
                {
                    IsValid = false,
                    ErrorMessages = new List<string> {"Dashboard needs a title"}
                };

            var sut = new AddDashboardCommand(new Dashboard());
            var result = sut.Validate();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ValidationPasses_WithValidDashboard()
        {
            var sut = new AddDashboardCommand(new Dashboard {Title = "hello"});
            var result = sut.Validate();

            Assert.AreEqual(new ValidationResult {IsValid = true}, result);
        }

        [Test]
        public void Execute_AddsToContext()
        {
            var dashboard = new Dashboard {Title = "dsdf"};
            var sut = new AddDashboardCommand(dashboard);
            var contextMock = new Mock<IDbContext>();
            var dbSetMock = new Mock<IDbSet<Dashboard>>();
            contextMock.Setup(x => x.Item<Dashboard>()).Returns(dbSetMock.Object);

            sut.Execute(contextMock.Object);  

            dbSetMock.Verify(x => x.Add(dashboard), Times.Once());
        }
    }
}
