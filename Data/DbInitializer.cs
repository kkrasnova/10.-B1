using RestApi.Models;
using System;

namespace RestApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Students.Any())
                return;

            var students = new StudentModel[]
            {
                new StudentModel
                {
                    FirstName = "Іван",
                    LastName = "Петренко",
                    Email = "ivan@example.com",
                    DateOfBirth = new DateTime(2000, 1, 1),
                    PhoneNumber = "0991234567"
                },
                new StudentModel
                {
                    FirstName = "Марія",
                    LastName = "Коваленко",
                    Email = "maria@example.com",
                    DateOfBirth = new DateTime(2001, 2, 2),
                    PhoneNumber = "0982345678"
                },
                
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}