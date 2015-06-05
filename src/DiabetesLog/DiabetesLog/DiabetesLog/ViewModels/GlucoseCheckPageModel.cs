using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
	public class GlucoseCheckPageModel : EntityEditorViewModel<GlucoseCheck>
	{
		public GlucoseCheckPageModel() : base() { }
		public GlucoseCheckPageModel(GlucoseCheck glucoseCheck) : base(glucoseCheck) { }
	}
}
