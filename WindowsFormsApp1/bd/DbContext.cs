using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.bd
{ 
    


    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Query> Queries { get; set; }
        public DbSet<QueryResult> QueryResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //выбор базы данных с которой идёт работа
            optionsBuilder.UseSqlite("Data Source=database.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Вызываем метод OnModelCreating
            base.OnModelCreating(modelBuilder);

            // Определяем ключ для User
            modelBuilder.Entity<User>().HasKey(u => u.Id);

            // Определяем первичный ключ Query
            modelBuilder.Entity<Query>().HasKey(q => q.Id);

            // Определяем первичный ключом для QueryResult
            modelBuilder.Entity<QueryResult>().HasKey(qr => qr.Id);

            // Настраиваем связь один-ко-многим между Query и User
            modelBuilder.Entity<Query>()
                .HasOne(q => q.User)
                .WithMany(u => u.Queries)
                .HasForeignKey(q => q.UserId);

            // Настраиваем связь один-ко-многим между QueryResult и Query
            modelBuilder.Entity<QueryResult>()
                .HasOne(qr => qr.Query)
                .WithMany(q => q.QueryResults)
                .HasForeignKey(qr => qr.QueryId);

        }
    }
}
