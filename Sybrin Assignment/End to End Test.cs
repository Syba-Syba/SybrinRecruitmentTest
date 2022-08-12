using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace Sybrin_Assignment
{
    public class Tests
    {
        private IWebDriver driver;

        private string TestUrl = "https://recruitmenta.sybrin.com/AppBuilder/#/TestingScreen";


        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\");
            driver.Manage().Window.Maximize();
        }

        

        [Test]
        public void EndToEnd()
        {            
            driver.Url = TestUrl; 
            System.Threading.Thread.Sleep(3000);
            //Login Page, input credentials and click login button
            driver.FindElement(By.Id("usernameBox")).SendKeys("TesterInterview");
            driver.FindElement(By.Id("passwordBox")).SendKeys("ek5Gr%$sLRXd!rTx");
            driver.FindElement(By.Id("btn_logon")).Click();
            System.Threading.Thread.Sleep(20000);

            //fill in Username
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[1]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-input/div/input")).SendKeys("Lehlohonolo");
            //fill in Last name
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[2]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-input/div/input")).SendKeys("Mokoena");
            //fill in DOB
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[3]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-input/div/input")).SendKeys("10 Sep 1996");
            //fill in time of submission
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[4]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-date-time/div/div[1]/button/i")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/div/button")).Click();
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[4]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-date-time/div/div[2]/button")).Click();
            driver.FindElement(By.XPath("/html/body/div/div/div/button")).Click();
            //fill in Number
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[6]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-input/div/input")).SendKeys("0123456789");
            //fill in Address
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[1]/div/sybrin-plugin-child-loader/div/div/div/div/form-runtime/div/lib-plugin-host/sybrin-plugin-child-loader/div/div/div/div/panel-runtime/panel-display/div/div/div[2]/lib-plugin-host/sybrin-plugin-child-loader/div/div[7]/div/div/form-control-runtime/form-control-display/dynamic-sybrin-form/dynamic-sybrin-form-control/div/div/sybrin-input/div/input")).SendKeys("Broken");
            //Click submit button
            driver.FindElement(By.XPath("/html/body/app-root/div/app-simple/sybrin-preview/sybrin-app-host/sybrin-preview-app-host/div/div/sybrin-layout-vertical/div/div/nav[2]/div/layout-main-content/form-preview/div/div/div/div/div/grid-layout-runtime/div/div[2]/div/sybrin-plugin-child-loader/div/div[1]/div/div/button-runtime/button")).Click();
            System.Threading.Thread.Sleep(2000);
            //Click submit confirmation button
            driver.FindElement(By.XPath("/ html / body / div / div / div[3] / button[1]")).Click();
            System.Threading.Thread.Sleep(3000);
            //Close window
            driver.Quit();
            Assert.Pass();

        }
    }
}