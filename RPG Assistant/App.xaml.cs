﻿using RPG_Assistant.View;
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

            //MainPage = new MainPage();
            MainPage = new CreateCharacterView();
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
