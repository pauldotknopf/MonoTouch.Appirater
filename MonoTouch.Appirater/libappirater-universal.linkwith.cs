using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libappirater-universal.a", 
	LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator, 
	ForceLoad = true, 
	Frameworks = "StoreKit, SystemConfiguration")]
