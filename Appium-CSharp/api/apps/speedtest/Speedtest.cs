using Appium_CSharp.api.android;
using Appium_CSharp.api.apps.speedtest.about;
using Appium_CSharp.api.apps.speedtest.begintest;
using Appium_CSharp.api.apps.speedtest.home;
using Appium_CSharp.api.apps.speedtest.menu;
using Appium_CSharp.api.apps.speedtest.results;
using Appium_CSharp.api.interfaces;
using System;

namespace Appium_CSharp.api.apps.speedtest
{
    public class Speedtest : Application
    {
        public Menu menu = new Menu();
        public Home home = new Home();
        public About about = new About();
        public BeginTest beginTest = new BeginTest();
        public Results results = new Results();

        public void forceStop()
        {
            Android.adb.forceStopApp(packageID());
        }

        public Object open()
        {
            Android.adb.openAppsActivity(packageID(), activityID());
            return null;
        }

        public void clearData()
        {
            Android.adb.clearAppsData(packageID());
        }

        public String packageID()
        {
            return "org.zwanoo.android.speedtest";
        }

        public String activityID()
        {
            return "com.ookla.speedtest.softfacade.MainActivity";
        }
    }
}
