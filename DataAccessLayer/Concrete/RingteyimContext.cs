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


            string connectionString = "";

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

