using System;


namespace Pool_5
{
   class LoginPage
    {
        internal string OpenLoginWindow = "//a[@class='enter']";
        internal string OpenGooglePlus = "//div[@class='b-popup-i']//ul/li[3]/a";
        internal string GoogleInputEmail = "//input[@type='email']";
        internal string SubmitNextToPassword = "//*[@id='identifierNext']/content/span";
        internal string GoogleInputPassword = "//div[@id='password']//input";
        internal string SubmitPassword = "//*[@id='passwordNext']/content/span";
        internal string UserNameInLoginWindow = "//span[@class='uname']";
    }
}
