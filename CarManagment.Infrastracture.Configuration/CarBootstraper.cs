using _01_CarAnalysisQuery.Contracts.Car;
using _01_CarAnalysisQuery.Query;
using BlogManagment.Application;
using CarManagment.Application;
using CarManagment.Application.Contracts.Car;
using CarManagment.Application.Contracts.CarCateory;
using CarManagment.Application.Contracts.CarPicture;
using CarManagment.Domain.CarAgg;
using CarManagment.Domain.CarPictureAgg;
using CarManagment.Domain.CategoryAgg;
using CarManagment.Infrastracture.EFCore;
using CarManagment.Infrastracture.EFCore.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CarManagment.Infrastracture.Configuration
{
    public class CarBootstraper
    {
        public static void Configure(IServiceCollection services, string connectionString)
        {

            services.AddTransient<ICarApplication, CarApplication>();
            services.AddTransient<ICarRepository, CarRepository>();

            services.AddTransient<ICarCategoryApplication, CarCategoryApplication>();
            services.AddTransient<ICarCategoryRepository, CarCategoryRepository>();

            services.AddTransient<ICarPictureApplication, CarPictureApplication>();
            services.AddTransient<ICarPictureRepository, CarPictureRepository>();

            services.AddTransient<ICarQuery, CarQuery>();

            services.AddDbContext<CarContext>(x => x.UseSqlServer(connectionString));
        }
    }
}