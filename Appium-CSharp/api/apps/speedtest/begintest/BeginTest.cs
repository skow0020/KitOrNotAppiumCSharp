using Appium_CSharp.api.android;
using Appium_CSharp.api.apps.speedtest.home;
using Appium_CSharp.api.interfaces;
using OpenQA.Selenium;
using System;

namespace Appium_CSharp.api.apps.speedtest.begintest
{
    public class BeginTest : Activity
    {
        public BeginTestUiObjects uiObject = new BeginTestUiObjects();

        public Home tapBeginTest()
        {
            try
            {
                uiObject.beginTestButton().waitToAppear(20);
                uiObject.beginTestButton().tap();
                Android.app.speedtest.home.uiObject.testAgainButton().waitToAppear(120);
                return Android.app.speedtest.home;
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("Can't tap Begin Test button, element absent or blocked");
            }
            catch (Exception e)
            {
                throw new Exception("Speedtest failed to complete within 120 seconds");
            }
        }

        public object waitToLoad()
        {
            try
            {
                uiObject.beginTestButton().waitToAppear(10);
                return Android.app.speedtest.beginTest;
            }
            catch (Exception e)
            {
                throw new Exception("Begin Test activity failed to load/open");
            }
        }
    }
}
