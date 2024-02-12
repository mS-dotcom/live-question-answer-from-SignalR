using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//DbContext
builder.Services.AddDbContext<RingteyimContext>();
//EntityLayer
builder.Services.AddScoped<IUserDal, EfUserDal>();
//Managers
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IAnswerService, AnswerManager>();
builder.Services.AddScoped<IExamService, ExamManager>();
builder.Services.AddScoped<ILessonAndExamService, LessonAndExamManager>();
builder.Services.AddScoped<ILessonService, LessonManager>();
builder.Services.AddScoped<IOptionService, OptionManager>();
builder.Services.AddScoped<IQuestionService, QuestionManager>();
builder.Services.AddScoped<ISessionService, SessionManager>();

// Add services to the container.
builder.Services.AddControllersWithViews();



// Add services to the container.
builder.Services.AddDbContext<RingteyimContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

