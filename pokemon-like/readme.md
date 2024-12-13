README - Pokemon-Like en C# avec WPF

Description du projet

Ce projet consiste à développer un jeu de type Pokemon-Like en utilisant le framework Windows Presentation Foundation (WPF) en C#. Le jeu permet de gérer des monstres et des sorts, de se connecter via une interface utilisateur ergonomique et de simuler des combats au tour par tour. Les données du jeu sont gérées via une base de données SQL Server Express.

Fonctionnalités principales

Écran de connexion (Login)

Permet aux utilisateurs de se connecter avec un nom d'utilisateur et un mot de passe.

Les mots de passe sont hachés (BASE).

Les informations sont validées et stockées dans la base de données.

Onglet "Settings"

Configuration de la connexion à la base de données avec une URL personnalisable.

Initialisation des données de base (monstres, sorts, utilisateurs, etc.).

Fenêtre de gestion des monstres

Affiche tous les monstres disponibles.

Permet de sélectionner un monstre pour jouer.

Détaille les informations du monstre sélectionné (Nom, HP, spells associés, etc.).

Onglet des spells

Liste tous les sorts du jeu.

Détaille chaque sort (Nom, dégâts, description).

Inclut un système de tri des sorts par monstre.

Onglet de combat

Simule un combat entre un monstre joueur et un monstre ennemi.

Inclut :

L’utilisation des spells pour infliger des dégâts.

Une barre de points de vie visible pour chaque monstre.

La génération d'un nouveau monstre ennemi avec des statistiques améliorées.

Un bouton pour relancer un combat.

Un système de score à chaque monstre vaincu.

Technologies et outils utilisés

Langage : C#

Framework : Windows Presentation Foundation (WPF)

Base de données : SQL Server Express

ORM : Entity Framework

Contrôle de version : Git

Architecture et modèle

Architecture

Le projet utilise le modèle MVVM (Model-View-ViewModel) pour garantir une séparation claire des responsabilités.

Model : Contient les classes de données et gère la logique métier.

View : Représente l’interface utilisateur (XAML).

ViewModel : Fait le lien entre le modèle et la vue.

Modèle de base de données

Le modèle fourni doit être respecté sans modification. Exemple de tables :

Users : Gère les utilisateurs.

Monsters : Gère les monstres.

Spells : Gère les sorts.

CombatLogs : Stocke les journaux de combats (optionnel).

Initialisation du projet

Prérequis

SQL Server Express installé.

Visual Studio avec les extensions WPF et Entity Framework activées.

Accès à Git.

Installation

Clonez le dépôt depuis GitHub :

git clone https://github.com/votre-utilisateur/pokemon-like-wpf.git

Ouvrez le projet dans Visual Studio.

Configurez l'URL de connexion à la base de données dans l'onglet "Settings".

Initialisez les données en suivant les instructions ci-dessous.

Initialisation des données

Les scripts d’initialisation par défaut (SQL) sont fournis dans le dossier Database du projet.

Exécutez le script dans votre serveur SQL Express pour créer et remplir les tables de base :

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

Renseignez les informations de connexion à la base de données dans l'onglet "Settings".

Connectez-vous avec un compte utilisateur existant.

Naviguez entre les différentes fenêtres pour gérer vos monstres, consulter les sorts, ou engager un combat.

Packages utilisés

Entity Framework : Gère les opérations sur la base de données.

Newtonsoft.Json : (Optionnel) Pour gérer les données JSON si besoin.

CommunityToolkit.Mvvm : Simplifie le développement MVVM.