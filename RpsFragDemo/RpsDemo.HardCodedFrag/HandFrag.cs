﻿using Android.App;
using Android.OS;
using Android.Views;

namespace RpsDemo.HardCodedFrag
{
	public class HandFrag : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

		}

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = inflater.Inflate(Resource.Layout.handFrag, container, false);
			return view;
		}
	}
}

