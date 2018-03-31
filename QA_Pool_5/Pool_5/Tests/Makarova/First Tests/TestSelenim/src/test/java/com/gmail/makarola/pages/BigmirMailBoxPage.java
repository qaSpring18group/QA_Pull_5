package com.gmail.makarola.pages;

import com.gmail.makarola.BasePage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class BigmirMailBoxPage extends BasePage {

    public BigmirMailBoxPage(WebDriver driver) {
        super(driver);
    }

    @FindBy(xpath = ".//a[contains(., 'makarola@bigmir.net')]")
    private WebElement profileUserLink;

    @FindBy(xpath = "//span[text()='Выйти']")
    private WebElement userQuitButton;


    @FindBy(id = "nextLink")
    private  WebElement anotherElement;

    public WebElement getProfileUserLink() {
        return profileUserLink;
    }

    public WebElement getUserQuitButton() {
        return userQuitButton;
    }

    public WebElement getAnotherElement() {
        return anotherElement;
    }

}
