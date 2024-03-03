using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using PracticeTracker.Services.Authorization;
using PracticeTracker.Services.Authorization.Interfaces;
using PracticeTracker.Services.Authorization.Repositories;
using PracticeTracker.Services.Authorization.Repositories.Interfaces;
using PracticeTracker.Services.Authorization.Validate;
using PracticeTracker.Services.Role;
using PracticeTracker.Services.Role.Interfaces;
using PracticeTracker.Services.Role.Repositories;
using PracticeTracker.Services.Role.Repositories.Interfaces;
using PracticeTracker.Services.Role.Validate;
using PracticeTracker.Services.Users;
using PracticeTracker.Services.Users.Interfaces;
using PracticeTracker.Services.Users.Repositories;
using PracticeTracker.Services.Users.Repositories.Interfaces;
using PracticeTracker.Services.Users.Validate;
using PracticeTracker.Tools.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = AuthOptions.ISSUER,
            ValidateAudience = true,
            ValidAudience = AuthOptions.AUDIENCE,
            ValidateLifetime = true,
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            ValidateIssuerSigningKey = true,
        };
    });

builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true).Build();
//builder.Services.AddSingleton<NpgSqlRepository>(new NpgSqlRepository(builder.Configuration)); TODO: разобраться с конфигурацией
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IAuthorizationService, AuthorizationService>();
builder.Services.AddTransient<IAuthorizationRepository, AuthorizationRepository>();

builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddTransient<IRoleService, RoleService>();
builder.Services.AddTransient<IRoleRepository, RoleRepository>();

builder.Services.AddTransient<VAuthorizationService>();
builder.Services.AddTransient<VRoleService>();
builder.Services.AddTransient<VUserService>();

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