using BookManagementSystem.Application.Interfaces;
using BookManagementSystem.Application.Services;
using BookManagementSystem.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BookManagementSystem.Persistence.Configuration
{
    public static class ServiceConfiguration
    {
        public static IServiceCollection AddRepositories(this IServiceCollection service)
        {
            service.AddScoped<IBookRepository, BookRepository>();
            service.AddScoped<IAuthorRepository, AuthorRepository>();
            service.AddScoped<IPublisherRepository, PublisherRepository>();
            service.AddScoped<IBookAuthorRepository, BookAuthorRepository>();


            var assembly = Assembly.GetExecutingAssembly();
            service.AddAutoMapper(assembly);

            return service;
        }
    }
}
