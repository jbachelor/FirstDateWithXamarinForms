using System;
using System.ComponentModel;

namespace FirstDateWithXF
{
    public class FirstDateWithXFPageViewModel : INotifyPropertyChanged
    {
        int clickCount;

        private string _clickCountText;
        public string ClickCountText
        {
            get { return _clickCountText; }
            set
            {
                if (value != _clickCountText)
                {
                    _clickCountText = value;
                    OnPropertyChanged(nameof(ClickCountText));
                }
            }
        }

        public FirstDateWithXFPageViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnPropertyChanged)}:  [{propertyName}]");

            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        internal void OnRotateButtonClicked()
        {
            clickCount++;
            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnRotateButtonClicked)}:  clickCount={clickCount}");

            ClickCountText = $"{clickCount} clicks!";
        }
    }
}
