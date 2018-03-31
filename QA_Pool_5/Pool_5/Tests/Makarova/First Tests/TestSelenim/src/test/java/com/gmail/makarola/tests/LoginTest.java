package com.gmail.makarola.tests;

import com.gmail.makarola.pages.BigmirLoginPage;
import com.gmail.makarola.pages.BigmirMailBoxPage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

import java.util.concurrent.TimeUnit;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class LoginTest {

    private static final String LOGIN = "makarola@bigmir.net";
    private static final String PASSWORD = "love14072001";
    private static final String EMAIL_REGEXP = "(\\w+@[_a-zA-Z]+?\\.[a-zA-Z]{2,6})";

    public static WebDriver driver;
    private static BigmirLoginPage loginPage;
    private static BigmirMailBoxPage mailBoxPage;

    @BeforeClass
    public static void setUp() {
        System.setProperty("webdriver.chrome.driver", "/home/makarola/IdeaProjects/chromedriver");
        driver = new ChromeDriver();
        loginPage = new BigmirLoginPage(driver);
        mailBoxPage = new BigmirMailBoxPage(driver);

        driver.manage().window().maximize();
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        driver.get("http://mail.bigmir.net");

    }

    @Test
    public void loginTest() {
        loginPage.getLoginField().sendKeys(LOGIN);
        loginPage.getPasswordField().sendKeys(PASSWORD);
        loginPage.getLoginButton().click();
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        String mailuser = mailBoxPage.getProfileUserLink().getText();
        Assert.assertEquals(LOGIN, mailuser);

        Assert.assertEquals(mailuser.matches(EMAIL_REGEXP), true, "The actual text is not an e-mail");
        String anotherElementText = mailBoxPage.getAnotherElement().getText();
        Assert.assertEquals(anotherElementText.matches(EMAIL_REGEXP), false, "The element " +
                anotherElementText + "is not an e-mail");

    }

    @AfterClass
    public static void tearDown() {
        mailBoxPage.getUserQuitButton().click();
        driver.close();
    }
}
