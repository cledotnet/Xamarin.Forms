using System;
using System.IO;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
    public partial class GlucoseCheckEditor : EntityEditor<GlucoseCheckPageModel, GlucoseCheck>
    {
        public GlucoseCheckEditor() : this(new GlucoseCheckPageModel())
        {
        }

        public GlucoseCheckEditor(GlucoseCheckPageModel model)
        {
            InitializeComponent();
            InitializeModel(model);
        }

        public void Reset_OnClicked(object sender, EventArgs args)
        {
            // TODO: Reset the model to its initial state
        }

        public void Save_OnClicked(object sender, EventArgs args)
        {
            var entity = Model?.Entity as Persistable;
            if (entity != default(Persistable))
            {
                var repository = DependencyService.Get<Repository>();
                repository.Save(entity);
                InitializeModel(Model);
            }

        }
    }
}
