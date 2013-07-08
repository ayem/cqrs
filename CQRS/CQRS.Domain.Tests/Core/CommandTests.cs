using CQRS.Domain.Core;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Core
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void DefaultValidationResult_Passess()
        {
            var expected = new ValidationResult {IsValid = true};
            var sut = new CommandFake();

            var actual = sut.Validate();

            Assert.AreEqual(expected, actual);
        }
    }

    internal class CommandFake : Command
    {
        public override void Execute(Data.IDbContext context)
        {
        }
    }
}
