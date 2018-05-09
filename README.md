# WTS Shift Calculator
This is Microsoft ASP.NET Core 2.0 app developed using Visual Studio 2017 community editioin and it has 3 main modules.
1. WTS Web API
2. WTS Frontend
3. WTS Unit tests

## WTS Web API
This module expose api/Employee web api endpoint with Employee ID, Full Name and number of total hours of employee for each month. This module contains follwing sub modules.
Model - Contains Main models of the app.
Controller - Contains web api controllers Employee.
Service - Contains the app service sit between data layer and controller.
Data - The layer that calls database and add initial values to the database.
DTOS - contains the Data transfer objects that use in the service layer and controller.
Utils - contains utility classes such as shift hours calculaor.

This project use SQLite databse as the database.

## WTS Web app
This is ASP.NET core 2.0 MVC web application that consume WTS Web API to display the data. 
View - About.cshtml 
Model - EmployeeDto annd ShiftDto under DTOs
COntroller - About.cshtml.cs

## WTS Unit test
This project contains unit tests for WTS Web API project.

## How to run the project
1. Run the WTS Web API project and Copy the Base URL (Eg: http://localhost:51350/)
2. Open the appsettings.json file in WTS.Web project
3. Replace the BaseUrl with the above copied URL
4. Run the WTS.WEb project
5. Navigate to "Employee Shift Hours" link from the home page to see the employee details.

## Things to improve/ do:
1. Improve the Web frontend.
2. Add API documentation such as swagger page.
3. Add error handling/ excception handling. 
4. Add logging.
5. improve the code coverage.
6. Integrate code quality tool such as SonarQube.