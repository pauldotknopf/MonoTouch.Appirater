using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace MonoTouch.Appirater.Demo
{
	public class TestController : DialogViewController
	{
		public TestController ()
			:base(UITableViewStyle.Grouped, null)
		{
			Root = new RootElement ("Appirater Demo") {
				new Section("") {
					new StyledStringElement("Raise Significant Event", new NSAction(() => {
						global::MonoTouch.Appirater.Appirater.UserDidSignificantEvent(true);
					})),
					new StyledStringElement("Show Prompt", new NSAction(() => {
						Appirater.ShowPrompt();
					})),
					new StyledStringElement("Rate App", new NSAction(() => {
						Appirater.RateApp();
					}))
				}
			};
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}
	}
}

