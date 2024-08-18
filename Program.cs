using Fanush.DAL.Interfaces.EmployeeInterface;
using Fanush.DAL.Interfaces;
using Fanush.DAL.Repositories.EmployeeRepositories;
using Fanush.DAL.Repositories;
using Fanush.DAL;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Microsoft.EntityFrameworkCore;
using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
using Fanush.DAL.Repositories.TimeAndAttendanceRepositories;
using Fanush.DAL.Interfaces.RecruitmentInterface;
using Fanush.DAL.Repositories.RecruitmentRepositories;
using Fanush.DAL.Interfaces.PerformenceInterface;
using Fanush.DAL.Repositories.PerformenceManagementRepositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FanushDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
//EmployeeManagement
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeDataImportExportRepository, EmployeeDataImportExportRepository>();
builder.Services.AddScoped<IEmployeeLifecycleRepository, EmployeeLifecycleRepository>();
builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();
//RecruitmentManagement
builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
builder.Services.AddScoped<IInterviewRepository, InterviewRepository>();
builder.Services.AddScoped<IJobPostingRepository, JobPostingRepository>();

//Time an Attendence 
builder.Services.AddScoped<IAbsenceReportRepository, AbsenceReportRepository>();
builder.Services.AddScoped<IClockInOutRepository, ClockInOutRepository>();
builder.Services.AddScoped<ILeaveRepository, LeaveRepository>();
builder.Services.AddScoped<IOvertimeRepository, OvertimeRepository>();
builder.Services.AddScoped<IPayrollIntegrationRepository, PayrollIntegrationRepository>();

//PerformenceManagement
builder.Services.AddScoped<IDevelopmentPlanRepository, DevelopmentPlanRepository>();
builder.Services.AddScoped<IGoalRepository, GoalRepository>();
builder.Services.AddScoped<IPerformanceReportRepository, PerformanceReportRepository>();
builder.Services.AddScoped<IPerformanceReviewRepository, PerformanceReviewRepository>();



builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
   .AddNegotiate();





builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
});

//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
//});

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
app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
//app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());

app.UseAuthorization();



app.MapControllers();

app.Run();

//using Fanush.DAL.Interfaces.EmployeeInterface;
//using Fanush.DAL.Interfaces;
//using Fanush.DAL.Repositories.EmployeeRepositories;
//using Fanush.DAL.Repositories;
//using Fanush.DAL;
//using Microsoft.AspNetCore.Authentication.Negotiate;
//using Microsoft.EntityFrameworkCore;
//using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
//using Fanush.DAL.Repositories.TimeAndAttendanceRepositories;
//using Microsoft.OpenApi.Models;
//using Microsoft.OpenApi.Any;
//using Swashbuckle.AspNetCore.SwaggerGen;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllers()
//    .AddJsonOptions(options =>
//    {
//        // Handle circular references
//        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
//    });

//// Configure Swagger/OpenAPI
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    // Use custom schema ID selector to avoid conflicts
//    c.CustomSchemaIds(type => type.FullName);

//    // Add custom schema filter to handle enums and other types
//    c.SchemaFilter<EnumSchemaFilter>();
//});

//builder.Services.AddDbContext<FanushDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

//builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeDataImportExportRepository, EmployeeDataImportExportRepository>();
//builder.Services.AddScoped<IEmployeeLifecycleRepository, EmployeeLifecycleRepository>();
//builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();

//builder.Services.AddScoped<IAbsenceReportRepository, AbsenceReportRepository>();
//builder.Services.AddScoped<IClockInOutRepository, ClockInOutRepository>();

//builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
//    .AddNegotiate();

//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options =>
//        options.WithOrigins("http://localhost:4200")
//               .AllowAnyHeader()
//               .AllowAnyMethod());
//});

//builder.Services.AddAuthorization(options =>
//{
//    // By default, all incoming requests will be authorized according to the default policy.
//    options.FallbackPolicy = options.DefaultPolicy;
//});

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseCors("AllowOrigin");

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

//// Custom schema filter to handle enums and other types
//public class EnumSchemaFilter : ISchemaFilter
//{
//    public void Apply(OpenApiSchema schema, SchemaFilterContext context)
//    {
//        if (schema.Enum.Count > 0)
//        {
//            schema.Enum.Clear();
//            foreach (var enumValue in Enum.GetValues(context.Type))
//            {
//                schema.Enum.Add(new OpenApiString(enumValue.ToString()));
//            }
//        }
//    }
//}


