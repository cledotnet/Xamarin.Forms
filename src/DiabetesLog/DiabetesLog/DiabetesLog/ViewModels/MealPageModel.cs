﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
	public class MealPageModel : EntityEditorViewModel<Meal>
	{
		public MealPageModel() : base() { }
		public MealPageModel(Meal entity) : base(entity) { }
	}
}
