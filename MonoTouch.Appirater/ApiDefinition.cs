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
		#region Static

		//+ (Appirater*)sharedInstance;
		[Export("sharedInstance")]
		[Static]
		Appirater SharedInstance { get; }

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

		#region Configuration

		//+ (void) setAppId:(NSString*)appId;
		[Export("setAppId:")]
		[Static]
		void SetAppId(string appId);

		[Export("setDaysUntilPrompt:")]
		[Static]
		//+ (void) setDaysUntilPrompt:(double)value;
		void SetDaysUntilPrompt(double value);

		//+ (void) setUsesUntilPrompt:(NSInteger)value;
		[Export("setUsesUntilPrompt:")]
		[Static]
		void SetUsesUntilPrompt(int value);

		//+ (void) setSignificantEventsUntilPrompt:(NSInteger)value;
		[Export("setSignificantEventsUntilPrompt:")]
		[Static]
		void SetSignificantEventsUntilPrompt(int value);

		//+ (void) setTimeBeforeReminding:(double)value;
		[Export("setTimeBeforeReminding:")]
		[Static]
		void SetTimeBeforeReminding(double value);

		//+ (void) setDebug:(BOOL)debug;
		[Export("setDebug:")]
		[Static]
		void SetDebug(bool debug);

		//+ (void)setDelegate:(id<AppiraterDelegate>)delegate;
		[Export("setDelegate:")]
		[Static]
		void SetDelegate(NSObject del);

		//+ (void)setUsesAnimation:(BOOL)animation;
		[Export("setUsesAnimation:")]
		[Static]
		void SetUsesAnimation(bool animation);

		[Export("setOpenInAppStore:")]
		[Static]
		//+ (void)setOpenInAppStore:(BOOL)openInAppStore;
		void SetOpenInAppStore(bool openInAppStore);

		//+ (void)setAlwaysUseMainBundle:(BOOL)useMainBundle;
		[Export("setAlwaysUseMainBundle:")]
		[Static]
		void SetAlwaysUseMainBundle(bool useMainBundle);

		#endregion

		#endregion

		#region Instance

		//- (BOOL)connectedToNetwork;
		[Export("connectedToNetwork")]
		bool ConnectedToNetwork();

		//- (void)showRatingAlert;
		[Export("showRatingAlert")]
		void ShowRatingAlert();

		//- (BOOL)ratingConditionsHaveBeenMet;
		[Export("ratingConditionsHaveBeenMet")]
		bool RatingConditionsHaveBeenMet();

		//- (void)incrementUseCount;
		[Export("incrementUseCount")]
		void IncrementUseCount();

		//- (void)hideRatingAlert;
		[Export("hideRatingAlert")]
		void HideRatingAlert();

		#endregion

		#region Properties

		[Field ("kAppiraterFirstUseDate", "__Internal")]
		NSString FirstUseDate { get; }

		[Field ("kAppiraterUseCount", "__Internal")]
		NSString UseCount { get; }

		[Field ("kAppiraterSignificantEventCount", "__Internal")]
		NSString SignificantEventCount { get; }

		[Field ("kAppiraterCurrentVersion", "__Internal")]
		NSString CurrentVersion { get; }

		[Field ("kAppiraterRatedCurrentVersion", "__Internal")]
		NSString RatedCurrentVersion { get; }

		[Field ("kAppiraterDeclinedToRate", "__Internal")]
		NSString DeclinedToRate { get; }

		[Field ("kAppiraterReminderRequestDate", "__Internal")]
		NSString ReminderRequestDate { get; }

		#endregion
	}
}

