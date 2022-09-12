namespace ProjectManagementCMS_Blazor.Data
{
    public class AppDBContext : DbContext
    {
        public DbSet<ProjectTask> ProjectTasks { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ProjectTask[] projectTasksToSeed = new ProjectTask[10];

            for(int i = 1; i < 11; i++)
            {
                projectTasksToSeed[i - 1] = new ProjectTask
                {
                    ProjectTaskId = i,
                    Title = $"Task {i}",
                    Content = $"This is some example content for task {i}"
                };
            }


            modelBuilder.Entity<ProjectTask>().HasData(projectTasksToSeed);

        }

    }
}
