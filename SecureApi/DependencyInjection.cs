using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SecureApi.Configuration;
using SecureApi.Services;
using System.Text;

namespace SecureApi
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSecureApi(this IServiceCollection services, IConfiguration configuration)
        {
            // Register JWT settings
            services.Configure<JwtTokenSettings>(configuration.GetSection("JwtTokenSettings"));

            var key = configuration["JwtTokenSettings:Key"] ?? string.Empty;
            var issuer = configuration["JwtTokenSettings:Issuer"] ?? string.Empty;
            var audience = configuration["JwtTokenSettings:Audience"] ?? string.Empty;

            // Register JWT service
            services.AddScoped<IJwtService, JwtService>();

            // Register authentication and authorization
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
                    ValidateIssuer = true,
                    ValidIssuer = issuer,
                    ValidateAudience = true,
                    ValidAudience = audience
                };
            });

            // Register JWT service
            services.AddScoped<IJwtService, JwtService>();                       
            
            return services;
        }
    }
}
