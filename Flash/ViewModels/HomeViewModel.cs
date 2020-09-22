using Flash.Views;
using System;
using Xamarin.Forms;

namespace Flash.ViewModels
{
    class HomeViewModel
    {
        public Command LotoPageCommand { get; set; }
        public Command EuroMillionPageCommand { get; set; }

        public HomeViewModel()
        {
            LotoPageCommand = new Command(() => ExecuteLotoPageCommand());
            EuroMillionPageCommand = new Command(() => ExecuteEuroMillionPageCommand());
        }

        private void ExecuteLotoPageCommand()
        {
            Application.Current.MainPage.Navigation.PushAsync(new LotoPage());
        }

        private void ExecuteEuroMillionPageCommand()
        {
            Application.Current.MainPage.Navigation.PushAsync(new EuroPage());
        }
    }
}
