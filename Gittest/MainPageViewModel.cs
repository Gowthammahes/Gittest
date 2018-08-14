using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace Gittest
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public MainPageViewModel()
        {
            this.AddButton_Tapped = new Command((action) =>
            {
                if (!(string.IsNullOrEmpty(Entry1) && string.IsNullOrEmpty(Entry2)))
                {
                    Sum = Entry1 + Entry2;
                }
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        string _entry1;
        public string Entry1
        {
            get { return this._entry1; }
            set
            {
                this._entry1 = value;
                OnPropertyChanged("Entry1");
            }
        }

        string _entry2;
        public string Entry2
        {
            get { return this._entry2; }
            set
            {
                this._entry2 = value;
                OnPropertyChanged("Entry2");
            }
        }

        string _sum;
        public string Sum
        {
            get { return this._sum; }
            set
            {
                this._sum = value;
                OnPropertyChanged("Sum");
            }
        }

        public ICommand AddButton_Tapped { get; set; }
    }
}
