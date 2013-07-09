using System.Data.Entity;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;
using CQRS.Domain.Queries;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Queries
{
    [TestFixture]
    public class GetSingleQueryTests
    {
        [Test]
        public void GetAllQuery_GetsAllItemsInContext()
        {
            var contextMock = new Mock<IDbContext>();
            var dbSetMock = new Mock<IDbSet<Dashboard>>();
            contextMock.Setup(x => x.Item<Dashboard>()).Returns(dbSetMock.Object);

            var sut = new GetSingleQuery<Dashboard>(1);
            sut.Execute(contextMock.Object);

            dbSetMock.Verify(x => x.Find(1), Times.Once());
        }
    }
}
