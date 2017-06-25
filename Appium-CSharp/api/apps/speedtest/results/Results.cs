using Appium_CSharp.api.android;
using Appium_CSharp.api.interfaces;
using OpenQA.Selenium;
using System;

namespace Appium_CSharp.api.apps.speedtest.results
{
    public class Results : Activity
    {
        public ResultsUiObjects uiObject = new ResultsUiObjects();

        public Results sortBy(String sortType)
        {
            try
            {
                sortType = sortType.ToLower();
                if (sortType.Equals("type")) uiObject.sortByType().tap();
                else if (sortType.Equals("time")) uiObject.sortByTime().tap();
                else if (sortType.Equals("download")) uiObject.sortByDownload().tap();
                else if (sortType.Equals("upload")) uiObject.sortByUpload().tap();
                else if (sortType.Equals("ping")) uiObject.sortByPing().tap();
                else throw new Exception("Sorting by type " + sortType + " is not supported");
                return Android.app.speedtest.results;
            }
            catch (NoSuchElementException e)
            {
                throw new NoSuchElementException("Can't sort by " + sortType + ", element absent or blocked");
            }
        }

        public object waitToLoad()
        {
            try
            {
                uiObject.resultsLabel().waitToAppear(10);
                return Android.app.speedtest.results;
            }
            catch (Exception e)
            {
                throw new Exception("Results activity failed to load/open");
            }
        }
    }
}
