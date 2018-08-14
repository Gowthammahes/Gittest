using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gittest
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel = new MainPageViewModel();

        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}
