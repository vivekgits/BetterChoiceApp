﻿using Android.App;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.Platform.Android;
using Android.Content.PM;
using ImageCircle.Forms.Plugin.Droid;
using Prism;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Lottie.Forms.Droid;
using Acr.UserDialogs;
using FFImageLoading.Forms.Droid;

namespace BetterChoice.Android
{
    [Activity(Label = "@string/AppName", Icon = "@mipmap/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            ToolbarResource = Resource.Layout.toolbar;
            TabLayoutResource = Resource.Layout.tabs;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            ImageCircleRenderer.Init();

            AnimationViewRenderer.Init();

            CachedImageRenderer.Init();

            UserDialogs.Init(()=>this);

            LoadApplication(new BetterChoiceShared.App());
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}
