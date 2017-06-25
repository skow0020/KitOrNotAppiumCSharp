using Appium_CSharp.core;

namespace Appium_CSharp.api.apps.speedtest.about
{
    public class AboutUiObjects
    {
        private static UiObject
            privacyPolicy1,
            termsOfUse1,
            logo1;

        public UiObject privacyPolicy()
        {
            if (privacyPolicy1 == null) privacyPolicy1 = new UiSelector().description("Privacy Policy").makeUiObject();
            return privacyPolicy1;
        }

        public UiObject termsOfUse()
        {
            if (termsOfUse1 == null) termsOfUse1 = new UiSelector().description("Terms of Use").makeUiObject();
            return termsOfUse1;
        }

        public UiObject logo()
        {
            if (logo1 == null) logo1 = new UiSelector().description("Speedtest.net").makeUiObject();
            return logo1;
        }
    }
}
