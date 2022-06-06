using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CrudGatitos.Data;
using System;
using System.Linq;
using CrudGatitos.Models;

namespace MvcMovie.Models

{

    public static class SeedData

    {

        public static void Initialize(IServiceProvider serviceProvider)

        {

            using (var context = new ApplicationDbContext(

                serviceProvider.GetRequiredService<

                    DbContextOptions<ApplicationDbContext>>()))

            {

                // Look for any movies.

                if (context.Gatito.Any())

                {

                    return;   // DB has been seeded

                }


                context.Gatito.AddRange(
                    new Gatito
                    {
                        Nombre = "Emanuel",
                        Raza = "Siames",
                        Peso = 10,
                        Edad = 4,
                        Colores = "Naranja"
                    },
                    new Gatito
                    {
                        Nombre = "Micaela",
                        Raza = "Siberiano",
                        Peso = 11,
                        Edad = 6,
                        Colores = "Blanco"
                    },
                    new Gatito
                    {
                        Nombre = "Gonzalo",
                        Raza = "Bengala",
                        Peso = 12,
                        Edad = 2,
                        Colores = "Negro y Gris"
                    },
                    new Gatito
                    {
                        Nombre = "Michigan",
                        Raza = "Munchkin",
                        Peso = 9,
                        Edad = 6,
                        Colores = "Negro y Naranja"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}