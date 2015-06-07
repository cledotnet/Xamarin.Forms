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
        public void SaveGlucoseCheck()
        {
            // arrange
            var check = new GlucoseCheck()
            {
                Glucose = 100,
                Date = new DateTime(2015, 01, 01, 12, 30, 00)
            };
			TestEntity(check);
        }

	    [Test]
	    public void SaveMeal()
	    {
		    // arrange
			var entity = new Meal()
			{
				Carbohydrates = 120,
				Name = "Test Meal"
			};
		    TestEntity(entity);
	    }

		[Test]
		public void SaveInsulinDose()
		{
			// arrange
			var entity = new InsulinDose()
			{
				Insulin = 5
			};
			TestEntity(entity);
		}

	    private void TestEntity(Persistable entity)
	    {
		    var expected = new
		    {
			    Identifier = entity.Identifier,
			    Filespec =
				    Path.Combine(_repository.DefaultPath, entity.GetType().Name.ToLower(), string.Format("{0}.json", entity.Identifier))
		    };

		    // act
		    var actual = new
		    {
			    Identifier = entity.Save(),
			    Filespec = _repository.GetFilespec(entity)
		    };

		    // assert
		    Assert.That(actual.Identifier, Is.EqualTo(expected.Identifier));
		    Assert.That(actual.Filespec, Is.EqualTo(expected.Filespec));
		    Assert.That(File.Exists(actual.Filespec));
	    }
    }
}