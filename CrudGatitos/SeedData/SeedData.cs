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
                        Colores = "Naranja",
                        Imagen = "https://img.europapress.es/fotoweb/fotonoticia_20141119172350_420.jpg"
                    },
                    new Gatito
                    {
                        Nombre = "Micaela",
                        Raza = "Siberiano",
                        Peso = 11,
                        Edad = 6,
                        Colores = "Blanco",
                        Imagen = "https://www.purina-latam.com/sites/g/files/auxxlc391/files/styles/social_share_large/public/Que_debes_saber_antes_de_adoptar_un_gatito.jpg?itok=guFplHEU"
                    },
                    new Gatito
                    {
                        Nombre = "Gonzalo",
                        Raza = "Bengala",
                        Peso = 12,
                        Edad = 2,
                        Colores = "Negro y Gris",
                        Imagen = "https://www.purina-latam.com/sites/g/files/auxxlc391/files/styles/social_share_large/public/Que_debes_saber_antes_de_adoptar_un_gatito.jpg?itok=guFplHEU"
                    },
                    new Gatito
                    {
                        Nombre = "Michigan",
                        Raza = "Munchkin",
                        Peso = 9,
                        Edad = 6,
                        Colores = "Negro y Naranja",
                        Imagen = "https://t1.ea.ltmcdn.com/es/posts/7/4/3/como_ayudar_a_un_gatito_a_defecar_20347_600.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}