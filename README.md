# Pokemon-Like 


<p align="center">
  <img src="pokemon-like/hello.gif" alt="Battle Simulation">
</p>


## Project Overview

This project consists of developing a Pokemon-Like type game using the Windows Presentation Foundation (WPF) framework in C#. The game allows you to manage monsters and spells, connect via an ergonomic user interface and simulate turn-based battles. The game data is managed via a SQL Server Express database.

## Technologies and tools used

For this project we worked on these technologies
 
* [![C#][C#]][C#-url]
* [![WPF][WPF]][WPF-url]
* [![SQL Server Express][SQL Server Express]][SQL Server Express-url]
* [![Git][Git]][Git-url]
* [![ORM][ORM]][ORM-url]

## Architecture and model

Architecture

The project uses the MVVM (Model-View-ViewModel) pattern to ensure a clear separation of responsibilities.

Model: Contains data classes and manages business logic.

View: Represents the user interface (XAML).

ViewModel: Links the model to the view.

## Database model

The provided model must be respected without modification. Example tables:

Users: Manages users.

Monsters: Manages monsters.

Spells: Manages spells.

CombatLogs: Stores combat logs (optional).

## Project initialization

Prerequisites

SQL Server Express installed.

Visual Studio with WPF and Entity Framework extensions enabled.

Access to Git.

## Installation

Clone the repository from GitHub:

git clone https://github.com/your-user/pokemon-like-wpf.git

Open the project in Visual Studio.

Configure the database connection URL in the "Settings" tab.

Initialize the data by following the instructions below.

## Initialize the data

The default initialization scripts (SQL) are provided in the Database folder of the project.

Run the script in your SQL Express server to create and populate the base tables:

CREATE TABLE Users (
Id INT PRIMARY KEY IDENTITY,
Username NVARCHAR(50),
PasswordHash NVARCHAR(256)
);
INSERT INTO Users (Username, PasswordHash) VALUES ('admin', 'hashed_password');

CREATE TABLE Monsters (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50),
HP INT
);

CREATE TABLE Spells (
Id INT PRIMARY KEY IDENTITY,
Name NVARCHAR(50),
Damage INT,
MonsterId INT FOREIGN KEY REFERENCES Monsters(Id)
);

How it works

Launch the application from Visual Studio.

Enter the database connection information in the "Settings" tab.

Log in with an existing user account.

Navigate between the different windows to manage your monsters, view spells, or engage in combat.

Packages used

Entity Framework: Manages database operations.

Newtonsoft.Json : (Optional) To handle JSON data if needed.

CommunityToolkit.Mvvm : Simplifies MVVM development.


<!-- (Markdown img link) : -->
 
[C#]: https://img.shields.io/badge/C%23-grey?style=for-the-badge&logo=c-sharp
[C#-url]: https://www.w3schools.com/cs/index.php#:~:text=C%23%20(C-Sharp)%20is,apps%2C%20games%20and%20much%20more.
 
[WPF]: https://img.shields.io/badge/WPF-grey?style=for-the-badge&logo=microsoft
[WPF-url]: https://learn.microsoft.com/en-us/dotnet/desktop/wpf/overview/?view=netdesktop-9.0
 
[SQL Server Express]: https://img.shields.io/badge/SQL%20Server%20Express-grey?style=for-the-badge&logo=microsoft-sql-server&logoColor=white
[SQL Server Express-url]: https://www.microsoft.com/fr-fr/download/details.aspx?id=101064

[Git]: https://img.shields.io/badge/Git-grey?style=for-the-badge&logo=git
[Git-url]: https://git-scm.com

[ORM]: https://img.shields.io/badge/ORM-grey?style=for-the-badge&logo=database
[ORM-url]: https://learn.microsoft.com/fr-fr/ef/
 
 
[product-screenshot]: images/screenshot.png
