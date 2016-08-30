﻿using Android.App;
using Android.Widget;
using Android.OS;
using MvvmCross.Platform.Droid.Platform;
using System;
using Android.Content;
using Android.Content.PM;

namespace ExternaAppPlugin.Droid
{
	public class MvxLaunchAppTask : MvxAndroidTask, IMvxLaunchAppTask
	{
		public void ShareLink()
		{
			Intent skypeVideo = new Intent("android.intent.action.VIEW");
			skypeVideo.SetData(Android.Net.Uri.Parse("skype:" + "<username>" + "?call&video=true"));
			StartActivity(skypeVideo);
		}


	}
}


