using System;
using Xamarin.Forms;

namespace Study3XFBA
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        static Json_Model mockModel;


        public MainPage()
        {
            InitializeComponent();
        }
        void ReadTitle(object sender, EventArgs e)
        {
            Json_Model tempModel = DependencyService.Get<ISaveAndLoad>().Load("temp.txt");
            ModelTitleButton.Text = tempModel.Title;
        }

        void SavingButton(object sender, EventArgs e)
        {
            // var saveButton = new Button { Text = "Save" };
            // saveButton.Clicked += (sender, e) => {
            mockModel = new Json_Model();
                DependencyService.Get<ISaveAndLoad>().Save("temp.txt", mockModel);
           // };
        }

        void OnMieszko (object sender, EventArgs e)
        {
            if (Mieszko.IsToggled) phoneNumberText.Text = "zły Mieszko";
            else phoneNumberText.Text = "dobry Mieszko";
        }

        void LoadingButton(object sender, EventArgs e)
        {
           // var loadButton = new Button { Text = "Load" };
           // loadButton.Clicked += (sender, e) => {
//poleOdczytu.Text = DependencyService.Get<ISaveAndLoad>().Load("temp.txt");
            //};
        }

        void OnTranslate(object sender, EventArgs e)
        {
           // var obj = new FileExcercise();
           // phoneNumberText.Text = obj.FileExcerciseM();
            translatedNumber = Core.PhonewordTranslator.ToNumber(phoneNumberText.Text);
            if (!string.IsNullOrWhiteSpace(translatedNumber))
            {
                callButton.IsEnabled = true;
                callButton.Text = "Call " + translatedNumber;
            }
            else
            {
                callButton.IsEnabled = false;
                callButton.Text = "Call";
            }

        }

        async void OnCall(object sender, EventArgs e)
        {
            if (await this.DisplayAlert(
                    "Dial a Number",
                    "Would you like to call " + translatedNumber + "?",
                    "Yes",
                    "No"))
            {
                var dialer = DependencyService.Get<IDialer>();
                if (dialer != null)
                    dialer.Dial(translatedNumber);
            }
        }
    }
}