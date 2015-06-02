using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views.Entities
{
    public partial class InsulinDoseViewer : EntityViewer<InsulinDosePageModel, InsulinDose>
    {
        public InsulinDoseViewer()
        {
            InitializeComponent();
        }
    }
}
