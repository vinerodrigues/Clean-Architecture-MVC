using CleanArcMvc.Aplication.AutoMapper;
using CleanArcMvc.Aplication.IServices;
using CleanArcMvc.Aplication.Services;
using CleanArcMvc.Domain.IRepository;
using CleanArcMvc.Infra.Data.Context;
using CleanArcMvc.Infra.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArcMvc.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) {

            //Iniciando a instancia da classe de contexto
            services.AddDbContext<AplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly(typeof(AplicationDbContext).Assembly.FullName)));

            //Repositórios
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            //Serviços
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();

            //Mapeamento 
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
