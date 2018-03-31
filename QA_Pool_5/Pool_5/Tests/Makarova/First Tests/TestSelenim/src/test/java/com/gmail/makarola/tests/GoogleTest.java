package com.gmail.makarola.tests;

import com.gmail.makarola.pages.GooglePage;
import com.gmail.makarola.pages.GooglePageFound;
import com.gmail.makarola.pages.GoogleQueryPage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.testng.Assert;
import org.testng.annotations.AfterClass;
import org.testng.annotations.BeforeClass;
import org.testng.annotations.Test;

import java.util.concurrent.TimeUnit;

public class GoogleTest {

    private static final String SEARCH_QUERY = "автотесты";
    private static final String LINK_TEXT = "Как писать автотесты быстро - Заметки Автоматизатора";
    private static final String EXPECTED_TEXT = "Как писать автотесты быстро";

    public static WebDriver driver;
    private static GooglePage googlePage;
    private static GoogleQueryPage searchLink;
    private static GooglePageFound googlePageFound;

    @BeforeClass
    public static void setUp() {
        System.setProperty("webdriver.chrome.driver", "/home/makarola/IdeaProjects/chromedriver");
        driver = new ChromeDriver();
        googlePage = new GooglePage(driver);
        searchLink = new GoogleQueryPage(driver);
        googlePageFound = new GooglePageFound(driver);
        driver.manage().window().maximize();
        driver.manage().timeouts().implicitlyWait(10, TimeUnit.SECONDS);
        driver.get("https://google.com");

    }

    @Test

    public void searchTest() {
        googlePage.getSearchInputField().sendKeys(SEARCH_QUERY);
        googlePage.getSearchInputField().submit();
        String textSearch = searchLink.getLinkFound().getText();
        Assert.assertEquals(LINK_TEXT, textSearch, "Expected result != Actual result");
        searchLink.getLinkFound().click();
        String result = googlePageFound.getSearchResult().getText();
        Assert.assertEquals(EXPECTED_TEXT, result, "Expected result != Actual result");
    }

    @AfterClass
    public static void tearDown() {
        driver.close();
    }
}
