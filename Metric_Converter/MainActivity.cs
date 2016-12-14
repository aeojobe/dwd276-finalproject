using Android.App;
using Android.Widget;
using Android.OS;
using System;


namespace Metric_Converter
{
    [Activity(Label = "Metric_Converter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
            var temperatureButton = FindViewById<Button>(Resource.Id.Temperature);
            var convertButton = FindViewById<Button>(Resource.Id.convert);
            var fahrenheitView = FindViewById<TextView>(Resource.Id.temperatureInput);

            temperatureButton.Click += delegate { changeView(); };
            convertButton.Click += delegate { convertTemperature(fahrenheitView); };
            fahrenheitView.Click += delegate { emptyText(fahrenheitView); };
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }

        public void changeView()
        {
            var homepage = FindViewById<LinearLayout>(Resource.Id.home);
            var temppage = FindViewById<LinearLayout>(Resource.Id.changeTemp);

            temppage.Visibility = Android.Views.ViewStates.Visible;
            homepage.Visibility = Android.Views.ViewStates.Gone;
            

        }

        public void emptyText(TextView input)
        {
            input.Text = "";
        }

        public void convertTemperature(TextView Fahrenheit)
        {
            var celcuisView = FindViewById<TextView>(Resource.Id.celciusOutput);

            var userTemp = Fahrenheit.Text;

            //Do Calculation
            var celcuisTemp = (Convert.ToInt32(userTemp) - 32) * (5.0 / 9.0);

            celcuisView.Text = Convert.ToString(celcuisTemp);

        }
    }
}

