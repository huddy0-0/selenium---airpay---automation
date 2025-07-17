using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using System;

class Program
{
    static void Main()
    {
        // Initialize ChromeDriver
        IWebDriver driver = new ChromeDriver();

        // Navigate to the registration page
        driver.Navigate().GoToUrl("https://cignaforhcp.cigna.com/app/registration/lob");

        // Maximize the window
        driver.Manage().Window.Maximize();

        // Set up an explicit wait
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        // Function to introduce delay between actions
        void SlowDown() {
            Random rand = new Random();
            System.Threading.Thread.Sleep(rand.Next(1, 2)); // Random delay
        }

        // Wait for the second checkbox
        IWebElement dentalCheckbox = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//i[@class='chcp-radio-img'])[2]")));
        SlowDown();

        // Click the checkbox if it's not selected already
        if (!dentalCheckbox.Selected)
        {
            dentalCheckbox.Click();
        }

        SlowDown();

        // Wait for the Next button to be clickable
        IWebElement nextButton1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@data-test='btn-next']")));
        nextButton1.Click();
        SlowDown();

        // Wait for the TIN input field
        IWebElement tinInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-tin-0']")));
        tinInput.Clear();
        tinInput.SendKeys("123456789");

        SlowDown();

        // Wait for the Save
        IWebElement saveButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@data-test='save-btn']")));
        saveButton.Click();

        SlowDown();

        // Wait for the Next
        IWebElement nextButton2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@data-test='btn-next']")));
        nextButton2.Click();
        SlowDown();

        // Wait for the first name input field
        IWebElement firstNameInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-firstnm']")));
        firstNameInput.Clear();
        firstNameInput.SendKeys("John");

        SlowDown();

        // Wait for the last name input field
        IWebElement lastNameInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-lastnm']")));
        lastNameInput.Clear();
        lastNameInput.SendKeys("Doe");

        SlowDown();

        // Wait for the job title dropdown and select a value
        IWebElement jobTitleDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-job-roles']")));
        var selectElement = new SelectElement(jobTitleDropdown);
        selectElement.SelectByValue("10-Clinical: nurse or care coordination"); // Select a job role

        SlowDown();

        // Wait for the address line 1
        IWebElement addressInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-addressline1']")));
        addressInput.Clear();
        addressInput.SendKeys("1234 Business St.");

        SlowDown();

        // Wait for the city input
        IWebElement cityInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-city']")));
        cityInput.Clear();
        cityInput.SendKeys("Sample City");

        SlowDown();

        // Wait for the state dropdown
        IWebElement stateDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-state']")));
        var selectState = new SelectElement(stateDropdown);
        selectState.SelectByValue("CA");

        SlowDown();

        // Wait for the zip code input
        IWebElement zipCodeInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-zipcode']")));
        zipCodeInput.Clear();
        zipCodeInput.SendKeys("90210");

        SlowDown();

        // Wait for the first part of the office phone number (area code)
        IWebElement phone1Input = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-phone1']")));
        phone1Input.Clear();
        phone1Input.SendKeys("123");

        SlowDown();

        // Wait for the second phone number
        IWebElement phone2Input = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-phone2']")));
        phone2Input.Clear();
        phone2Input.SendKeys("456");

        SlowDown();

        // Wait for the third part of phone number 
        IWebElement phone3Input = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-phone3']")));
        phone3Input.Clear();
        phone3Input.SendKeys("7890");

        SlowDown();

        // Wait for the email input field
        IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-email']")));
        emailInput.Clear();
        emailInput.SendKeys("johndoe@example.com");

        SlowDown();

        // Wait for the confirm email input field
        IWebElement confirmEmailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-confirm-email']")));
        confirmEmailInput.Clear();
        confirmEmailInput.SendKeys("johndoe@example.com");

        SlowDown();

        // Wait for the user ID input field
        IWebElement userIdInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-userid']")));

        // Enable the user ID (overrides the disabled attribute with jscript)
        IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        js.ExecuteScript("arguments[0].removeAttribute('disabled');", userIdInput);

        // Wait for the field
        wait.Until(ExpectedConditions.ElementToBeClickable(userIdInput));

        SlowDown();

        // Enter the user ID
        userIdInput.SendKeys("TechExplorer2025");

        SlowDown();

        // Wait for the password input
        IWebElement passwordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-password']")));
        passwordInput.Clear();
        passwordInput.SendKeys("Password1!");

        SlowDown();

        // Wait for confirm password
        IWebElement confirmPasswordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-confirm-password']")));
        confirmPasswordInput.Clear();
        confirmPasswordInput.SendKeys("Password1!");

        SlowDown();

        // Wait for the Month dropdown
        IWebElement monthDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-month']")));
        var selectMonth = new SelectElement(monthDropdown);
        selectMonth.SelectByValue("01");

        // Wait for the Day dropdown
        IWebElement dayDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-day']")));
        var selectDay = new SelectElement(dayDropdown);
        selectDay.SelectByValue("15");

        // Wait for the Year dropdown
        IWebElement yearDropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-year']")));
        var selectYear = new SelectElement(yearDropdown);
        selectYear.SelectByValue("1995");

        // Security Questions Section:
        // Select the first security question
        IWebElement secQuestion1Dropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-challenge-question1']")));
        var selectSecQuestion1 = new SelectElement(secQuestion1Dropdown);
        selectSecQuestion1.SelectByValue("What street did you live on in sixth grade?");

        // Wait for the first answer
        IWebElement secAnswer1Input = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-challenge-answer1']")));
        secAnswer1Input.Clear();
        secAnswer1Input.SendKeys("Maple Street");

        // Select the second security question
        IWebElement secQuestion2Dropdown = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//select[@data-test='cmb-challenge-question2']")));
        var selectSecQuestion2 = new SelectElement(secQuestion2Dropdown);
        selectSecQuestion2.SelectByValue("What was your high school's mascot?");

        // Wait for the second answer
        IWebElement secAnswer2Input = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-challenge-answer2']")));
        secAnswer2Input.Clear();
        secAnswer2Input.SendKeys("Tigers");

        // Wait for the final Next
        IWebElement nextButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@data-test='btn-next']")));
        nextButton.Click();

        // Wait observe
        System.Threading.Thread.Sleep(5000);

        // Close the browser
        //driver.Quit();
    }
}
