using CQRS.Domain.Core;
using CQRS.Domain.Data;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Core
{
    [TestFixture]
    public class QueryHandlerTests
    {
        [Test]
        public void Query_Handles()
        {
            var contextMock = new Mock<IDbContext>();
            var queryMock = new Mock<Query<string>>();
            var sut = new QueryHandler(contextMock.Object);

            sut.Handle(queryMock.Object);

            queryMock.Verify(x => x.Execute(contextMock.Object), Times.Once());
        }
    }
}
