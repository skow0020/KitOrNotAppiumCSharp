using Appium_CSharp.core;

namespace Appium_CSharp.api.apps.speedtest.menu
{
    public class MenuUiObjects
    {
        private static UiObject
            speedtest1,
            results1,
            settings1,
            about1;

        public UiObject speedtest()
        {
            if (speedtest1 == null) speedtest1 = new UiSelector().text("SPEEDTEST").makeUiObject();
            return speedtest1;
        }

        public UiObject results()
        {
            if (results1 == null) results1 = new UiSelector().text("RESULTS").makeUiObject();
            return results1;
        }

        public UiObject settings()
        {
            if (settings1 == null) settings1 = new UiSelector().text("SETTINGS").makeUiObject();
            return settings1;
        }

        public UiObject about()
        {
            if (about1 == null) about1 = new UiSelector().text("ABOUT").makeUiObject();
            return about1;
        }
    }
}
