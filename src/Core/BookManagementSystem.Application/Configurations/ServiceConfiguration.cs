using BookManagementSystem.Application.Services;
using BookManagementSystem.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using BookManagementSystem.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BookManagementSystem.Application.Configurations
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection RegisterServices(this IServiceCollection service)
        {
            service.AddScoped<IBookService, BookService>();
            service.AddScoped<IAuthorService, AuthorService>();
            service.AddScoped<IPublisherService, PublisherService>();

            var assembly = Assembly.GetExecutingAssembly();
            service.AddAutoMapper(assembly);

            return service;
        }
    }
}