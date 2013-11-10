using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Appirater.Demo
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
	
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			window.RootViewController = new TestController ();
			window.MakeKeyAndVisible ();

			// clear the "kAppiraterRatedCurrentVersion" so we can demo it easier
			NSUserDefaults.StandardUserDefaults.SetBool (false, Appirater.RatedCurrentVersion);

			Appirater.SetAppId ("333903271");
			Appirater.SetSignificantEventsUntilPrompt (2);
			Appirater.SetDaysUntilPrompt (2);
			Appirater.SetUsesUntilPrompt (2);
			Appirater.SetTimeBeforeReminding (2);
			Appirater.AppLaunched (true);

			return true;
		}

		public override void WillEnterForeground (UIApplication application)
		{
			Appirater.AppEnteredForeground (true);
		}
	}
}

