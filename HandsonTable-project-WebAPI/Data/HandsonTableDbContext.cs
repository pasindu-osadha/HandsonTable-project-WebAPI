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
                new HandsontableDataModel { id = 10, unit = "J", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 11, unit = "k", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 12, unit = "L", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 13, unit = "M", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 14, unit = "N", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 15, unit = "O", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 16, unit = "P", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 17, unit = "Q", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 18, unit = "R", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 19, unit = "S", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 20, unit = "T", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 21, unit = "AA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 22, unit = "BA", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 23, unit = "CA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 24, unit = "DA", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 25, unit = "EA", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 26, unit = "FA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 27, unit = "GA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 28, unit = "HA", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 29, unit = "IA", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 30, unit = "JA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 31, unit = "kA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 32, unit = "LA", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 33, unit = "MA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 34, unit = "NA", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 35, unit = "OA", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 36, unit = "PA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 37, unit = "QA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 38, unit = "RA", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 39, unit = "SA", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 40, unit = "TA", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 41, unit = "AB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 42, unit = "BB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 43, unit = "CB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 44, unit = "DB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 45, unit = "EB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 46, unit = "FB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 47, unit = "GB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 48, unit = "HB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 49, unit = "IB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 50, unit = "JB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 51, unit = "kB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 52, unit = "LB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 53, unit = "MB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 54, unit = "NB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 55, unit = "OB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 56, unit = "PB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 57, unit = "QB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 58, unit = "RB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 59, unit = "SB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 60, unit = "TB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 61, unit = "AAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 62, unit = "BAB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 63, unit = "CAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 64, unit = "DAB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 65, unit = "EAB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 66, unit = "FAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 67, unit = "GAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 68, unit = "HAB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 69, unit = "IAB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 70, unit = "JAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 71, unit = "kAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 72, unit = "LAB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 73, unit = "MAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 74, unit = "NAB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 75, unit = "OAB", skill1 = 0.5, skill2 = 0.4, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 76, unit = "PAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 77, unit = "QAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 78, unit = "RAB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.3, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 79, unit = "SAB", skill1 = 0.4, skill2 = 0.2, skill3 = 0.4, capacity1 = 0.4, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 },
                new HandsontableDataModel { id = 80, unit = "TAB", skill1 = 0.5, skill2 = 0.2, skill3 = 0.3, capacity1 = 0.2, capacity2 = 0.2, capacity3 = 0.2, capacity4 = 0.2, rate = 0.5 }


                );
        }


    }
}
