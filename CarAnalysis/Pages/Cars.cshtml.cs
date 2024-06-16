using CarManagment.Application.Contracts.Car;
using CarManagment.Domain.CarAgg;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarAnalysis.Pages
{
    public class CarsModel : PageModel
    {
        public List<CarViewModel> Cars;
        private readonly ICarRepository _carRepository;

        public CarsModel(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public void OnGet(long groupId)
        {
            Cars = _carRepository.GetCarsByGroupId(groupId);
        }
    }
}
