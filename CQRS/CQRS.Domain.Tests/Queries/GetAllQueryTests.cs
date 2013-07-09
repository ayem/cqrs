using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CQRS.Domain.Data;
using CQRS.Domain.Entities;
using CQRS.Domain.Queries;
using Moq;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Queries
{
    [TestFixture]
    public class GetAllQueryTests
    {
        [Test]
        public void GetAllQuery_GetsAllItemsInContext()
        {
            var contextMock = new Mock<IDbContext>();
            var allItems = new List<Dashboard>
                {
                    new Dashboard { Title = "shane" },
                    new Dashboard { Title = "was" },
                    new Dashboard { Title = "here" },
                };
            contextMock.Setup(x => x.QueryItems<Dashboard>()).Returns(allItems.AsQueryable());  

            var sut = new GetAllQuery<Dashboard>();

            var results = sut.Execute(contextMock.Object);

            CollectionAssert.AreEqual(allItems, results);            
        }
    }
}
