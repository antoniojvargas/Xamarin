using Android.App;
using Android.Widget;
using Android.OS;
using MySql.Data.MySqlClient;
using System.Data;

namespace LoginMySql
{
    [Activity(Label = "LoginMySql", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private EditText etUsuario, etClave;
        private Button btnInsert;
        private TextView txtSysLog;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            etUsuario = FindViewById<EditText>(Resource.Id.txtUsuario);
            etClave = FindViewById<EditText>(Resource.Id.txtClave);
            btnInsert = FindViewById<Button>(Resource.Id.buttonRegistro);
            txtSysLog = FindViewById<TextView>(Resource.Id.textSysLog);

            btnInsert.Click += BtnInsert_Click;
        }

        private void BtnInsert_Click(object sender, System.EventArgs e)
        {
            try
            {
                string strCon = "Server = http://45.55.138.105/; Port= 3306; database = xamarintest; User Id = root; Password = 984&$hjFx; charset= utf-8 ";
                MySqlConnection con =new MySqlConnection(strCon);


            }
            catch
            {

            }
        }
    }
}

