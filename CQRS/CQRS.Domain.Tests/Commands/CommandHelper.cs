using System.Data.Entity;
using CQRS.Domain.Data;
using Moq;

namespace CQRS.Domain.Tests.Commands
{
    internal class CommandHelper<T> where T : class
    {
        public CommandHelper()
        {
            this.DbContextMock = new Mock<IDbContext>();
            this.DbSetMock = new Mock<IDbSet<T>>();
            this.DbContextMock.Setup(x => x.Item<T>()).Returns(this.DbSetMock.Object);
        }

        public Mock<IDbSet<T>> DbSetMock { get; set; }

        public IDbSet<T> DbSet
        {
            get { return this.DbSetMock.Object; }
        }

        public Mock<IDbContext> DbContextMock { get; set; }

        public IDbContext DbContext
        {
            get { return this.DbContextMock.Object; }
        }
    }
}