﻿using System;
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
		private List<Person> mItems;
		private ListView mListView;


		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);
			mListView = FindViewById<ListView>(Resource.Id.myListView);
			
			mItems = new List<Person>();
			foreach (var c in new string[]{ "bob", "tom", "jim" })
			{
				mItems.Add(new Person() { FirstName = c, LastName = c, age = "12", gender = "Male" });
			}

			MyListViewAdapter adapter = new MyListViewAdapter(this, mItems);

			mListView.Adapter = adapter;
			mListView.ItemSelected += MListView_ItemSelected;
			mListView.ItemClick += MListView_ItemClick;
			mListView.ItemLongClick += MListView_ItemLongClick;
		}

		private void MListView_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
		{
			Console.WriteLine(mItems[e.Position].age);
		}

		private void MListView_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
		{
			Console.WriteLine(mItems[e.Position].age);
		}

		private void MListView_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
		{
			Console.WriteLine(mItems[e.Position].FirstName);
		}
	}
}

