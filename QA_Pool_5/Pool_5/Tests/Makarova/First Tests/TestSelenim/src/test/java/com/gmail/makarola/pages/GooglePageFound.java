package com.gmail.makarola.pages;

import com.gmail.makarola.BasePage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class GooglePageFound extends BasePage{

    public GooglePageFound(WebDriver driver) {
        super (driver);
    }

    @FindBy(xpath = "//h1[contains(., 'Как писать автотесты быстро')]")
    private WebElement searchResult;

    public WebElement getSearchResult() {
        return searchResult;
    }
}
