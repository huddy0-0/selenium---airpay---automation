var records = GoogleSheetsReader.ReadGoogleSheet();

foreach (var record in records)
{
    string tin = record["TIN"];
    string firstName = record["First Name"];
    string lastName = record["Last Name"];
    string email = record["Email"];

    IWebElement tinInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-tin-0']")));
    tinInput.Clear();
    tinInput.SendKeys(tin);

    IWebElement firstNameInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-firstnm']")));
    firstNameInput.Clear();
    firstNameInput.SendKeys(firstName);

    IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@data-test='txt-email']")));
    emailInput.Clear();
    emailInput.SendKeys(email);
}
