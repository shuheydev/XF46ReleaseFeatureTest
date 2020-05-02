using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF46ReleaseFeatureTest.Views;

namespace XF46ReleaseFeatureTest
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] {
                "RadioButton_Experimental",
                "AppTheme_Experimental",
                "Markup_Experimental",
                "Expander_Experimental"
            });

            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
