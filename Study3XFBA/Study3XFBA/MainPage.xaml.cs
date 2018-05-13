using System;
using System.Linq;
using Xamarin.Forms;

namespace Study3XFBA
{
    public partial class MainPage : ContentPage
    {
        string translatedNumber;
        JsonModel form;
        JsonModel form_read;
        SampleNode formProperty;

        public MainPage()
        {
            InitializeComponent();
            form = new JsonModel();
            
            formProperty = new SampleNode();
        }

        void OnTranslate(object sender, EventArgs e)
        {
            form.Title = Title.Text;
            form.Id = Int32.Parse(Id.Text);
            formProperty.Properties = Property.Text;
            form.ListOfSampleNodes = new System.Collections.Generic.List<SampleNode>();
            form.ListOfSampleNodes.Add(formProperty);
            DependencyService.Get<ISaveAndLoad>().Save("temp.txt", form);

        }

        async void OnCall(object sender, EventArgs e)
        {
            form_read = DependencyService.Get<ISaveAndLoad>().Load("temp.txt");
            Title_read.Text = form_read.Title;
            Id_read.Text = form_read.Id.ToString();


           
            
          
        }
    }
}