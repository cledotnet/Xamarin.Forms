using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using NUnit.Framework;

namespace PortableTests
{
	[TestFixture]
	public class EntityTests
	{
		[Test]
		public void Meal_Instantiation_Works()
		{
			// arrange

			// act
			var actual = new Meal()
			{
				Name = "Test Meal",
				Carbohydrates = 120
			};

			// assert
			Assert.That(actual.Name, Is.EqualTo("Test Meal"));
			Assert.That(actual.Carbohydrates, Is.EqualTo(120));
		}
	}
}
