using Microsoft.EntityFrameworkCore;

namespace WorkoutApplication.Model
{
    public class DataContext : DbContext
    {
        public  DataContext(DbContextOptions<DataContext> options) : base(options) 
        { 
        }
        public DbSet<Exercise>? ExerciseList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id = 1,
                    Title = "Kätekõverdused jala tõstega",
                    Description = "Tabalised kätekõverdused korda mööda jalga tõstes",
                    Intensity = Exercise.ExerciseIntensity.Normal,
                    RecommendedDurationInSeconds = 40,
                    RecommendedTimeInSecondsBeforeExercise = 10,
                    RecommendedTimeInSecondsAfterExercise = 10,
                },
                new Exercise
                {

                });
        }

    }
}
