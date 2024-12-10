using System;
using System.Linq;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using PokemonLike.Models;
using PokemonLike.Properties;

namespace PokemonLike.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Login> Login { get; set; }

        private string _connectionString;

        public DatabaseContext(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("La cha�ne de connexion ne peut pas �tre vide.", nameof(connectionString));
            }

            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }

    public static class DatabaseService
    {
        private static string _connectionString;
        public static void Initialize(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("La cha�ne de connexion n'est pas d�finie.");
            }

            _connectionString = connectionString;

            using var context = new DatabaseContext(connectionString);
            try
            {
                context.Database.EnsureCreated();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Impossible de se connecter � la base de donn�es.", ex);
            }
        }


        public static void AddUser(string username, string passwordHash)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("La cha�ne de connexion n'a pas �t� initialis�e.");
            }

            using var context = new DatabaseContext(_connectionString);
            context.Login.Add(new Login { Username = username, PasswordHash = passwordHash });
            context.SaveChanges();
        }

        public static Login GetUser(string username)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("La cha�ne de connexion n'a pas �t� initialis�e.");
            }

            using var context = new DatabaseContext(_connectionString);
             return context.Login.FirstOrDefault(u => u.Username == username);
        }

        public static void DeleteUser(string username)
        {
            if (string.IsNullOrEmpty(_connectionString))
            {
                throw new InvalidOperationException("La cha�ne de connexion n'a pas �t� initialis�e.");
            }

            using var context = new DatabaseContext(_connectionString);
            var user = context.Login.FirstOrDefault(u => u.Username == username);
            if (user != null)
            {
                context.Login.Remove(user);
                context.SaveChanges();
            }
        }
    }
}
