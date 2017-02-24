using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SchoolApp.Android
{
    [Activity(Label = "ViewDetails", Icon = "@drawable/icon")]
    public class ViewDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ViewDetails);

            string text = Intent.GetStringExtra("StudentName") ?? "Data not available";
            string email = Intent.GetStringExtra("StudentEmail") ?? "Data not available";
            var nameview = FindViewById<TextView>(Resource.Id.details_name);
            var emailview = FindViewById<TextView>(Resource.Id.details_email);
            nameview.Text = text;
            emailview.Text = email;
        }
    }
}