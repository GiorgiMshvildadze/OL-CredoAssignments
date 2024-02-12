using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;
using ToDoApi.Auth;


// program.cs-ში asp.net identity-ს კონფიგურირება

var builder = WebApplication.CreateBuilder(args);

// ...

// Token-ის შემქმნელი
var issuer = "myapp.com";

// Token-ის აუდიტორია
var audience = "myapp.com";

// Token-ის გასაღები 

var secretKey = "asaskljdabuivknaky12312312312312312312ashjkdbasjkda";

builder.Services.Configure<JwtSettings>(s =>
{
    s.Issuer = issuer;
    s.Audience = audience;
    s.SecretKey = secretKey;
});

// Token-ის ვალიდაციის პარამეტრები, რის მიხედვითაც asp.net მოახდენს ვალიდაციას
var tokenValidationParameters = new TokenValidationParameters
{
    ValidateIssuer = true,
    ValidateAudience = true,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true,
    ValidIssuer = issuer,
    ValidAudience = audience,
    ClockSkew = TimeSpan.Zero,
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey))
};

// საჭირო სერვისების IoC-ში რეგისტრაცია
builder.Services
    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options => { options.TokenValidationParameters = tokenValidationParameters; });
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();


builder.Services.AddDbContext<AppDbContext>(c => c.UseSqlServer(builder.Configuration["AppDbContextConnection"]));
builder.Services.AddTransient<JwtTokenGenerator>();

// Policy-ს შექმნა და კონტეინერში დამატება
builder.Services.AddAuthorization(options =>
{
    options.AddPolicy("MyApiUserPolicy",
        policy => policy.RequireClaim(ClaimTypes.Role, "api-user"));
});

// UserEntity და RoleEntity კლასების მიხედვით მოხდება ბაზაში ცხრილების შექმნა
builder.Services
    .AddIdentity<UserEntity, RoleEntity>(o =>
    {
        o.Password.RequireDigit = true;
        o.Password.RequireLowercase = true;
        o.Password.RequireUppercase = true;
        o.Password.RequireNonAlphanumeric = false;
        o.Password.RequiredLength = 8;
    })
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

// ...

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// ...

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// ...

app.Run();
