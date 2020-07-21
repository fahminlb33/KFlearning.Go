using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace KFlearning.Go.Droid
{
    [Activity(Label = "SplashActivity", Theme = "@style/Splash", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_splash);
            Task.Run(async () =>
            {
                await Task.Delay(2000);
                StartActivity(typeof(MainActivity));
                Finish();
            });
        }
    }
}