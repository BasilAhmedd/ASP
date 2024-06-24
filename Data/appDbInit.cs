using WebApplication1.Models;
using WebApplication1.Data;

namespace firstone.Data
{
    public class AppDbinit
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                if (!context.cinemas.Any())
                {
                    context.cinemas.AddRange(new List<cinema>()
                    {
                        new cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://dotnetthow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This cinema is the top"
                        },
                         new cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://dotnetthow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This cinema is the top"
                        },
                          new cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://dotnetthow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This cinema is the top"
                        },
                           new cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://dotnetthow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This cinema is the top"
                        },
                            new cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://dotnetthow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This cinema is the top"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.actors.Any())
                {
                    context.actors.AddRange(new List<actor>()
                    {
                        new actor()
                        {
                            FullName = "Actor 1",
                            ProfilePicUrl = "https://dotnetthow.net/images/actors/actors-1.jpeg",
                            Bio = "This is the bio of the first actor"
                        },
                        new actor()
                        {
                            FullName = "Actor 2",
                            ProfilePicUrl = "https://dotnetthow.net/images/actors/actors-2.jpeg",
                            Bio = "This is the bio of the sec actor"
                        },
                        new actor()
                        {
                            FullName = "Actor 3",
                            ProfilePicUrl = "https://dotnetthow.net/images/actors/actors-3.jpeg",
                            Bio = "This is the bio of the third actor"
                        },
                         new actor()
                        {
                            FullName = "Actor 4",
                            ProfilePicUrl = "https://dotnetthow.net/images/actors/actors-4.jpeg",
                            Bio = "This is the bio of the fourth actor"
                        },
                       new actor()
                        {
                            FullName = "Actor 5",
                            ProfilePicUrl = "https://dotnetthow.net/images/actors/actors-5.jpeg",
                            Bio = "This is the bio of the fifth actor"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.producers.Any())
                {
                    context.producers.AddRange(new List<producers>()
                    {
                        new producers()
                        {
                            FullName = "Producer 1",
                            ProfilePicUrl = "https://dotnetthow.net/images/producers/producers-1.jpeg",
                            Bio = "This is the bio of the first producer"
                        },
                         new producers()
                        {
                            FullName = "Producer 2",
                            ProfilePicUrl = "https://dotnetthow.net/images/producers/producers-2.jpeg",
                            Bio = "This is the bio of the Sec producer"
                        },
                         new producers()
                        {
                            FullName = "Producer 3",
                            ProfilePicUrl = "https://dotnetthow.net/images/producers/producers-3.jpeg",
                            Bio = "This is the bio of the third producer"
                        },
                        new producers()
                        {
                            FullName = "Producer 4",
                            ProfilePicUrl = "https://dotnetthow.net/images/producers/producers-4.jpeg",
                            Bio = "This is the bio of the fourth producer"
                        },
                       new producers()
                        {
                            FullName = "Producer 5",
                            ProfilePicUrl = "https://dotnetthow.net/images/producers/producers-5.jpeg",
                            Bio = "This is the bio of the fifth producer"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.movies.Any())
                {
                    context.movies.AddRange(new List<movie>()
                    {
                        new movie()
                         {
        Name = "Life",
        Description = "This is the Life movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(10),
        CinemaId = 3,
        ProducerId = 3,
        MoveiCategory = MoviesCategory.Documentary
    },

    new movie()
    {
        Name = "The Shawshank Redemption",
        Description = "This is the Shawshank Redemption description",
        Price = 29.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
        StartDate = DateTime.Now,
        EndDate = DateTime.Now.AddDays(3),
        CinemaId = 1,
        ProducerId = 1,
        MoveiCategory = MoviesCategory.Action
    },
    new movie()
    {
        Name = "Ghost",
        Description = "This is the Ghost movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
        StartDate = DateTime.Now,
        EndDate = DateTime.Now.AddDays(7),
        CinemaId = 4,
        ProducerId = 4,
        MoveiCategory = MoviesCategory.Horror
    },
    new movie()
    {
        Name = "Race",
        Description = "This is the Race movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(-5),
        CinemaId = 1,
        ProducerId = 2,
        MoveiCategory = MoviesCategory.Documentary
    },
    new movie()
    {
        Name = "Scoob",
        Description = "This is the Scoob movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
        StartDate = DateTime.Now.AddDays(-10),
        EndDate = DateTime.Now.AddDays(-2),
        CinemaId = 1,
        ProducerId = 3,
        MoveiCategory = MoviesCategory.Cartoon
    },
    new movie()
    {
        Name = "Cold Soles",
        Description = "This is the Cold Soles movie description",
        Price = 39.50,
        ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
        StartDate = DateTime.Now.AddDays(3),
        EndDate = DateTime.Now.AddDays(20),
        CinemaId = 1,
        ProducerId = 5,
        MoveiCategory = MoviesCategory.Drama
    }
                    });
                }
                context.SaveChanges();
                if (!context.movie_Actors.Any())
                {
                    context.movie_Actors.AddRange(new List<Movie_Actor>()
                        {
                        new Movie_Actor()
    {
        ActorId = 1,
        MovieId = 1
    },
    new Movie_Actor()
    {
        ActorId = 3,
        MovieId = 1
    },
    new Movie_Actor()
    {
        ActorId = 1,
        MovieId = 2
                        },
     new Movie_Actor()
    {
        ActorId = 4,
         MovieId = 2
    },

    new Movie_Actor()
    {
        ActorId = 1,
        MovieId = 3
    },
    new Movie_Actor()
    {
        ActorId = 2,
        MovieId = 3
    },
    new Movie_Actor()
    {
        ActorId = 5,
        MovieId = 3
    },


    new Movie_Actor()
    {
        ActorId = 2,
        MovieId = 4
    },
    new Movie_Actor()
    {
        ActorId = 3,
        MovieId = 4
    },
    new Movie_Actor()
    {
        ActorId = 4,
        MovieId = 4
    },


    new Movie_Actor()
    {
        ActorId = 2,
        MovieId = 5
    },
    new Movie_Actor()
    {
        ActorId = 3,
        MovieId = 5
    },
    new Movie_Actor()
    {
        ActorId = 4,
        MovieId = 5
    },
    new Movie_Actor()
    {
        ActorId = 5,
        MovieId = 5
    },


    new Movie_Actor()
    {
        ActorId = 3,
        MovieId = 6
    },
    new Movie_Actor()
    {
        ActorId = 4,
        MovieId = 6
    },
    new Movie_Actor()
    {
        ActorId = 5,
        MovieId = 6
    },
                    });
                    context.SaveChanges();
                }
            }
        }

    }
}
