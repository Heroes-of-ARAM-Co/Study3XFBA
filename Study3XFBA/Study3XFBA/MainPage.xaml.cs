using System;
using Xamarin.Forms;

namespace Study3XFBA
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;

        public MainPage()
        {
            InitializeComponent();
        }

        void OnTranslate(object sender, EventArgs e)
        {
            DependencyService.Get<ISaveAndLoad>().SaveText("temp.txt", phoneNumberText.Text);
   

        }

        async void OnCall(object sender, EventArgs e)
        {
            Output.Text = DependencyService.Get<ISaveAndLoad>().LoadText("temp.txt");
        }
    }
}