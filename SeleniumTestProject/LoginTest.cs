using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestProject
{
    [TestFixture]
    public class LoginTest
    {
        private IWebDriver? driver; // Make driver nullable to allow null assignment

        [SetUp]
        public void Setup()
        {
            try
            {
                // Initialize ChromeDriver
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // Add implicit wait for stability
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Setup failed: {ex.Message}");
                throw; // Rethrow to fail the test if setup fails
            }
        }

        [Test]
        public void TestLogin()
        {
            try
            {
                // Navigate to the test website
                driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/login"); // Use ! to assert driver is not null

                // Find username and password fields, and submit button
                IWebElement usernameField = driver.FindElement(By.Id("username"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                IWebElement loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));

                // Enter credentials
                usernameField.SendKeys("tomsmith");
                passwordField.SendKeys("SuperSecretPassword!");
                loginButton.Click();

                // Verify successful login
                IWebElement successMessage = driver.FindElement(By.CssSelector(".flash.success"));
                Assert.IsTrue(successMessage.Displayed, "Login failed! Success message not displayed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                throw; // Rethrow to fail the test and log the issue
            }
        }

        [Test]
        public void TestInvalidLogin()
        {
            try
            {
                // Navigate to the test website
                driver!.Navigate().GoToUrl("https://the-internet.herokuapp.com/login");

                // Find username and password fields, and submit button
                IWebElement usernameField = driver.FindElement(By.Id("username"));
                IWebElement passwordField = driver.FindElement(By.Id("password"));
                IWebElement loginButton = driver.FindElement(By.CssSelector("button[type='submit']"));

                // Enter invalid credentials
                usernameField.SendKeys("invalidUser");
                passwordField.SendKeys("wrongPassword");
                loginButton.Click();

                // Verify error message is displayed
                IWebElement errorMessage = driver.FindElement(By.CssSelector(".flash.error"));
                Assert.IsTrue(errorMessage.Displayed, "Invalid login test failed! Error message not displayed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Test failed: {ex.Message}");
                throw; // Rethrow to fail the test and log the issue
            }
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                // Close the browser and dispose of the driver
                if (driver != null)
                {
                    driver.Quit(); // Close all browser windows and end the session
                    driver.Dispose(); // Release all resources
                    driver = null; // This is now safe since driver is nullable
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"TearDown failed: {ex.Message}");
            }
        }
    }
}