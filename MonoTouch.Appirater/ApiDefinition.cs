using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MonoTouch.Appirater
{
	[BaseType(typeof(NSObject))]
	interface Appirater
	{
		//+ (void)appLaunched:(BOOL)canPromptForRating;
		[Export("appLaunched:")]
		[Static]
		void AppLaunched(bool canPromptForRating);

		//+ (void)appEnteredForeground:(BOOL)canPromptForRating;
		[Export("appEnteredForeground:")]
		[Static]
		void AppEnteredForeground(bool canPromptForRating);

		//+ (void)userDidSignificantEvent:(BOOL)canPromptForRating;
		[Export("userDidSignificantEvent:")]
		[Static]
		void UserDidSignificantEvent(bool canPromptForRating);

		//+ (void)showPrompt;
		[Export("showPrompt")]
		[Static]
		void ShowPrompt();

		//+ (void)rateApp;
		[Export("rateApp")]
		[Static]
		void RateApp();

		//+ (void)closeModal;
		[Export("closeModal")]
		[Static]
		void CloseModal();
	}
}

