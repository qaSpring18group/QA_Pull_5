package com.gmail.makarola.pages;

import com.gmail.makarola.BasePage;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.WebElement;
import org.openqa.selenium.support.FindBy;

public class BigmirLoginPage extends BasePage {
    public BigmirLoginPage(WebDriver driver) {
        super(driver);
    }

    @FindBy(id = "login")
    private WebElement loginField;

    @FindBy(id = "pass")
    private WebElement passwordField;

    @FindBy(css = ".b-login-form__button")
    private WebElement loginButton;

    public WebElement getLoginField() {
        return loginField;
    }

    public WebElement getPasswordField() {
        return passwordField;
    }

    public WebElement getLoginButton() {
        return loginButton;
    }
}
