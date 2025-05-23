using Microsoft.EntityFrameworkCore;
using StudenApi.Data;
using StudenApi.Filters;
using Student.Application.Implementations;
using Student.Application.Mapping;
using Students.Application.Interfaces;
using Students.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<StudentDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IStudentRepository, StudentRespository>();
builder.Services.AddScoped<IStudentService, StudentService>();

builder.Services.AddAutoMapper(typeof(MappingProfile));

builder.Services.AddControllers(options =>
{
    options.Filters.Add<ValidateModelAttribute>();
});



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
