using CQRS.Domain.Commands;
using CQRS.Domain.Core;
using CQRS.Domain.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CQRS.Domain.Tests.Commands
{
    [TestFixture]
    public class BaseDashboardCommandTests
    {
        [Test]
        public void ValidateFails_NoDashboardTitle()
        {
            var expectedResult = new ValidationResult
            {
                IsValid = false,
                ErrorMessages = new List<string> { "Dashboard needs a title" }
            };

            var sut = new FakeBaseDashboardCommand(new Dashboard());
            var result = sut.Validate();

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void ValidationPasses_WithValidDashboard()
        {
            var sut = new FakeBaseDashboardCommand(new Dashboard { Title = "hello" });
            var result = sut.Validate();

            Assert.AreEqual(new ValidationResult { IsValid = true }, result);
        }
    }

    public class FakeBaseDashboardCommand : BaseDashboardCommand
    {
        public FakeBaseDashboardCommand(Dashboard dashboard)
            : base(dashboard)
        {
        }

        public override void Execute(Data.IDbContext context)
        {
            throw new NotImplementedException();
        }
    }
}
