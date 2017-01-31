using Android.App;
using Android.Widget;
using Android.OS;
using BarChart;
using System;
using Android.Views;
using Android.Support.V7.App;
using System.Collections.ObjectModel;

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

            TextView _dateDisplay = FindViewById<TextView>(Resource.Id.date_display);
            Button _dateSelectButton = FindViewById<Button>(Resource.Id.buttonFecha);

            _dateSelectButton.Click += (sender, e) => 
            {
                DatePickerFragment frag = DatePickerFragment.NewInstance(delegate (DateTime time)
                {
                    _dateDisplay.Text = time.ToLongDateString();
                });
                frag.Show(FragmentManager, DatePickerFragment.TAG);
            };
            
            BarChartView chart = FindViewById<BarChartView>(Resource.Id.barChart);            
            
            chart.BarCaptionInnerColor = Android.Graphics.Color.WhiteSmoke;
            chart.BarCaptionOuterColor = Android.Graphics.Color.Black;

            chart.GridHidden = true;
            chart.LegendHidden = false;
            chart.LegendColor = Android.Graphics.Color.Black;

            chart.BarOffset= 18;

            var data = new[] { 6, 2, 4, 8, 10, 3, 7 };
            var fechas = new[] { "25/01", "26/01", "27/01", "28/01", "29/01", "30/01", "31/01" };
 
            var modelos = new ObservableCollection<BarModel>();

            for (int i = 0; i < data.Length; i++)
            {
                var bar = new BarModel
                {
                    Value = data[i],
                    Color = Android.Graphics.Color.DarkBlue,
                    Legend = fechas[i],
                    ValueCaptionHidden = false,
                    ValueCaption = data[i].ToString()
                };
                modelos.Add(bar);
            }
                  
            chart.ItemsSource = modelos;
        }
    }
}

