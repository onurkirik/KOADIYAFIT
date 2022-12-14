
using KOADIYAFIT.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace KOADIYAFIT.DAL.Context
{
    public class ProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=KoaDiaFitDB;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=localhost;Database=KoaDiaFitDB;Trusted_Connection=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserMeal> UserMeals { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<MealType> MealTypes { get; set; }
        public DbSet<PersonelNote> PersonelNotes { get; set; }
        public DbSet<MotivationWord> MotivationWords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(x => x.UserMeals).WithOne(y => y.User);

            modelBuilder.Entity<UserMeal>().HasOne(x => x.Food).WithMany(f => f.UserMeals);

            modelBuilder.Entity<Food>().HasMany(x => x.Users).WithMany(y => y.Foods);
            modelBuilder.Entity<Food>().HasOne(x => x.MealType).WithMany().HasForeignKey(x => x.MealTypeId);
            modelBuilder.Entity<User>().HasMany(x => x.PersonalNotes).WithOne(y => y.User);

            modelBuilder.Entity<MealType>().HasData(new MealType
            {
                MealTypeId = 1,
                MealTypeName = "Kahvaltı",
                MealTypeImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\mealtype_1.jpg")
            },
            new MealType
            {
                MealTypeId = 2,
                MealTypeName = "Öğle Yemeği",
                MealTypeImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\mealtype_2.jpg")
            },
            new MealType
            {
                MealTypeId = 3,
                MealTypeName = "Akşam Yemeği",
                MealTypeImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\mealtype_3.jpg")
            });

            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "admin",
                Age = 24,
                Height = 176,
                BMI = 24,
                EMail = "admin@gmail.com",
                DiabetType = "Tip-1",
                MemberType = "Admin",
                Password = "pass",
                Weight = 83,
                WeightStatus = "Fazla Kilolu",
                PersonalNotes = null,
                PersonaNotId = null
            },
            new User
            {
                Id = 2,
                UserName = "user",
                Age = 24,
                Height = 176,
                BMI = 24,
                EMail = "user@gmail.com",
                DiabetType = "Tip-1",
                MemberType = null,
                Password = "pass",
                Weight = 83,
                WeightStatus = "Fazla Kilolu",
                PersonalNotes = null,
                PersonaNotId = null
            });

            modelBuilder.Entity<Food>().HasData(new Food
            {
                FoodId = 1,
                FoodName = "Domates",
                PortionSize = "100 gr",
                Calorie = 25,
                FoodImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\food_1.jpg"),
                MealTypeId = 1
            },
            new Food
            {
                FoodId = 2,
                FoodName = "Beyaz Peynir",
                PortionSize = "100 gr",
                Calorie = 50,
                FoodImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\food_2.jpg"),
                MealTypeId = 1
            }, new Food
            {
                FoodId = 3,
                FoodName = "Balık",
                PortionSize = "1 Adet",
                Calorie = 70,
                FoodImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\food_3.jpg"),
                MealTypeId = 2
            }, new Food
            {
                FoodId = 4,
                FoodName = "Salata",
                PortionSize = "100 gr",
                Calorie = 30,
                FoodImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\food_4.jpeg"),
                MealTypeId = 2
            }, new Food
            {
                FoodId = 5,
                FoodName = "Barbunya",
                PortionSize = "100 gr",
                Calorie = 100,
                FoodImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\food_5.jpeg"),
                MealTypeId = 3
            },
            new Food
            {
                FoodId = 6,
                FoodName = "Makarna",
                PortionSize = "100 gr",
                Calorie = 70,
                FoodImage = File.ReadAllBytes(AppDomain.CurrentDomain.BaseDirectory + "\\..\\..\\..\\..\\Resources\\food_6.jpeg"),
                MealTypeId = 3
            });

            modelBuilder.Entity<MotivationWord>().HasData(
            new MotivationWord
            {
                Id = 1,
                Word = "Başarının yolu inanmaktan geçer."
            },
            new MotivationWord
            {
                Id = 2,
                Word = "Başarı: \"Baş\" olmak için \"arı\" gibi çalışmak gerekir."
            },
            new MotivationWord
            {
                Id = 3,
                Word = "Başarının yolu inanmaktan geçer."
            },
            new MotivationWord
            {
                Id = 4,
                Word = "Sana bunun kolay olacağını söylemiyorum. Buna değeceğini söylüyorum."
            },
            new MotivationWord
            {
                Id = 5,
                Word = "Eğer ağaca çıkmak istiyorsanız, yıldızlara çıkmaya niyet edin başarırsınız."
            },
            new MotivationWord
            {
                Id = 6,
                Word = "Motivasyon “başlamanı” sağlar. Devam etmen için “alışkanlık” olmalı."
            },
            new MotivationWord
            {
                Id = 7,
                Word = "Vazgeçmek üzereysen neden başladığını düşün."
            });

            base.OnModelCreating(modelBuilder);

        }
    }
}