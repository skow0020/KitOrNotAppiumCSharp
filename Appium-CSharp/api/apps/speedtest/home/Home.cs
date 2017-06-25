using Appium_CSharp.api.android;
using OpenQA.Selenium;
using System;

namespace Appium_CSharp.api.apps.speedtest.home
{
    public class Home
    {
        public HomeUiObjects uiObject = new HomeUiObjects();

        public String getPingSpeed()
        {
            try
            {
                return uiObject.pingSpeed().getText();
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("Can't get Ping Speed, element absent or blocked");
            }
        }

        public String getDownloadSpeed()
        {
            try
            {
                return uiObject.downloadSpeed().getText();
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("Can't get Download Speed, element absent or blocked");
            }
        }

        public String getUploadSpeed()
        {
            try
            {
                return uiObject.uploadSpeed().getText();
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("Can't get Upload Speed, element absent or blocked");
            }
        }

        public Home tapTestAgain()
        {
            try
            {
                uiObject.testAgainButton().tap().waitToDisappear(5).waitToAppear(120);
                return Android.app.speedtest.home;
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("Can't tap Test Again button, element absent or blocked");
            }
        }


        public Home waitToLoad()
        {
            try
            {
                uiObject.testAgainButton().waitToAppear(10);
                return Android.app.speedtest.home;
            }
            catch (Exception e)
            {
                throw new Exception("Home activity failed to load/open");
            }
        }
    }
}
