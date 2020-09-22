using Flash.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Flash.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EuroPage : ContentPage
    {
        public EuroPage()
        {
            InitializeComponent();

            BindingContext = new EuroMillionsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            LabelAnimationsAsync(lblNum1);
            LabelAnimationsAsync(lblNum2);
            LabelAnimationsAsync(lblNum3);
            LabelAnimationsAsync(lblNum4);
            LabelAnimationsAsync(lblNum5);
            LabelAnimationsAsync(lblEtoi1);
            LabelAnimationsAsync(lblEtoi2);
        }

        public void LabelAnimationsAsync(Label label)
        {
            label.Opacity = 0;
            label.RotateTo(720, 2000, Easing.CubicOut);
            label.FadeTo(1, 4000, Easing.CubicOut);
        }
    }
}