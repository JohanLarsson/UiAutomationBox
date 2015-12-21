using System.ComponentModel;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace UiAutomationBox
{
    public class TextBoxVm : INotifyPropertyChanged
    {
        private string _text = "Initial";
        public event PropertyChangedEventHandler PropertyChanged;

        public string Text
        {
            get { return _text; }
            set
            {
                if (value == _text) return;
                _text = value;
                OnPropertyChanged();
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
