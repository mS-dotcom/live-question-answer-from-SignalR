using System;
using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccessLayer.Concrete
{
	public class RingteyimContext:DbContext
	{
        private readonly IConfiguration Configuration;
        public RingteyimContext(DbContextOptions<RingteyimContext> options,IConfiguration configuration)
        : base(options)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            string connectionString = "Server=37.148.213.153;Database=ringle;User Id=mseker;Password=1Q2W3e4r5t6y1905!;";

            optionsBuilder.UseSqlServer(connectionString);
        }

        

        public DbSet<Answer> answers { get; set; }
        public DbSet<Exam> exams { get; set; }
        public DbSet<GeneralPoint> generalPoints { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<LessonAndExam> lessonAndExams { get; set; }
        public DbSet<Option> options { get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<Session> sessions { get; set; }
        public DbSet<User> users { get; set; }
    }
}

