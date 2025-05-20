using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.DataModels;
using StudentAdminPortal.Profiles;
using StudentAdminPortal.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Fix ambiguous call by wrapping assembly in an array
//builder.Services.AddAutoMapper(new[] { typeof(AutoMapperProfile).Assembly });

builder.Services.AddAutoMapper(typeof(Program).Assembly);

builder.Services.AddDbContext<StudentAdminContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("StudentAdminPortalDb")));

builder.Services.AddScoped<IStudentRepository, SqlStudentRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
