using Appium_CSharp.api.android;
using Appium_CSharp.api.apps.kitornottest;
using Appium_CSharp.api.apps.kitTest.home;
using Appium_CSharp.core.managers;
using NUnit.Framework;
using System;
using System.Threading;

namespace Appium_CSharp.tests
{
    [TestFixture]
    public class KitNavigation : TestManager
    {
        private static KitornotTest kitTest = Android.app.kitornottest;

        [SetUp]
        public void Init()
        {
            testinfo.suite("KitNavigation");

            core.Timer timer = new core.Timer();
            timer.start();
            while (!timer.expired(10))
            {
                try
                {
                    Thread.Sleep(500);
                    if (!kitTest.login.userName().exists()) kitTest.clickBack();
                }
                catch (Exception e) { }
            }
        }

        [TearDown]
        public void Cleanup()
        {
            
        }

        [Test]
        public void homeActivity()
        {
            UserHomeActivity home = new UserHomeActivity();
            testinfo.id("Test2").name("Verify that User Home Activity has all elements");
            kitTest.login.login("Callie", "333");
            kitTest.verifyElementExists(home.userCatsTitle());
            kitTest.verifyElementExists(home.userCatsTitle());
            kitTest.verifyElementExists(home.addImageBtn());
            kitTest.verifyElementExists(home.gridView());
            kitTest.verifyElementExists(home.gridImage0());
            kitTest.verifyElementExists(home.gridImage1());
            kitTest.verifyElementExists(home.ratingActivityBtn());
            kitTest.verifyElementExists(home.topCatsBtn());
        }

        [Test]
        public void ratingActivity()
        {

            testinfo.id("Test3").name("Verify that Rating Activity has all elements");
            kitTest.login.login("Callie", "333");
            kitTest.userHomeActivity.tapRatingActivityBtn().waitToLoad();
            Assert.IsTrue(kitTest.ratingActivity.catImage().exists());
            Assert.IsTrue(kitTest.ratingActivity.thumbDown().exists());
            Assert.IsTrue(kitTest.ratingActivity.thumbUp().exists());
        }

        [Test]
        public void topCatsActivity()
        {
            testinfo.id("Test4").name("Verify that Top Cats Activity has all elements");
            kitTest.login.login("Callie", "333");
            kitTest.userHomeActivity.tapTopCatsBtn().waitToLoad();
            Assert.IsTrue(kitTest.topCatsActivity.topCatTitle().exists());
            Assert.IsTrue(kitTest.topCatsActivity.gridview().exists());
            Assert.IsTrue(kitTest.topCatsActivity.gridImage0().exists(), "Cat image 1 did not load in top cats activity");
            Assert.IsTrue(kitTest.topCatsActivity.gridImage1().exists(), "Cat image 2 did not load in top cats activity");
        }

        [Test]
        public void addImage()
        {
            testinfo.id("Test5").name("Add image from phone successfully");
            kitTest.login.login("ccc", "333");
            kitTest.userHomeActivity.tapAddCatImageBtn().waitToLoad();
            Assert.IsTrue(kitTest.photoAlbumActivity.selectAlbumTitle().exists());
            kitTest.photoAlbumActivity.tapMainImage().waitToLoad();
            Assert.IsTrue(kitTest.selectImageActivity.selectAlbumTitle().exists());
            kitTest.selectImageActivity.tapSelectImage().waitToLoad();
            Assert.IsTrue(kitTest.userHomeActivity.gridImage0().exists());
            kitTest.userHomeActivity.gridImage0().longClick();
            Assert.IsTrue(kitTest.userHomeActivity.deleteBtn().exists());
            kitTest.userHomeActivity.deleteBtn().tap();
            Assert.IsTrue(!kitTest.userHomeActivity.gridImage0().exists());
        }
    }
}
