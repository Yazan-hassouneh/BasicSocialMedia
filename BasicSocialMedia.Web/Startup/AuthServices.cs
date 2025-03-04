﻿using BasicSocialMedia.Core.Models.AuthModels;
using BasicSocialMedia.Infrastructure.Data;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BasicSocialMedia.Web.Startup
{
	public static class AuthServices
	{
		internal static IServiceCollection AddIdentityServices(this IServiceCollection services)
		{
			services.AddIdentity<ApplicationUser, IdentityRole>()
				.AddEntityFrameworkStores<ApplicationDbContext>()
				.AddSignInManager()
				.AddRoles<IdentityRole>();

			return services;
		}
		internal static IServiceCollection AddJWTServices(this IServiceCollection services, WebApplicationBuilder builder)
		{
			services.AddAuthentication(options =>
			{
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			}).AddJwtBearer(jwtOptions =>
			{
				jwtOptions.RequireHttpsMetadata = false;
				jwtOptions.SaveToken = false;
				jwtOptions.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuer = true,
					ValidateAudience = true,
					ValidateLifetime = true,
					ValidateIssuerSigningKey = true,
					ValidIssuer = builder.Configuration["JWT:Issuer"],
					ValidAudience = builder.Configuration["JWT:Audience"],
					IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:key"])),
					ClockSkew = TimeSpan.Zero,
				};
			});

			return services;
		}
	}
}
