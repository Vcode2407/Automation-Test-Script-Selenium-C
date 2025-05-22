# Selenium Testing Framework

A framework to test login functionality for The Internet using Selenium WebDriver and C#.

## Setup

1.  **Clone Repository:**
    Run: `git clone https://github.com/vcode2407/Automation-Test-Script-Selenium-C.git`
    Navigate to folder: `cd Automation-Test-Script-Selenium-C`

2.  **Open Solution:**
    Open `SeleniumTestProject.sln` in Visual Studio 2022.

3.  **Install Dependencies:**
    Restore NuGet packages: `Selenium.WebDriver`, `NUnit`, `Selenium.WebDriver.ChromeDriver`.

4.  **Run Tests:**
    In Visual Studio, open Test Explorer (Ctrl+E, T).
    Run tests: `TestLogin`, `TestInvalidLogin`, `TestEmptyCredentials`.

## Tech Stack

* **Testing:** Selenium WebDriver, NUnit
* **Language:** C#
* **Environment:** .NET 6.0, Visual Studio 2022
* **Browser:** Google Chrome

## Output

* **Test results:** Displayed in Visual Studio Test Explorer
* **Browser:** Automated Chrome browser opens during tests
* **CI:** GitHub Actions logs at [https://github.com/vcode2407/Automation-Test-Script-Selenium-C/actions](https://github.com/vcode2407/Automation-Test-Script-Selenium-C/actions)
