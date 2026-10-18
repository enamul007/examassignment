using ExamAssignmentApi.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// ১. JSON Cycle Error রোধ করার জন্য IgnoreCycles যুক্ত করা হলো
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularClient", policy =>
    {
        policy
            .WithOrigins("http://localhost:8200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

var jwtSettings = builder.Configuration.GetSection("Jwt");
var secretKeyString = jwtSettings["Key"] ?? "ThisIsADefaultSecretKeyForDevelopmentOnlyMakeItLonger";
var secretKey = Encoding.UTF8.GetBytes(secretKeyString);

builder.Services
    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = jwtSettings["Issuer"] ?? "ExamAssignmentApi",
            ValidAudience = jwtSettings["Audience"] ?? "ExamAssignmentUsers",
            IssuerSigningKey = new SymmetricSecurityKey(secretKey),
            RoleClaimType = ClaimTypes.Role
        };
    });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    // ডেভেলপমেন্টে আসল এরর দেখার জন্য DeveloperExceptionPage চালু থাকবে
    app.UseDeveloperExceptionPage();
}

// ২. CORS অবশ্যই সবার উপরে (Authentication ও Redirection এর আগে) থাকতে হবে
app.UseCors("AllowAngularClient");

// app.UseHttpsRedirection(); // লোকাল HTTP (5162) পোর্টে চালানোর সময় এটি বন্ধ রাখা নিরাপদ

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();