using Android.App;
using Android.Widget;
using Android.OS;
using BarChart;
using System;
using Android.Views;
using Android.Support.V7.App;

namespace ChartTest
{
    [Activity(Label = "Siogranos", MainLauncher = true, Icon = "@drawable/icon", Theme ="@style/Theme.AppCompat.Light")]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);

            Spinner spinnerC = FindViewById<Spinner>(Resource.Id.spinnerCereal);
            var adapterC = ArrayAdapter.CreateFromResource(this, Resource.Array.cereal_array, Android.Resource.Layout.SimpleSpinnerItem); //Assign Array List Strings  
            adapterC.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerC.Adapter = adapterC;

            Spinner spinnerZ = FindViewById<Spinner>(Resource.Id.spinnerZona);
            var adapterZ = ArrayAdapter.CreateFromResource(this, Resource.Array.zona_array, Android.Resource.Layout.SimpleSpinnerItem); //Assign Array List Strings  
            adapterZ.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            spinnerZ.Adapter = adapterZ;

            BarChartView chart = FindViewById<BarChartView>(Resource.Id.barChart);
            

            chart.BarColor = Android.Graphics.Color.Navy;
            chart.BarCaptionInnerColor = Android.Graphics.Color.WhiteSmoke;
            chart.BarCaptionOuterColor = Android.Graphics.Color.Black;
            //chart.MinimumValue = 0;
            //chart.MaximumValue = 15;

            //chart.AutoLevelsEnabled = false;
            //chart.AddLevelIndicator(0, title: "zero");
            //chart.AddLevelIndicator(5);


            var data = new[] { 6f, 2f, 4f, 8f, 10f, 3f };
            chart.ItemsSource = Array.ConvertAll(data, v => new BarModel { Value = v });



            //AddContentView(chart, new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.MatchParent));

            //btnclick.Click += (sender, e) =>
            //{
            //    //Showing Notifications  
            //    Toast.MakeText(this, txtusername.Text, ToastLength.Short).Show();
            //    Toast.MakeText(this, txtpassword.Text, ToastLength.Short).Show();
            //    Toast.MakeText(this, spinner.SelectedItemPosition.ToString(), ToastLength.Short).Show();
            //};

        }
    }
}

