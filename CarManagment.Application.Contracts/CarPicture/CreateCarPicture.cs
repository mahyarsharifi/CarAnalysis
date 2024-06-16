using CarManagment.Application.Contracts.Car;
using System.ComponentModel.DataAnnotations;

namespace CarManagment.Application.Contracts.CarPicture
{
    public class CreateCarPicture
    {
        public long CarId { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public List<CarViewModel> Cars { get; set; }
    }
}
