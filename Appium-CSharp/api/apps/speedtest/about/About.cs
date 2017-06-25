using Appium_CSharp.api.android;
using Appium_CSharp.api.interfaces;
using System;

namespace Appium_CSharp.api.apps.speedtest.about
{
    public class About : Activity
    {
        public AboutUiObjects uiObject = new AboutUiObjects();

        public object waitToLoad()
        {
            try
            {
                uiObject.termsOfUse().waitToAppear(10);
                return Android.app.speedtest.about;
            }
            catch (Exception e)
            {
                throw new Exception("About activity failed to load/open");
            }
        }
    }
}
