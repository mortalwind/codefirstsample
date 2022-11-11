using CodeFirstSample.Data;
using CodeFirstSample.Models;

namespace CodeFirstSample.Extensions;

public static class DataSeedExtension
{

    public static ApplicationDbContext Seed(this ApplicationDbContext dbContext)
    {
        dbContext.Entry(new Author()
        {
            ID = 1,
            FullName = "Ferhat KARABULUT"
        });


        dbContext.Entry(new Book()
        {
            ID = 1,
            AuthorId = 1,
            ISBN = "56651561",
            Price = 10.2M,
            PublishYear = 2022,
            Title = "Programming guide",
            CoverPath = ""
        });

        return dbContext;
    }
}
