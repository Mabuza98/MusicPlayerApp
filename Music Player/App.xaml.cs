﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Music_Player
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MusicPlayerMasterDetailPage1();
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
