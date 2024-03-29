﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    class Program
    {
        IWebDriver driver;

        static void Main(string[] args)
        {

        }

        [Test]
        public void LaunchFirefoxBrowserTest() {
        FirefoxDriverLauncher.LaunchFirefoxBrowser("https://www.google.com");
        }

        [Test]
        public void LaunchChromeBrowserTest() {
        FirefoxDriverLauncher.LaunchFirefoxBrowser("https://www.youtube.com");
        }

        [Test]
        public void LaunchFirefoxBrowser()  {
        driver = new FirefoxDriver();
        driver.Navigate().GoToUrl("https://www.google.com");
        Console.Write("Google Search");
        }

        [Test]
        public void LaunchChromeBrowser()   {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.amazon.com");
        Console.Write("Searching in Amazon....");
        IWebElement element = driver.FindElement(By.XPath("//input[@id='twotabsearchtextbox']"));
        element.SendKeys("Osama Bin Laden");
        element.SendKeys(Keys.Tab);
        element.SendKeys(Keys.Enter);
        }

        [Test]
        public void GmailSignUpTest()   {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://accounts.google.com/signup/v2/webcreateaccount?hl=en-GB&flowName=GlifWebSignIn&flowEntry=SignUp");
        Console.Write("Regintering new gmail account..");
        Methods.InputText(driver, "firstName", "Mohammad", "Id");
        }

        /*[TearDown]
        public void CloseBrowser()  {
        driver.Close();
        }*/
    }
}