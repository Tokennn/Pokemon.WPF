README - Pokemon-Like en C# avec WPF

Description du projet

Ce projet consiste � d�velopper un jeu de type Pokemon-Like en utilisant le framework Windows Presentation Foundation (WPF) en C#. Le jeu permet de g�rer des monstres et des sorts, de se connecter via une interface utilisateur ergonomique et de simuler des combats au tour par tour. Les donn�es du jeu sont g�r�es via une base de donn�es SQL Server Express.

Fonctionnalit�s principales

�cran de connexion (Login)

Permet aux utilisateurs de se connecter avec un nom d'utilisateur et un mot de passe.

Les mots de passe sont hach�s (BASE).

Les informations sont valid�es et stock�es dans la base de donn�es.

Onglet "Settings"

Configuration de la connexion � la base de donn�es avec une URL personnalisable.

Initialisation des donn�es de base (monstres, sorts, utilisateurs, etc.).

Fen�tre de gestion des monstres

Affiche tous les monstres disponibles.

Permet de s�lectionner un monstre pour jouer.

D�taille les informations du monstre s�lectionn� (Nom, HP, spells associ�s, etc.).

Onglet des spells

Liste tous les sorts du jeu.

D�taille chaque sort (Nom, d�g�ts, description).

Inclut un syst�me de tri des sorts par monstre.

Onglet de combat

Simule un combat entre un monstre joueur et un monstre ennemi.

Inclut :

L�utilisation des spells pour infliger des d�g�ts.

Une barre de points de vie visible pour chaque monstre.

La g�n�ration d'un nouveau monstre ennemi avec des statistiques am�lior�es.

Un bouton pour relancer un combat.

Un syst�me de score � chaque monstre vaincu.

Technologies et outils utilis�s

Langage : C#

Framework : Windows Presentation Foundation (WPF)

Base de donn�es : SQL Server Express

ORM : Entity Framework

Contr�le de version : Git

Architecture et mod�le

Architecture

Le projet utilise le mod�le MVVM (Model-View-ViewModel) pour garantir une s�paration claire des responsabilit�s.

Model : Contient les classes de donn�es et g�re la logique m�tier.

View : Repr�sente l�interface utilisateur (XAML).

ViewModel : Fait le lien entre le mod�le et la vue.

Mod�le de base de donn�es

Le mod�le fourni doit �tre respect� sans modification. Exemple de tables :

Users : G�re les utilisateurs.

Monsters : G�re les monstres.

Spells : G�re les sorts.

CombatLogs : Stocke les journaux de combats (optionnel).

Initialisation du projet

Pr�requis

SQL Server Express install�.

Visual Studio avec les extensions WPF et Entity Framework activ�es.

Acc�s � Git.

Installation

Clonez le d�p�t depuis GitHub :

git clone https://github.com/votre-utilisateur/pokemon-like-wpf.git

Ouvrez le projet dans Visual Studio.

Configurez l'URL de connexion � la base de donn�es dans l'onglet "Settings".

Initialisez les donn�es en suivant les instructions ci-dessous.

Initialisation des donn�es

Les scripts d�initialisation par d�faut (SQL) sont fournis dans le dossier Database du projet.

Ex�cutez le script dans votre serveur SQL Express pour cr�er et remplir les tables de base :

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

Fonctionnement

Lancez l'application depuis Visual Studio.

Renseignez les informations de connexion � la base de donn�es dans l'onglet "Settings".

Connectez-vous avec un compte utilisateur existant.

Naviguez entre les diff�rentes fen�tres pour g�rer vos monstres, consulter les sorts, ou engager un combat.

Packages utilis�s

Entity Framework : G�re les op�rations sur la base de donn�es.

Newtonsoft.Json : (Optionnel) Pour g�rer les donn�es JSON si besoin.

CommunityToolkit.Mvvm : Simplifie le d�veloppement MVVM.