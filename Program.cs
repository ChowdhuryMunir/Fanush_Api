using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.DAL.Interfaces;
using Fanush.DAL.Repositories.EmployeeRepositories;
using Fanush.DAL.Repositories;
using Fanush.DAL;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FanushDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeDataImportExportRepository, EmployeeDataImportExportRepository>();
builder.Services.AddScoped<IEmployeeLifecycleRepository, EmployeeLifecycleRepository>();
builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();

builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();





builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:49410").AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddAuthorization(options =>
{
    // By default, all incoming requests will be authorized according to the default policy.
    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options => options.WithOrigins("http://localhost:49410").AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();



app.MapControllers();

app.Run();