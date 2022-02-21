# Emanueli_Monteiro_WEB315_Assignments
Assignments - WEB315

Create a Razor Pages web app
Run the following commands:

dotnet new webapp -o RazorPagesMovie
code -r RazorPagesMovie

Run the following commands:

dotnet dev-certs https --trust

Add a folder named Models.
Add a class to the Models folder named Movie.cs.

Add the following properties to the Movie class:

using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}

Add NuGet packages and EF tools

Run the following .NET CLI commands:

dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer

Scaffold the movie model

Open a command shell to the project directory, which contains the Program.cs, Startup.cs, and .csproj files. Run the following command:

dotnet-aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite

Run the following .NET CLI commands:

dotnet ef migrations add InitialCreate
dotnet ef database update

ViewData and layout

Update the layout

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>@ViewData["Title"] - Movie</title>
  
  Find the following anchor element in the Pages/Shared/_Layout.cshtml file.
  
  <a class="navbar-brand" asp-area="" asp-page="/Index">RazorPagesMovie</a>
  
  Replace the preceding element with the following markup:
  
  <a class="navbar-brand" asp-page="/Movies/Index">RpMovie</a>
