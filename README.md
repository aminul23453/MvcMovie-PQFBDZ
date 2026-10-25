# MvcMovie

Student: Islam Md Aminul
Neptun code: PQFBDZ

## About

A movie management application based on the Microsoft Learn
ASP.NET Core MVC tutorial.

## Technologies

- ASP.NET Core MVC / .NET 10
- Entity Framework Core
- SQL Server Express LocalDB
- Razor views and Bootstrap
- Visual Studio Code, Git, and GitHub

## Features

- Create, list, edit, view, and delete movies
- Search by title and filter by genre
- Store movie ratings
- Validate movie information
- Seed an empty database with sample movies

## Run on Windows

Requirements: .NET 10 SDK, Git, and SQL Server Express LocalDB.

Clone the repository and enter its folder:

    git clone https://github.com/aminul23453/MvcMovie-PQFBDZ.git
    cd MvcMovie-PQFBDZ

Install the EF tool if it is not installed:

    dotnet tool install --global dotnet-ef --version "10.0.*"

Restore packages, create the database, and run:

    dotnet restore
    dotnet ef database update
    dotnet run

Open the localhost address printed in the terminal,
then navigate to /Movies.

The application uses the MvcMovie-PQFBDZ LocalDB database.
Sample movies are inserted when the Movie table is empty.

## Examine the Details and Delete methods

Details finds a movie by ID and displays its information.
If the ID or movie is missing, it returns NotFound.

Delete using GET displays a confirmation page.
Opening this page does not delete the movie.

DeleteConfirmed handles the confirmation POST request,
removes the movie, saves the database changes, and returns
to the movie list.

ValidateAntiForgeryToken checks the form's antiforgery token.

## Manual test results

Fill in actual results after performing each test.

| Test | Result |
|---|---|
| Create a valid movie | |
| Edit and save changes | |
| Search by title | |
| Filter by genre | |
| Combine title and genre filters | |
| Save and display ratings | |
| Reject invalid input on Create | |
| Reject invalid input on Edit | |
| Display movie details | |
| Cancel deletion without removing the movie | |
| Confirm deletion of a temporary movie | |
| Nonexistent Details ID returns 404 | |

## Tutorial

https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-10.0