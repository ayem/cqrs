using CQRS.Domain.Core;
using CQRS.Domain.Data;
using Moq;
using NUnit.Framework;
using System.Linq;

namespace CQRS.Domain.Tests.Core
{
    [TestFixture]
    public class CommandHandlerTests
    {
        private CommandHandler sut;
        private Mock<IDbContext> contextMock;

        [SetUp]
        public void Setup()
        {
            this.contextMock = new Mock<IDbContext>();
            this.sut = new CommandHandler(this.contextMock.Object);
        }

        [Test]
        public void ExecuteMultiple_CallsValidateAndExecute()
        {
            var cannedValidation = new ValidationResult {IsValid = true};
            var commandMock1 = new Mock<Command>();
            var commandMock2 = new Mock<Command>();
            var commandMock3 = new Mock<Command>();
            var param = new[] {commandMock1, commandMock2, commandMock3};
            param.ToList().ForEach(c => c.Setup(x => x.Validate()).Returns(cannedValidation));

            this.sut.Execute(new[] {commandMock1.Object, commandMock2.Object, commandMock3.Object});

            commandMock1.Verify(x => x.Validate(), Times.Once());
            commandMock2.Verify(x => x.Validate(), Times.Once());
            commandMock3.Verify(x => x.Validate(), Times.Once());
            commandMock1.Verify(x => x.Execute(this.contextMock.Object), Times.Once());
            commandMock2.Verify(x => x.Execute(this.contextMock.Object), Times.Once());
            commandMock3.Verify(x => x.Execute(this.contextMock.Object), Times.Once());
            this.contextMock.Verify(x => x.SaveChanges(), Times.Once());
        }

        [Test, ExpectedException(typeof(CommandException))]
        public void InvalidCommand_ThrowsException()
        {
            var commandMock = new Mock<Command>();
            commandMock.Setup(x => x.Validate()).Returns(new ValidationResult {IsValid = false});

            this.sut.Execute(commandMock.Object);
        }
    }
}
