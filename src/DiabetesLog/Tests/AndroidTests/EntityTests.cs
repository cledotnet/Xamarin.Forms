using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using NUnit.Framework;
using Xamarin.Forms;

namespace AndroidTests
{
	[TestFixture]
	public class EntityTests
	{
		[Test]
		public void DatedEvent_Instantiation_Works()
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