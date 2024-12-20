# Pokemon-Like 🦖

<a name="readme-top"></a>

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

  <p align="right">(<a href="#readme-top"><strong>Back to top</strong></a>)</p>

## Architecture and model

The project uses the MVVM (Model-View-ViewModel) pattern to ensure a clear separation of responsibilities.

***Model*** : Contains data classes and manages business logic.

***View*** : Represents the user interface (XAML).

***ViewModel*** : Links the model to the view.

<p align="right">(<a href="#readme-top"><strong>Back to top</strong></a>)</p>

## Database model

The provided model must be respected without modification. Example tables:

***Users*** : Manages users.

***Monsters*** : Manages monsters.

***Spells*** : Manages spells.

***CombatLogs*** : Stores combat logs (optional).

<p align="right">(<a href="#readme-top"><strong>Back to top</strong></a>)</p>

## Project initialization


> [!IMPORTANT]
> To get started with this project, you'll need :

- [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) installed on your local machine.

- [Visual Studio](https://visualstudio.microsoft.com/fr/) with WPF and Entity Framework extensions enabled.

- [Git](https://git-scm.com/downloads) for version control and collaboration.

  <p align="right">(<a href="#readme-top"><strong>Back to top</strong></a>)</p>

## Installation

> [!NOTE]
> Request access to be added as a collaborator

Clone the repository from GitHub:

```bash
     git clone https://github.com/Tokennn/Pokemon.WPF.git
     cd pokemon-like/
````

➡️ Open the project in Visual Studio.

➡️ Configure the database connection URL in the "Settings" tab.

➡️ Initialize the data by following the instructions below.

## Initialize the data

**Thanks to a preconfigured table we can import it into a new database** :

```bash

CREATE TABLE Users (
Id INT PRIMARY KEY IDENTITY,
Username NVARCHAR(50),
PasswordHash NVARCHAR(256)
);
INSERT INTO Users (Username, PasswordHash) VALUES ('admin', 'hashed_password');

...
````

➡️ When you launch the game, you just need to click on the button (white square) to access your database connection : 

<p align="center">
  <img src="pokemon-like/images/img.png" alt="Battle Simulation">
</p>

➡️ Then once you get there :

<p align="center">
  <img src="pokemon-like/images/imgg.png" alt="Battle Simulation">
</p>

You just have to **write** : 

```bash
Server="nameofyourcomputeur"\SQLEXPRESS;Database=ExerciceMonster;Trusted_Connection=True;TrustServerCertificate=True

````

<p align="right">(<a href="#readme-top"><strong>Back to top</strong></a>)</p>

## Contact 

[@Tokennn] (https://github.com/Tokennn)

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
