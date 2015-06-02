using System;
using Cleveland.DotNet.Sig.DiabetesLog.ViewModels;
using Cleveland.DotNet.Sig.DiabetesLog.Views;
using Cleveland.DotNet.Sig.DiabetesLog.Views.Entities;
using Xamarin.Forms;

namespace Cleveland.DotNet.Sig.DiabetesLog.Models
{
    public class GlucoseCheck : Entity<GlucoseCheck, GlucoseCheckViewer, GlucoseCheckPageModel>, Editable
    {
        private DateTime _timestamp = DateTime.Now;
        private int _glucose = 0;

        public DateTime Timestamp
        {
            get { return _timestamp; }
            set
            {
                if (_timestamp == value) return;
                _timestamp = value;
                OnPropertyChanged();
            }
        }

        public int Glucose
        {
            get { return _glucose; }
            set
            {
                if (_glucose == value) return;
                _glucose = value;
                OnPropertyChanged();
            }
        }

        public override string ToString()
        {
            return $"{Timestamp:yyyy-MM-dd HH:mm:ss} {Glucose} mg/dl";
        }

        public Page CreateEditor()
        {
            return new GlucoseCheckEditor(new GlucoseCheckPageModel(this));
        }

        public bool IsChanged { get { return _isChanged;} }

        public override string Identifier => $"{Timestamp:yyyy-MM-dd HHmmss}";
    }
}
