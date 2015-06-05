using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
	public class GlucoseCheckPageModel : EntityViewerViewModel<GlucoseCheck>
	{
		private GlucoseCheck glucoseCheck;
		private string _id;

		public GlucoseCheckPageModel(GlucoseCheck entity)
		{
			InitializeProperties(entity);
			Id = entity.Identifier;
		}
		
		public GlucoseCheckPageModel()
		{

		}

		public string Id
		{
			get { return _id; }
			set
			{
				if (value == _id) return;
				_id = value;
				OnPropertyChanged();
			}
		}
	}
}
