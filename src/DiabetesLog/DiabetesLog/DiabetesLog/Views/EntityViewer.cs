using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;

namespace Cleveland.DotNet.Sig.DiabetesLog.Views
{
    public class EntityViewer<ViewModelType, EntityType> : BasePage<ViewModelType> 
        where ViewModelType : BaseViewModel, new()
    {
    }
}
