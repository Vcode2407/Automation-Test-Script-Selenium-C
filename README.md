Selenium Test Project
This project is an automated testing suite built with Selenium WebDriver and C# to test the login functionality of The Internet. It uses NUnit for assertions and includes a GitHub Actions CI pipeline for automated testing.
Project Overview
The project automates login tests for the following scenarios:

Valid Login: Tests successful login with correct credentials (tomsmith / SuperSecretPassword!).
Invalid Login: Tests login with incorrect credentials.
Empty Credentials: Tests login with empty username and password fields.

Prerequisites

Windows 10/11
Visual Studio 2022 or later
.NET 6.0 SDK
Google Chrome (latest version)
ChromeDriver (via NuGet or matching Chrome version)
Git

Setup Instructions

Clone the Repository:
git clone https://github.com/vcode2407/Automation-Test-Script-Selenium-C.git
cd Automation-Test-Script-Selenium-C


Open the Solution:

Open SeleniumTestProject.sln in Visual Studio.


Restore NuGet Packages:

In Visual Studio, go to Tools > NuGet Package Manager > Manage NuGet Packages for Solution.
Restore packages: Selenium.WebDriver, NUnit, Selenium.WebDriver.ChromeDriver.


Verify ChromeDriver:

Ensure Selenium.WebDriver.ChromeDriver NuGet package is installed.
Alternatively, download ChromeDriver from chromedriver.chromium.org and add it to your PATH.



Running Tests

Open Test Explorer in Visual Studio (Ctrl+E, T).
Run all tests or select TestLogin, TestInvalidLogin, or TestEmptyCredentials.
View results in Test Explorer.

Project Structure
SeleniumTestProject/
├── .github/workflows/ci.yml       # GitHub Actions CI configuration
├── .gitignore                    # Git ignore file
├── SeleniumTestProject.sln       # Solution file
├── SeleniumTestProject/
│   ├── LoginTest.cs              # Login test cases
│   ├── SeleniumTestProject.csproj # Project file

CI Pipeline
The .github/workflows/ci.yml file defines a GitHub Actions workflow that:

Runs on push or pull_request to the master branch.
Builds and tests the project using .NET 6.0 on Ubuntu.
View results in the Actions tab on GitHub.

Contributing

Fork the repository.
Create a feature branch: git checkout -b feature/your-feature.
Commit changes: git commit -m "Add your feature".
Push: git push origin feature/your-feature.
Open a pull request.

