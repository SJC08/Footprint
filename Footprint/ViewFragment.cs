﻿using Android.Views;
using Android.Webkit;

namespace Footprint
{
    public class ViewFragment : Fragment
    {
        public override View? OnCreateView(LayoutInflater? inflater, ViewGroup? container, Bundle? savedInstanceState)
        {
            return inflater?.Inflate(Resource.Layout.fragment_view, container, false);
        }

        public override void OnViewCreated(View? view, Bundle? savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var webView = view.FindViewById<WebView>(Resource.Id.webView);
            webView.Settings.JavaScriptEnabled = true;
            webView.AddJavascriptInterface(new JavascriptInterface(), "CS");
            webView.LoadUrl("file:///android_asset/www/view.html");
        }
    }
}
