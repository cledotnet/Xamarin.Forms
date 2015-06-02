using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public interface Editable
    {
        Page CreateEditor();
        bool IsChanged { get; }
    }
}
