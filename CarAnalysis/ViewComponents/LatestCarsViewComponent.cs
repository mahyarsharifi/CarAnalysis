using BlogManagment.Application.Contracts.Blog;
using BlogManagment.Domain.BlogAgg;
using CarManagment.Application.Contracts.Car;
using CarManagment.Domain.CarAgg;
using Microsoft.AspNetCore.Mvc;

namespace CarAnalysis.ViewComponents
{
    public class LatestCarsViewComponent : ViewComponent
    {
        public List<CarViewModel> Car;
        private readonly ICarRepository _carRepository;

        public LatestCarsViewComponent(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public IViewComponentResult Invoke()
        {
            Car = _carRepository.GetCars();
            Car.Take(4);
            return View(Car);
        }
    }
}
