using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using sample.Support;
using OpenQA.Selenium.Support.UI;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace sample.StepDefinitions
{
    [Binding]
    public class Task1StepDefinitions
    {
        readonly HomeAndOrderPage homeAndOrderPage = new HomeAndOrderPage();
        CheckOutPage checkOutPage = new CheckOutPage();

        IWebDriver driver;
        public Task1StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"I am at the home page of web application\.")]
        public void GivenIAmAtTheHomePageOfWebApplication_()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://teststoreforsouthafri.nextbasket.shop/");
           
          
           
           
           


            //Console.WriteLine(str + " Given SE");

        }



        [When(@"I click on the first product\.")]
        public void WhenIClickOnTheFirstProduct_()
        {
            SeleniumSetMethods.ExplicitWait(element: homeAndOrderPage.FirstProductXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.ClickBtn(element: homeAndOrderPage.FirstProductXpath, driver: driver, type: PropertyType.Xpath);

        }

        [When(@"I click add to basket\.")]
        public void WhenIEnterAddToBasket_()
        {
            SeleniumSetMethods.ExplicitWait(element: homeAndOrderPage.AddToBasketXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.ClickBtn(element: homeAndOrderPage.AddToBasketXpath, driver: driver, type: PropertyType.Xpath);
            Thread.Sleep(5000);

        }

        [When(@"I click on basket and click on go to payment\.")]
        public void WhenIClickOnBasketAndClickOnGoToPayment_()
        {

            SeleniumSetMethods.ExplicitWait(element: homeAndOrderPage.BasketBtnXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.ClickBtn(element: homeAndOrderPage.BasketBtnXpath, driver: driver, type: PropertyType.Xpath);


            SeleniumSetMethods.ExplicitWait(element: homeAndOrderPage.GoToPaymentXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.ClickBtn(element: homeAndOrderPage.GoToPaymentXpath, driver: driver, type: PropertyType.Xpath);

          
        }

        [When(@"I enter email and click on Continue As Guest button\.")]
        public void WhenIEnterEmailAndClickOnContinueAsGuestButton_()
        {
            SeleniumSetMethods.ExplicitWait(element: homeAndOrderPage.GuestEmailInputBarXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.EnterText(element: homeAndOrderPage.GuestEmailInputBarXpath, driver: driver, type: PropertyType.Xpath, text: "jen@gmail.com");
            SeleniumSetMethods.ClickBtn(element: homeAndOrderPage.ContinueAsGuestBtnXpath, driver: driver, type: PropertyType.Xpath);


        }



        [Then(@"I enter all the details on check out page and click on confirm order\.")]
        public void WhenIEnterAllTheDetailsOnCheckOutPageAndClickOnConfirmOrder_()
        {
            //checkout page

            SeleniumSetMethods.ExplicitWait(element: checkOutPage.UsernameXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.EnterText(element: checkOutPage.UsernameXpath, driver: driver, type: PropertyType.Xpath, text: "Awais");
            SeleniumSetMethods.EnterText(element: checkOutPage.SirnameXpath, driver: driver, type: PropertyType.Xpath, text: "Awais");
            SeleniumSetMethods.EnterText(element: checkOutPage.PhoneXpath, driver: driver, type: PropertyType.Xpath, text: "123456789");

            //Thread.Sleep(10000);

            SeleniumSetMethods.ExplicitWait(element: checkOutPage.CountryInputXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.EnterText(element: checkOutPage.CountryInputXpath, driver: driver, type: PropertyType.Xpath, text: "Africa");
            SeleniumSetMethods.ClickBtn(element: checkOutPage.SAOptionXpath, driver: driver, type: PropertyType.Xpath);

            //SeleniumSetMethods.ExplicitWait(element: checkOutPage.CityInputXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.EnterText(element: checkOutPage.CityInputXpath, driver: driver, type: PropertyType.Xpath, text: "Alberton");
            //Thread.Sleep(10000);
            SeleniumSetMethods.ExplicitWait(element: checkOutPage.AlbertonCityXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.ClickBtn(element: checkOutPage.AlbertonCityXpath, driver: driver, type: PropertyType.Xpath);

            SeleniumSetMethods.ExplicitWait(element: checkOutPage.PostCodeXpath, driver: driver, type: PropertyType.Xpath);
            SeleniumSetMethods.EnterText(element: checkOutPage.PostCodeXpath, driver: driver, type: PropertyType.Xpath, text: "1447");
            SeleniumSetMethods.EnterText(element: checkOutPage.AddressXpath, driver: driver, type: PropertyType.Xpath, text: "Alberton");
            SeleniumSetMethods.ClickBtn(element: checkOutPage.ConfirmOrderXpath, driver: driver, type: PropertyType.Xpath);

            Thread.Sleep(15000);
        }

        [Then(@"I check every product whether it has (.*) percent label or not\.")]
        public void ThenICheckEveryProductWhetherItHasPercentLabelOrNot_(int p0)
        {
           IList<IWebElement> total_products =   driver.FindElements(By.XPath(checkOutPage.ProductCountXpath));
            Console.WriteLine(total_products.Count);
           
                for (int j = 1; j <= total_products.Count; j++)
                {
                string product_text = String.Format(checkOutPage.GettingTextofProductXpath, j);
                string product_label = String.Format(checkOutPage.GettingLabelofProduct, j);

                string name = driver.FindElement(By.XPath(product_text)).Text;
                try
                {
                        
                        string label = driver.FindElement(By.XPath(product_label)).Text;

                        Console.WriteLine(name + " has discount label of :  " + label);

                }
                catch 
                {
                    Console.WriteLine(name + " doest not have any label" );
                }
            }
            
        }


    }
}
