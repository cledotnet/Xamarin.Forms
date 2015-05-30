using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog;
using Cleveland.DotNet.Sig.DiabetesLog.Views;

namespace Tests
{
    [TestFixture]
    public class AppTests
    {
        [Test]
        public void Instantiation_launches_HomePage()
        {
            // arrange

            // act
            var actual = new App();

            // assert
            Assert.That(actual.MainPage, Is.AssignableTo<HomePage>());
        }
    }
}
