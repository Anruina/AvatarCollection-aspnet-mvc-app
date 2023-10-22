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
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "Pilot Season 1 Avatar the Last Airbender"
                        },
                        new Show()
                        {
                            Name = "Book 2 - Earth",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "Follow up season Earth, follows Team Avatar through the Earth Kingdom"
                        },
                        new Show()
                        {
                            Name = "Book 3 - Fire",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
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
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Sokka",
                            Bio = "SwordMaster & Planner ",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Prince Zuko",
                            Bio = "Fire Nation Prince, Firebender",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Aang",
                            Bio = "The last airbender, Airbending Master and the Avatar",
                            ProfilePictureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Toph",
                            Bio = "Greatest Earthbender in the world!",
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
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Bryan Konietzko",
                            Bio = "Co-creator of Avatar the last airbender",
                            ProfilePictureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
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
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
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
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
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
