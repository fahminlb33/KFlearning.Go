using System.Threading.Tasks;
using Android.App;
using Android.OS;

namespace KFlearning.Go.Droid
{
    [Activity(Label = "KFlearning Go", Theme = "@style/Splash", MainLauncher = true)]
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