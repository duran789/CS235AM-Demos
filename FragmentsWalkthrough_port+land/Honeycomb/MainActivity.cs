﻿using Android.App;
using Android.OS;

namespace com.xamarin.sample.fragments.honeycomb
{
    [Activity(Label = "Fragments Walkthrough", MainLauncher = true, Icon = "@drawable/launcher")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.activity_main);
			// Note: The version of activity_main.axml loaded will depend
			// on the orientation of the device
        }
    }
}
