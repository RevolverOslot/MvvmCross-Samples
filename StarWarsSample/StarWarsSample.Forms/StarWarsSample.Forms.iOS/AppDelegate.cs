﻿using Acr.UserDialogs;
using FFImageLoading.Forms.Platform;
using Foundation;
using Lottie.Forms.iOS.Renderers;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;

namespace StarWarsSample.Forms.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<MvxFormsIosSetup<Core.App, App>, Core.App, App>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            CachedImageRenderer.Init();
            AnimationViewRenderer.Init();

            return base.FinishedLaunching(app, options);
        }
    }
}
