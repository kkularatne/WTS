# WTS Shift Calculator
This is Microsoft ASP.NET Core 2.0 app that has 3 main modules.
1. WTS Web API
2. WTS Frontend
3. WTS Unit tests

## WTS Web API
This module expose api/Employee web api endpoint with Employee ID, Full Name and number of total hours of employee for each month. This module as follwing sub modules.
Model - Contains Main models of the app
Controller - Contains web api controllers
Service - Contains the app service sit between data layer and controller.
Data - The layer that calls database and add initial values to the database.
DTOS - contains the Data transfer objects that use in the service layer and controller.
Utils - contains utility classes such as shift hours calculaor.

This project use SQLite databse as the database.

## WTS Web app
This is ASP.NET core 2.0 MVC web application that consume WTS Web API to display the data. Navigate to http://localhost:51435/About or click on the Employee Shift Hours link from the home page to see the employee details.

## WTS Unit test
This project contains unit tests for WTS Web API project.

## Things to do:
Improve the Web front end.
Add API documentation such as swagger page.
Add error handling/ excception handling. 
Add logging. 