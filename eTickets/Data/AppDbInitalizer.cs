using AvatarCollections.Data.Enums;
using AvatarCollections.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace AvatarCollections.Data
{
    public class AppDbInitalizer
    {

        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                
                //will be created if not exist
                context.Database.EnsureCreated();

                //basic data will be displayed if database is empty.

                if (!context.Shows.Any())
                {
                    context.Shows.AddRange(new List<Show>()
                    {
                        new Show()
                        {
                            Name = "Book 1 - Water",
                            Logo = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/b875fecc-8841-4c7e-957c-c5f985da8b9e/d6humwi-2412c319-522f-479f-ad19-252fa33a2445.jpg/v1/fill/w_900,h_563,q_75,strp/avatar__the_last_airbener_element_artwork___water_by_thepagal_d6humwi-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9NTYzIiwicGF0aCI6IlwvZlwvYjg3NWZlY2MtODg0MS00YzdlLTk1N2MtYzVmOTg1ZGE4YjllXC9kNmh1bXdpLTI0MTJjMzE5LTUyMmYtNDc5Zi1hZDE5LTI1MmZhMzNhMjQ0NS5qcGciLCJ3aWR0aCI6Ijw9OTAwIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.iMX3iZKDEw9wM7U3sDLCexQgNNcaUYVTKP2rKuHMFLo",
                            Description = "Pilot Season 1 Avatar the Last Airbender"
                        },
                        new Show()
                        {
                            Name = "Book 2 - Earth",
                            Logo = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/b875fecc-8841-4c7e-957c-c5f985da8b9e/d6huo4x-eadfe9e7-25a4-4042-8cca-39325f574e5d.jpg/v1/fill/w_900,h_563,q_75,strp/avatar__the_last_airbener_element_artwork___earth_by_thepagal_d6huo4x-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9NTYzIiwicGF0aCI6IlwvZlwvYjg3NWZlY2MtODg0MS00YzdlLTk1N2MtYzVmOTg1ZGE4YjllXC9kNmh1bzR4LWVhZGZlOWU3LTI1YTQtNDA0Mi04Y2NhLTM5MzI1ZjU3NGU1ZC5qcGciLCJ3aWR0aCI6Ijw9OTAwIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.Sly7Hlf8XS5cIHJjhR_IhYQ8YXfOf5uTDpCcTmkycfk",
                            Description = "Follow up season Earth, follows Team Avatar through the Earth Kingdom"
                        },
                        new Show()
                        {
                            Name = "Book 3 - Fire",
                            Logo = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/b875fecc-8841-4c7e-957c-c5f985da8b9e/d6huoki-5deaffa3-cbaf-4749-a1be-5fd628779677.jpg/v1/fill/w_900,h_563,q_75,strp/avatar__the_last_airbener_element_artwork___fire_by_thepagal_d6huoki-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9NTYzIiwicGF0aCI6IlwvZlwvYjg3NWZlY2MtODg0MS00YzdlLTk1N2MtYzVmOTg1ZGE4YjllXC9kNmh1b2tpLTVkZWFmZmEzLWNiYWYtNDc0OS1hMWJlLTVmZDYyODc3OTY3Ny5qcGciLCJ3aWR0aCI6Ijw9OTAwIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmltYWdlLm9wZXJhdGlvbnMiXX0.3QFWgchHS1ooSerhObb2UnU7dNH2eRfepGDyYOc14U0",
                            Description = "Final season, follows Team Avatars attempt at ending the 100 year war."
                        }
                    });

                    //changes will be saved in db
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Katara",
                            Bio = "Waterbending Master",
                            ProfilePictureUrl = "https://a1cf74336522e87f135f-2f21ace9a6cf0052456644b80fa06d4f.ssl.cf2.rackcdn.com/images/characters/large/2800/Katara.Avatar-The-Last-Airbender.webp"

                        },
                        new Actor()
                        {
                            FullName = "Sokka",
                            Bio = "SwordMaster & Planner ",
                            ProfilePictureUrl = "https://a1cf74336522e87f135f-2f21ace9a6cf0052456644b80fa06d4f.ssl.cf2.rackcdn.com/images/characters/large/2800/Sokka.Avatar-The-Last-Airbender.webp"
                        },
                        new Actor()
                        {
                            FullName = "Prince Zuko",
                            Bio = "Fire Nation Prince, Firebender",
                            ProfilePictureUrl = "https://a1cf74336522e87f135f-2f21ace9a6cf0052456644b80fa06d4f.ssl.cf2.rackcdn.com/images/characters/large/2800/Prince-Zuko.Avatar-The-Last-Airbender.webp"
                        },
                        new Actor()
                        {
                            FullName = "Aang",
                            Bio = "The last airbender, Airbending Master and the Avatar",
                            ProfilePictureUrl = "https://a1cf74336522e87f135f-2f21ace9a6cf0052456644b80fa06d4f.ssl.cf2.rackcdn.com/images/characters/large/2800/Aang.Avatar-The-Last-Airbender.webp"
                        },
                        new Actor()
                        {
                            FullName = "Appa",
                            Bio = "Aang's Animal guide, trusted friend. Appa's an original airbender.",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Michael Dante DiMartino",
                            Bio = "Co-creator of Avatar the last airbender",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/b/bb/MichaelDanteDiMartinoCCJuly09.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Bryan Konietzko",
                            Bio = "Co-creator of Avatar the last airbender",
                            ProfilePictureUrl = "https://upload.wikimedia.org/wikipedia/commons/0/06/BryanKonietzkoCCJuly09.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Collectables
                if (!context.Collectables.Any())
                {
                    context.Collectables.AddRange(new List<Collectable>()
                    {
                        new Collectable()
                        {
                            Name = "Katara Funko Pop",
                            Description = "PVC Figuring of Katara",
                            Price = 39.50,
                            ImageURL = "https://m.media-amazon.com/images/I/31-v-RhA6VL._SX342_SY445_.jpg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            ShowId = 3,
                            ProducerId = 1,
                            Category = Category.Figurine
                        },
                        new Collectable()
                        {
                            Name = "Toph Beifong's Metalbending Academy",
                            Description = "Short comics about Toph forming her own Academy focused on Metalbending.",
                            Price = 29.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51Bfa3K8GoL._SY445_SX342_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            ShowId = 2,
                            ProducerId = 1,
                            Category = Category.Book
                        },
                        new Collectable()
                        {
                            Name = "Smoke and Shadow",
                            Description = "Library Edition that gathers a 3 part comic adventure.",
                            Price = 59.50,
                            ImageURL = "https://m.media-amazon.com/images/I/51J5RJ9ARlL._SY445_SX342_.jpg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            ShowId = 3,
                            ProducerId = 2,
                            Category = Category.Book
                        }
                    });
                    context.SaveChanges();
                }

                
            }
        }


    }
}
