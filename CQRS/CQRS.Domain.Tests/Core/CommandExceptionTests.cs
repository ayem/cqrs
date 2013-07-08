using System;
using System.Collections.Generic;
using CQRS.Domain.Core;
using NUnit.Framework;

namespace CQRS.Domain.Tests.Core
{
    [TestFixture]
    public class CommandExceptionTests
    {
        [Test, ExpectedException(typeof(ArgumentException))]
        public void ArgumentException()
        {
            new CommandException(null);
        }

        [Test]
        public void MessageIsErrorMessages()
        {
            var result = new ValidationResult
                {
                    ErrorMessages = new List<string>
                        {
                            "hi", "im", "shane", "gray"
                        }
                };

            var exception = new CommandException(result);

            Assert.AreEqual("hi - im - shane - gray", exception.Message);
        }
    }
}
