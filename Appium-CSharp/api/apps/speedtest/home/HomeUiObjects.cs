using Appium_CSharp.api.android;
using Appium_CSharp.core;

namespace Appium_CSharp.api.apps.speedtest.home
{
    public class HomeUiObjects
    {
        private static UiObject
    ping1,
    download1,
    upload1,
    pingSpeed1,
    downloadSpeed1,
    uploadSpeed1,
    testAgainButton1,
    removeAdsButton1,
    shareButton1,
    logo1;

        public UiObject ping()
        {
            if (ping1 == null) ping1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/ping").makeUiObject();
            return ping1;
        }

        public UiObject download()
        {
            if (download1 == null) download1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/download").makeUiObject();
            return download1;
        }

        public UiObject upload()
        {
            if (upload1 == null) upload1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/upload").makeUiObject();
            return upload1;
        }
        public UiObject pingSpeed()
        {
            if (pingSpeed1 == null) pingSpeed1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/pingSpeed").makeUiObject();
            return pingSpeed1;
        }

        public UiObject downloadSpeed()
        {
            if (downloadSpeed1 == null) downloadSpeed1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/downloadSpeed").makeUiObject();
            return downloadSpeed1;
        }

        public UiObject uploadSpeed()
        {
            if (uploadSpeed1 == null) uploadSpeed1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/uploadSpeed").makeUiObject();
            return uploadSpeed1;
        }

        public UiObject testAgainButton()
        {
            if (testAgainButton1 == null) testAgainButton1 = new UiSelector().text("Test Again").makeUiObject();
            return testAgainButton1;
        }

        public UiObject removeAdsButton()
        {
            if (removeAdsButton1 == null) removeAdsButton1 = new UiSelector().text("Remove Ads").makeUiObject();
            return removeAdsButton1;
        }

        public UiObject shareButton()
        {
            if (shareButton1 == null) shareButton1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/shareButton").makeUiObject();
            return shareButton1;
        }

        public UiObject logo()
        {
            if (logo1 == null) logo1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/logo").makeUiObject();
            return logo1;
        }
    }
}
