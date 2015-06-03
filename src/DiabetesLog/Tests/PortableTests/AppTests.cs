using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;

namespace Tests
{
    [TestFixture]
    public class AppTests
    {
        [Test]
        public void HomePageModel_populates_static_properties()
        {
            // arrange
            

            // act
            var actual = new HomePageModel();

            // assert
            Assert.That(actual.Title, Is.EqualTo("Welcome to the Cleveland .NET SIG"));
        }

        [Test]
        public void Test_test()
        {
            Assert.That(true, Is.True);
        }
    }
}
