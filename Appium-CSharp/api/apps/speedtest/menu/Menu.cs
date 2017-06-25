using Appium_CSharp.api.android;
using Appium_CSharp.api.apps.speedtest.home;
using Appium_CSharp.api.interfaces;
using OpenQA.Selenium;
using System;

namespace Appium_CSharp.api.apps.speedtest.menu
{
    public class Menu : Activity
    {
        public MenuUiObjects uiObject = new MenuUiObjects();

        public Home tapSpeedTest()
        {
            try
            {
                uiObject.speedtest().tap();
                return Android.app.speedtest.home.waitToLoad();
            }
            catch (NoSuchElementException e)
            {
                throw new Exception("Can't tap Speedtest Button, element absent or blocked");
            }
        }

        public object tapResults()
        {
            try
            {
                uiObject.results().tap();
                return Android.app.speedtest.results.waitToLoad();
            }
            catch (NoSuchElementException e)
            {
                throw new Exception("Can't tap Results Button, element absent or blocked");
            }
        }

        public void tapSettings()
        {
            try
            {
                uiObject.settings().tap();
            }
            catch (NoSuchElementException e)
            {
                throw new Exception("Can't tap Settings Button, element absent or blocked");
            }
        }

        public object tapAbout()
        {
            try
            {
                uiObject.about().tap();
                return Android.app.speedtest.about.waitToLoad();
            }
            catch (NoSuchElementException e)
            {
                throw new Exception("Can't tap About Button, element absent or blocked");
            }
        }

        public Object waitToLoad()
        {
            try
            {
                uiObject.about().waitToAppear(10);
                return Android.app.speedtest.menu;
            }
            catch (Exception e)
            {
                throw new Exception("Menu activity failed to load/open");
            }
        }
    }
}
