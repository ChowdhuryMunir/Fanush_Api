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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Fanush.DAL.JWTService;
using Fanush.Entities.Administrator;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using Fanush.DAL.Interfaces.PayrollInterface;
using Fanush.Repositories.PayrollManagement;
using System.IO;
using FastReport.Data;

var directoryPaths = new[]
{
    Path.Combine(Directory.GetCurrentDirectory(), "Images"),
    Path.Combine(Directory.GetCurrentDirectory(), "Files")
};

// Check if directories exist, if not, create them
foreach (var directoryPath in directoryPaths)
{
    if (!Directory.Exists(directoryPath))
    {
        Directory.CreateDirectory(directoryPath);
    }
}

var builder = WebApplication.CreateBuilder(args);

// Configure logging
builder.Logging.AddConsole();

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<FanushDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var usrIden = builder.Services.AddIdentityCore<AppUser>();
usrIden = new IdentityBuilder(usrIden.UserType, usrIden.Services);
usrIden.AddEntityFrameworkStores<FanushDbContext>();
usrIden.AddSignInManager<SignInManager<AppUser>>();

builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
// Employee Management
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeDataImportExportRepository, EmployeeDataImportExportRepository>();
builder.Services.AddScoped<IEmployeeLifecycleRepository, EmployeeLifecycleRepository>();
builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();
// Recruitment Management
builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
builder.Services.AddScoped<IInterviewRepository, InterviewRepository>();
builder.Services.AddScoped<IJobPostingRepository, JobPostingRepository>();
// Time and Attendance
builder.Services.AddScoped<IAbsenceReportRepository, AbsenceReportRepository>();
builder.Services.AddScoped<IClockInOutRepository, ClockInOutRepository>();
builder.Services.AddScoped<ILeaveRepository, LeaveRepository>();
builder.Services.AddScoped<IOvertimeRepository, OvertimeRepository>();
builder.Services.AddScoped<IPayrollIntegrationRepository, PayrollIntegrationRepository>();
// Performance Management
builder.Services.AddScoped<IDevelopmentPlanRepository, DevelopmentPlanRepository>();
builder.Services.AddScoped<IGoalRepository, GoalRepository>();
builder.Services.AddScoped<IPerformanceReportRepository, PerformanceReportRepository>();
builder.Services.AddScoped<IPerformanceReviewRepository, PerformanceReviewRepository>();
// Payroll Management
builder.Services.AddScoped<IPayrollCalculationRepository, PayrollCalculationRepository>();

builder.Services.AddScoped<ITokenService, TokenService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder =>
        {
            builder.WithOrigins("http://localhost:4200", "http://localhost:3000")
                   .AllowAnyMethod()
                   .AllowAnyHeader()
                   .SetIsOriginAllowedToAllowWildcardSubdomains();
        });
});

var config = builder.Configuration;
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(o =>
    {
        o.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
            ValidIssuer = config["Token:Issuer"],
            ValidateIssuer = true,
            ValidateAudience = false
        };
    });

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "User", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme.",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer"
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            }, new string[] {}
        }
    });
});

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});
//Fast report
FastReport.Utils.RegisteredObjects.AddConnection(typeof(MsSqlDataConnection));
builder.Services.AddFastReport();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowOrigin");
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
    RequestPath = "/Images"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Files")),
    RequestPath = "/Files"
});

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
//using Fanush.DAL.Interfaces.RecruitmentInterface;
//using Fanush.DAL.Repositories.RecruitmentRepositories;
//using Fanush.DAL.Interfaces.PerformenceInterface;
//using Fanush.DAL.Repositories.PerformenceManagementRepositories;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.OpenApi.Models;

//using Microsoft.IdentityModel.Tokens;
//using System.Text;
//using Fanush.DAL.JWTService;
//using Fanush.Entities.Administrator;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.FileProviders;
//using Fanush.DAL.Interfaces.PayrollInterface;
//using Fanush.Repositories.PayrollManagement;
//using System.IO;

//var directoryPaths = new[]
//{
//    Path.Combine(Directory.GetCurrentDirectory(), "Images"),
//    Path.Combine(Directory.GetCurrentDirectory(), "Files")
//};

//// Check if directories exist, if not, create them
//foreach (var directoryPath in directoryPaths)
//{
//    if (!Directory.Exists(directoryPath))
//    {
//        Directory.CreateDirectory(directoryPath);
//    }
//}

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<FanushDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//var usrIden = builder.Services.AddIdentityCore<AppUser>();
//usrIden = new IdentityBuilder(usrIden.UserType, usrIden.Services);
//usrIden.AddEntityFrameworkStores<FanushDbContext>();
//usrIden.AddSignInManager<SignInManager<AppUser>>();

//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
////EmployeeManagement
//builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeDataImportExportRepository, EmployeeDataImportExportRepository>();
//builder.Services.AddScoped<IEmployeeLifecycleRepository, EmployeeLifecycleRepository>();
//builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();
////RecruitmentManagement
//builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
//builder.Services.AddScoped<IInterviewRepository, InterviewRepository>();
//builder.Services.AddScoped<IJobPostingRepository, JobPostingRepository>();

////Time an Attendence 
//builder.Services.AddScoped<IAbsenceReportRepository, AbsenceReportRepository>();
//builder.Services.AddScoped<IClockInOutRepository, ClockInOutRepository>();
//builder.Services.AddScoped<ILeaveRepository, LeaveRepository>();
//builder.Services.AddScoped<IOvertimeRepository, OvertimeRepository>();
//builder.Services.AddScoped<IPayrollIntegrationRepository, PayrollIntegrationRepository>();

////PerformenceManagement
//builder.Services.AddScoped<IDevelopmentPlanRepository, DevelopmentPlanRepository>();
//builder.Services.AddScoped<IGoalRepository, GoalRepository>();
//builder.Services.AddScoped<IPerformanceReportRepository, PerformanceReportRepository>();
//builder.Services.AddScoped<IPerformanceReviewRepository, PerformanceReviewRepository>();
////PayrollManagement 
//builder.Services.AddScoped<IPayrollCalculationRepository, PayrollCalculationRepository>();

//builder.Services.AddScoped<ITokenService, TokenService>();


//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowOrigin",
//        builder =>
//        {
//            builder.WithOrigins("http://localhost:4200", "http://localhost:3000")
//            .AllowAnyMethod()
//            .AllowAnyHeader()
//            .SetIsOriginAllowedToAllowWildcardSubdomains();
//        });
//});

////builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
////   .AddNegotiate();

//var config = builder.Configuration;
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(o =>
//    {
//        o.TokenValidationParameters = new TokenValidationParameters()
//        {
//            ValidateIssuerSigningKey = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
//            ValidIssuer = config["Token:Issuer"],
//            ValidateIssuer = true,
//            ValidateAudience = false
//        };
//    });





//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "User", Version = "v1" });

//    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        Description = "JWT Authorization header using the Bearer scheme.",
//        Name = "Authorization",
//        In = ParameterLocation.Header,
//        Type = SecuritySchemeType.Http,
//        Scheme = "bearer"
//    });
//    c.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type = ReferenceType.SecurityScheme,
//                    Id = "Bearer"
//                }
//            },new string[] {}
//        }
//    });

//});
////builder.Services.AddCors(c =>
////{
////    c.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
////});

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
////app.UseCors(options => options.WithOrigins("http://localhost:4200", "http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
////app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
//    RequestPath = "/Images"
//});

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Files")),
//    RequestPath = "/Files"
//});
//app.UseAuthorization();

//app.MapControllers();

//app.Run();












///////////////////////////////////////////////////////

//using Fanush.DAL.Interfaces.EmployeeInterface;
//using Fanush.DAL.Interfaces;
//using Fanush.DAL.Repositories.EmployeeRepositories;
//using Fanush.DAL.Repositories;
//using Fanush.DAL;
//using Microsoft.AspNetCore.Authentication.Negotiate;
//using Microsoft.EntityFrameworkCore;
//using Fanush.DAL.Interfaces.TimeAndAttendeceInterface;
//using Fanush.DAL.Repositories.TimeAndAttendanceRepositories;
//using Fanush.DAL.Interfaces.RecruitmentInterface;
//using Fanush.DAL.Repositories.RecruitmentRepositories;
//using Fanush.DAL.Interfaces.PerformenceInterface;
//using Fanush.DAL.Repositories.PerformenceManagementRepositories;
//using Microsoft.AspNetCore.Authentication.JwtBearer;
//using Microsoft.OpenApi.Models;

//using Microsoft.IdentityModel.Tokens;
//using System.Text;
//using Fanush.DAL.JWTService;
//using Fanush.Entities.Administrator;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.Extensions.FileProviders;
//using Fanush.DAL.Interfaces.PayrollInterface;
//using Fanush.Repositories.PayrollManagement;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<FanushDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//var usrIden = builder.Services.AddIdentityCore<AppUser>();
//usrIden = new IdentityBuilder(usrIden.UserType, usrIden.Services);
//usrIden.AddEntityFrameworkStores<FanushDbContext>();
//usrIden.AddSignInManager<SignInManager<AppUser>>();

//builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
////EmployeeManagement
//builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeDataImportExportRepository, EmployeeDataImportExportRepository>();
//builder.Services.AddScoped<IEmployeeLifecycleRepository, EmployeeLifecycleRepository>();
//builder.Services.AddScoped<IJobTitleRepository, JobTitleRepository>();
////RecruitmentManagement
//builder.Services.AddScoped<IApplicantRepository, ApplicantRepository>();
//builder.Services.AddScoped<IInterviewRepository, InterviewRepository>();
//builder.Services.AddScoped<IJobPostingRepository, JobPostingRepository>();

////Time an Attendence 
//builder.Services.AddScoped<IAbsenceReportRepository, AbsenceReportRepository>();
//builder.Services.AddScoped<IClockInOutRepository, ClockInOutRepository>();
//builder.Services.AddScoped<ILeaveRepository, LeaveRepository>();
//builder.Services.AddScoped<IOvertimeRepository, OvertimeRepository>();
//builder.Services.AddScoped<IPayrollIntegrationRepository, PayrollIntegrationRepository>();

////PerformenceManagement
//builder.Services.AddScoped<IDevelopmentPlanRepository, DevelopmentPlanRepository>();
//builder.Services.AddScoped<IGoalRepository, GoalRepository>();
//builder.Services.AddScoped<IPerformanceReportRepository, PerformanceReportRepository>();
//builder.Services.AddScoped<IPerformanceReviewRepository, PerformanceReviewRepository>();
////PayrollManagement 
//builder.Services.AddScoped<IPayrollCalculationRepository, PayrollCalculationRepository>();

//builder.Services.AddScoped<ITokenService, TokenService>();

////builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
////   .AddNegotiate();

//var config = builder.Configuration;
//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(o =>
//    {
//        o.TokenValidationParameters = new TokenValidationParameters()
//        {
//            ValidateIssuerSigningKey = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Token:Key"])),
//            ValidIssuer = config["Token:Issuer"],
//            ValidateIssuer = true,
//            ValidateAudience = false
//        };
//    });



//builder.Services.AddCors(c =>
//{
//    c.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
//});
//builder.Services.AddSwaggerGen(c =>
//{
//    c.SwaggerDoc("v1", new OpenApiInfo { Title = "User", Version = "v1" });

//    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
//    {
//        Description = "JWT Authorization header using the Bearer scheme.",
//        Name = "Authorization",
//        In = ParameterLocation.Header,
//        Type = SecuritySchemeType.Http,
//        Scheme = "bearer"
//    });
//    c.AddSecurityRequirement(new OpenApiSecurityRequirement
//    {
//        {
//            new OpenApiSecurityScheme
//            {
//                Reference = new OpenApiReference
//                {
//                    Type = ReferenceType.SecurityScheme,
//                    Id = "Bearer"
//                }
//            },new string[] {}
//        }
//    });

//});
////builder.Services.AddCors(c =>
////{
////    c.AddPolicy("AllowOrigin", options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
////});

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
//app.UseCors(options => options.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod());
////app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyHeader().AllowAnyMethod());
//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Images")),
//    RequestPath = "/Images"
//});

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Files")),
//    RequestPath = "/Files"
//});
//app.UseAuthorization();



//app.MapControllers();

//app.Run();










//////

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


