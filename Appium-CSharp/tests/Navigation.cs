using Appium_CSharp.api.android;
using Appium_CSharp.api.apps.speedtest;
using Appium_CSharp.core.managers;
using NUnit.Framework;

namespace Appium_CSharp.tests
{
    [TestFixture]
    public class Navigation : TestManager
    {
        private static Speedtest speedtest = Android.app.speedtest;

        [Test]
        public void homeActivity()
        {
            testinfo.id("Test1").name("Verify that Home Activity has all elements");
            speedtest.beginTest.tapBeginTest();
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

        [Test]
        public void resultsActivity()
        {
            testinfo.id("Test2").name("Verify that Results has sorting buttons");
            speedtest.beginTest.tapBeginTest();
            speedtest.menu.tapResults();
            Assert.IsTrue(speedtest.results.uiObject.toolsButton().exists());
            Assert.IsTrue(speedtest.results.uiObject.resultsLabel().exists());
            Assert.IsTrue(speedtest.results.uiObject.sortByDownload().exists());
            Assert.IsTrue(speedtest.results.uiObject.sortByPing().exists());
            Assert.IsTrue(speedtest.results.uiObject.sortByTime().exists());
            Assert.IsTrue(speedtest.results.uiObject.sortByType().exists());
            Assert.IsTrue(speedtest.results.uiObject.sortByUpload().exists());
            Assert.IsTrue(speedtest.results.uiObject.logo().exists());
        }

        [Test]
        public void aboutActivity()
        {
            testinfo.id("test3").name("Verify the About activitiy has PP and ToU links");
            speedtest.beginTest.tapBeginTest();
            speedtest.menu.tapAbout();
            Assert.IsTrue(speedtest.about.uiObject.privacyPolicy().exists());
            Assert.IsTrue(speedtest.about.uiObject.termsOfUse().exists());
        }
    }
}
