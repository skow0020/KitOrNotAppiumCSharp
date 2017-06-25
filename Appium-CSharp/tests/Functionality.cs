using Appium_CSharp.api.android;
using Appium_CSharp.api.apps.speedtest;
using Appium_CSharp.core.managers;
using NUnit.Framework;

namespace Appium_CSharp.tests
{
    [TestFixture]
    public class Functionality : TestManager
    {
        private static Speedtest speedtest = Android.app.speedtest;

        [Test]
        public void functionalityTest()
        {
            testinfo.id("test4").suite("Functionality").name("Verify that you can use the Test Again button effectively");
            speedtest.beginTest.tapBeginTest();
            speedtest.home.tapTestAgain();
            Assert.IsTrue(speedtest.home.uiObject.ping().exists());
            Assert.IsTrue(speedtest.home.uiObject.pingSpeed().exists());
            Assert.IsTrue(speedtest.home.uiObject.download().exists());
            Assert.IsTrue(speedtest.home.uiObject.downloadSpeed().exists());
            Assert.IsTrue(speedtest.home.uiObject.upload().exists());
            Assert.IsTrue(speedtest.home.uiObject.uploadSpeed().exists());
            Assert.IsTrue(speedtest.home.uiObject.shareButton().exists());
            Assert.IsTrue(speedtest.home.uiObject.removeAdsButton().exists());
            Assert.IsTrue(speedtest.home.uiObject.testAgainButton().exists());
            Assert.IsTrue(speedtest.home.uiObject.logo().exists());
        }
    }
}
