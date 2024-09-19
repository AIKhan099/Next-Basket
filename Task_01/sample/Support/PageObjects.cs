using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample.Support
{
    internal class HomeAndOrderPage
    {
        public string  UsernameInputBarXpath = "//input[@data-qa=\"login-email\"]";
        public string  PasswordInputBarXpath = "//input[@data-qa=\"login-password\"]";
        public string SubmitBtnXpath = "//button[@data-qa=\"login-button\"]";

        public string FirstProductXpath = "(//a[@href=\"/p/painting-c-pkqrv6\"])[1]";
        public string AddToBasketXpath = "//button[@class=\"_2FTCz _1zffG Ck0CN ll85s -xvsH ESV2M\"]";
        public string BasketBtnXpath = "//button[@class=\"_2FTCz zlyBa nExvj ll85s R9U-8\"]";
        public string GoToPaymentXpath = "//a[@class=\"stWcf _2FTCz _1zffG Ck0CN ll85s -xvsH\"]";
        public string GuestEmailInputBarXpath = "//input[@name=\"email\"]";
        public string ContinueAsGuestBtnXpath = "//button[@data-testid=\"guestLogin\"]";

    }

    public class CheckOutPage
    {
        public string UsernameXpath = "//input[@name=\"shippingAddress.firstName\"]";
        public string SirnameXpath = "//input[@name=\"shippingAddress.lastName\"]";
        public string PhoneXpath = "//input[@name=\"shippingAddress.phone\"]";
        
        public string SAOptionXpath = "//li[@class=\"Autocomplete_autocomplete__option__m4TF9\"]/p[contains(text(),\"South Africa\")]";
        public string AlbertonCityXpath = "//li[@class=\"Autocomplete_autocomplete__option__m4TF9\"]/p[contains(text(), \"Alberton\")]";

        public string CountryInputXpath = "(//input[@data-testid=\"autocompleteInput\"])[1]";
        public string CityInputXpath = "(//input[@data-testid=\"autocompleteInput\"])[2]";
        public string PostCodeXpath = "//input[@name=\"shippingAddress.postCode\"]";
        public string AddressXpath = "//input[@name=\"shippingAddress.address\"]";
        public string ConfirmOrderXpath = "//button[@data-testid=\"goToNextStep\"]";
        
        public string GettingTextofProductXpath = "((//div[@class=\"grid lg:grid-cols-6 md:grid-cols-4 grid-cols-2 gap-3 col-span-12 col-start-0\"]/div)[{0}]/div)[2]/a/p";
        public string GettingLabelofProduct = "(((//div[@class=\"grid lg:grid-cols-6 md:grid-cols-4 grid-cols-2 gap-3 col-span-12 col-start-0\"]/div)[{0}]/div)[1]/div/div)[2]/p";
        public string ProductCountXpath = "//div[@class=\"grid lg:grid-cols-6 md:grid-cols-4 grid-cols-2 gap-3 col-span-12 col-start-0\"]/div";




    }
}
