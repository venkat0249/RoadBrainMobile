﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace RoadCare
{
	[Activity (Label = "RoadBrain", MainLauncher = true, Icon = "@drawable/appicon")]
	public class MainActivity : Activity
	{
		//int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.button1);

			button.Click +=  OpenPathholespage;


		}

		//open pathholes window
		void OpenPathholespage (object sender, EventArgs e)
		{
			var intent = new Intent(this, typeof(PathholesActivity));
			StartActivity(intent);
		}
	}
}


