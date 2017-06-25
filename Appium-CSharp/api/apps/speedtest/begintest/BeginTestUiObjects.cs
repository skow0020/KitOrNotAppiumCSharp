using Appium_CSharp.core;

namespace Appium_CSharp.api.apps.speedtest.begintest
{
    public class BeginTestUiObjects
    {
        private static UiObject beginTestButton1;

        public UiObject beginTestButton()
        {
            if (beginTestButton1 == null) beginTestButton1 = new UiSelector().text("Begin Test").makeUiObject();
            return beginTestButton1;
        }
    }
}
