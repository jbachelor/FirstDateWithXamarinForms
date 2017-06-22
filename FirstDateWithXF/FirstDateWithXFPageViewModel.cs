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

        private int _rotationAmount;
        public int RotationAmount
        {
            get { return _rotationAmount; }
            set
            {
                if (_rotationAmount != value)
                {
                    _rotationAmount = value;
                    OnPropertyChanged(nameof(RotationAmount));
                }
            }
        }

        public FirstDateWithXFPageViewModel()
        {
            RotationAmount = 15;
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

            if (RotationAmount >= 360)
            {
                RotationAmount = 15;
            }
            else
            {
                RotationAmount += 15;
            }

            System.Diagnostics.Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnRotateButtonClicked)}:  clickCount={clickCount}");

            ClickCountText = $"{clickCount} clicks!";
        }
    }
}
