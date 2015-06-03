using System;
using System.IO;
using Cleveland.DotNet.Sig.DiabetesLog.Android.Services;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using NUnit.Framework;



namespace AndroidTests
{
    [TestFixture]
    public class RepositoryTests
    {

        private Repository _repository;

        [SetUp]
        public void Setup()
        {
            Xamarin.Forms.Forms.Init(MainActivity.Instance, null);
            _repository = new FileRepository();
        }


        [TearDown]
        public void Tear() { }

        [Test]
        public void Save()
        {
            // arrange
            var check = new GlucoseCheck()
            {
                Glucose = 100,
                Timestamp = new DateTime(2015, 01, 01, 12, 30, 00)
            };
            
            // act
            var identifier = check.Save();

            // assert
            Assert.That(identifier, Is.EqualTo(check.Identifier));
            var file = new FileInfo(Path.Combine(_repository.DefaultPath, "objects", check.GetType().Name.ToLower(), $"{identifier}.json"));
            Assert.That(file.Exists, Is.True);
        }

        [Test]
        public void Fail()
        {
            Assert.False(true);
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }

        [Test]
        public void Inconclusive()
        {
            Assert.Inconclusive("Inconclusive");
        }
    }
}