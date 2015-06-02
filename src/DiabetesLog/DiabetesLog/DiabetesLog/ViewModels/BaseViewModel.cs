using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cleveland.DotNet.Sig.DiabetesLog.Annotations;

namespace Cleveland.DotNet.Sig.DiabetesLog.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public BaseViewModel()
        {
            InitializeProperties();
        }

        public virtual void InitializeProperties()
        {
            Title = this.GetType().Name;
        }

        public string Title { get; set; }
        public string Introduction { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
