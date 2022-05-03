using HandsonTable_project_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HandsonTable_project_WebAPI.Data
{
    public class HandsonTableDbContext : DbContext
    {
        public HandsonTableDbContext(DbContextOptions<HandsonTableDbContext> options) : base(options)
        {
        }

        public DbSet<HandsontableDataModel> HandsontableDataModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HandsontableDataModel>().HasData(
                new HandsontableDataModel { id = 1, unit = "A", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 2, unit = "B", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 3, unit = "C", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 4, unit = "D", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 5, unit = "E", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 6, unit = "F", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 7, unit = "G", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 8, unit = "H", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 9, unit = "I", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 10, unit = "J", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 }
                );
        }


    }
}
