using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Models;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
    public class InsulinDosePageModel : EntityViewerViewModel<InsulinDose>
    {
        public InsulinDose Dose { get; set; }

    }
}
