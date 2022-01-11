using Microsoft.EntityFrameworkCore;

namespace MVCSamples.Data
{
    public class MovieDbContext :DbContext
    {
        public MovieDbContext(DbContextOptions<MovieDbContext> options)
            :base(options)
        {

        }

        //DbSEt fehlen ->
    }
}
