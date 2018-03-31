package com.gmail.makarola.pages;

import com.gmail.makarola.BasePage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class GoogleQueryPage extends BasePage {

    public GoogleQueryPage(WebDriver driver) {
        super(driver);
    }

    @FindBy(xpath = "//a[contains(., ' Заметки Автоматизатора')]")
    private WebElement linkFound;

    public WebElement getLinkFound() {
        return linkFound;
    }
}
