# TestChek


# Synopsis
This is an ASP.net MVC/Web API application. It is designed to simulate a website where users (i.e. patients) can log in and access their medical records as soon as they are completed, 
as opposed to waiting for a letter in the mail or a phone call. Additionally, visitors of the website can find resources for learning about specific tests (e.g. the purpose of specific tests and what result values indicate) and laboratory testing, in general.

# Useage
Download the zip file and, after unzipping, open the solution file in Microsoft Visual Studio. Open the "Web.config" file and, within the "Data Source=" section of "ConnectionStrings", change the two instances of "YourServerName" to the appropriate server name where you intend to store the accompanying SQL database file that is included with this project.
SQL Server Authentication was set up using the following:
Username: TestChekSimulator
Password: Admin

In Microsoft SQL Server Management Studio, right click on the "Databases" tab (the child of your Server) and select "Restore Database". In the pop-up window, under "Source", change the selected option from "Database" to "Device" and select the file path for the included database .bak file.
Build ("Ctrl"+"Shift"+"B") and run the application.
This should open your web browser and direct you to the "Welcome" page of the website. Browse the "F.A.Q." or "About Us" sections for information about laboratory testing or the TestChek company.

There are two user roles with different levels of access: Providers, who can order tests, and patients, who can view test results.
A set of login credentials are listed here for each type of role, so as to demonstrate the functionality of the application.

Provider
Username: ljones@test.com
Password: Password123!

Patient
Username: than@test.com
Password: Password123!

Ordering Tests as a provider:
While logged in as the provider, click "Physician Links", then "Order Tests", to be taken to the menu that displays information about registered patients and test-menu options.
You may select and click "Order" to add it to the pending list". Repeat this step for all tests you wish to order. All ordered tests will appear in the pending list to the right.
You may remove any unwanted tests by selecting the test and clicking the "Delete" button. When all desired tests have been added to the pending list, click "Run Now" to perform the tests.
Click the "View Results" button to be taken to the results page for that specific patient. To get back to the test menu, follow the links from the main navigation bar ("Phyisican Links, then "Order Tests").

Viewing tests as a patient:
While logged in as the patient, click "My Account" from the navigation bar, then "My Results", to view the completed tests for that account.
Additionaly, you may create your own account through the "Register" link on the navigation bar. Once created, you may access the "My Account" section, though results will only appear if ordered using the Provider account.

# Purpose
As a medical laboratory scientist, I'm familiar with the issues patients and medical providers face when trying to get test results.
This application is an attempt to solve this issue while also demonstrating a basic understanding of the fundamentals of web development using Asp.net MVC and Web API, C#, HTML, CSS, and Javascript.

# Contributors
A combination of the Bootstrap and Asp.net MVC/Web API frameworks, along with a navigation bar template from www.bootswatch.com provided the structure of this application, upon which I have added my own code.

# License
I claim no license over the code contained within the “TestChek” project files.
