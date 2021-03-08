using RPG_Assistant.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RPG_Assistant
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            int deviceType = 0;
            deviceType = GetDevice();

            if (deviceType == 0)
            {
                MainPage = new CreateCharacterView_IOS();
            }
            else
            if (deviceType == 1)
            {
                MainPage = new CreateCharacterView_ANDROID();
            }

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

        private int GetDevice()
        {

            int thisDevice = 0;
#if __IOS__
            thisDevice = 0;
#else

#if __ANDROID__
            thisDevice = 1;
#endif
#endif
            return thisDevice;
        }


    }
}

