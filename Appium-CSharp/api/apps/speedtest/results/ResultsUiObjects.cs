using Appium_CSharp.api.android;
using Appium_CSharp.core;

namespace Appium_CSharp.api.apps.speedtest.results
{
    public class ResultsUiObjects
    {
        private static UiObject
        logo1,
        sortByType1,
        sortByTime1,
        sortByDownload1,
        sortByUpload1,
        sortByPing1,
        toolsButton1,
        resultsLabel1;

        public UiObject logo()
        {
            if (logo1 == null) logo1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/typeLayout").makeUiObject();
            return logo1;
        }

        public UiObject sortByType()
        {
            if (sortByType1 == null) sortByType1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/timeLayout").makeUiObject();
            return sortByType1;
        }

        public UiObject sortByTime()
        {
            if (sortByTime1 == null) sortByTime1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/logo").makeUiObject();
            return sortByTime1;
        }

        public UiObject sortByDownload()
        {
            if (sortByDownload1 == null) sortByDownload1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/downloadLayout").makeUiObject();
            return sortByDownload1;
        }

        public UiObject sortByUpload()
        {
            if (sortByUpload1 == null) sortByUpload1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/uploadLayout").makeUiObject();
            return sortByUpload1;
        }

        public UiObject sortByPing()
        {
            if (sortByPing1 == null) sortByPing1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/pingLayout").makeUiObject();
            return sortByPing1;
        }

        public UiObject toolsButton()
        {
            if (toolsButton1 == null) toolsButton1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/toolsButton").makeUiObject();
            return toolsButton1;
        }

        public UiObject resultsLabel()
        {
            if (resultsLabel1 == null) resultsLabel1 = new UiSelector().resourceID(Android.app.speedtest.packageID() + ":id/resultsCoutText").makeUiObject();
            return resultsLabel1;
        }
    }
}
