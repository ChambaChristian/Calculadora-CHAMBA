using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;
using Android.Support.V4.App;

namespace Calculadora_CHAMBA
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //DECLARACION DE VARIABLES
            var resultado = FindViewById<TextView>(Resource.Id.resul);
            var numero1 = FindViewById<EditText>(Resource.Id.num1);
            var numero2 = FindViewById<EditText>(Resource.Id.num2);
            var suma = FindViewById<Button>(Resource.Id.btnsumar);
            var resta = FindViewById<Button>(Resource.Id.btnrestar);
            var multi = FindViewById<Button>(Resource.Id.btnmulti);
            var dividir = FindViewById<Button>(Resource.Id.btndiv);
           
            //var raiz = FindViewById<Button>(Resource.Id.btnraiz);


            suma.Click += delegate
           
            {
 
                if (numero1.Text == "" || numero2.Text =="")
                {
                    Toast.MakeText(this, "Falta ingresar información en el telefono", ToastLength.Short).Show();
                }
                else
                {
                    resultado.Text = (Convert.ToInt32(numero1.Text) + Convert.ToInt32(numero2.Text)).ToString();
                    numero1.Text = "";
                    numero2.Text = "";

                }

            };
            resta.Click += delegate
            {
                if (numero1.Text == "" || numero2.Text == "")
                {
                    Toast.MakeText(this, "Falta ingresar información en el telefono", ToastLength.Short).Show();
                }
                else
                {
                    resultado.Text = (Convert.ToInt32(numero1.Text) - Convert.ToInt32(numero2.Text)).ToString();
                    numero1.Text = "";
                    numero2.Text = "";
                }
            };
            multi.Click += delegate
            {
                if (numero1.Text == "" || numero2.Text == "")
                {

                }
                else
                {
                    resultado.Text = (Convert.ToInt32(numero1.Text) * Convert.ToInt32(numero2.Text)).ToString();
                    numero1.Text = "";
                    numero2.Text = "";
                }
            };
            dividir.Click += delegate
            {
                if(numero1.Text == "" || numero2.Text == "")
                {

                }
                else
                {
                    resultado.Text = (Convert.ToInt32(numero1.Text) / Convert.ToInt32(numero2.Text)).ToString();
                    numero1.Text = "";
                    numero2.Text = "";
                }
            };
            //potencia.Click += delegate
            //{
            //    if (numero1.Text == "" || numero2.Text == "")
            //    {

            //    }
            //    else
            //    {
            //        resultado.Text = Math.Pow(Convert.ToInt32(numero1.Text), Convert.ToInt32(numero2.Text)).ToString();
            //        numero1.Text = "";
            //        numero2.Text = "";
            //    }
            //};
            //raiz.Click += delegate
            //{

            //    resultado.Text = Math.Sqrt(Convert.ToInt32(numero1.Text), Convert.ToInt32(numero2.Text)).ToString();
            //    numero1.Text = "";
            //    numero2.Text = "";

            //};

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}