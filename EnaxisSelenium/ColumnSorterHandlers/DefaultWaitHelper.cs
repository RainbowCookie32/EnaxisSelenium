﻿using EnaxisSelenium.ColumnSorterHandlers.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace EnaxisSelenium.ColumnSorterHandlers
{
    public class DefaultWaitHelper : IWaitHelper
    {
        public void WaitForInvisibilityOfElement(IWebDriver webDriver, By elementLocator)
        {
            var wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.InvisibilityOfElementLocated(elementLocator));
        }
    }
}
