using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace BeerLogs
{
	[Activity(Label = "BeerLogs", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		private List<string> mItems;
		private ListView mListView;


		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			mListView = FindViewById<ListView>(Resource.Id.myListView);
			
			mItems = new List<string>();
			foreach (var c in new string[]{ "bob", "tom", "jim" })
			{
				mItems.Add(c);
			}

			MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

			mListView.Adapter = adapter;
		}
	}
}

