// Задание 2 
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
using AutoTestRainur;

[TestFixture]
public class LoginAndLogout2Test:TestBase {
    
    [Test]
    public void loginAndLogout2Test()
    {
        app.Navigation.OpenHomePage();
        AccountData user = new AccountData("admin2020", "RainurAdmin2000");
        app.Auth.Login(user);
        app.Auth.Logout();
    }
}