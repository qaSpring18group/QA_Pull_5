package com.gmail.makarola.pages;

import com.gmail.makarola.BasePage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class GooglePage extends BasePage {

    public GooglePage(WebDriver driver) {
        super(driver);
    }


    @FindBy(name = "q")
    private WebElement searchInputField;

    public WebElement getSearchInputField() {
        return searchInputField;
    }
}
