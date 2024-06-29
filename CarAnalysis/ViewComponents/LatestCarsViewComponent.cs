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
            var latestCars = Car.OrderByDescending(b => b.Id).Take(3).ToList();
            return View(latestCars);
        }
    }
}
