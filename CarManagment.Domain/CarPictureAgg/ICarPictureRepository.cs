using _0_Freamwork.Domain;
using CarManagment.Application.Contracts.CarPicture;

namespace CarManagment.Domain.CarPictureAgg
{
    public interface ICarPictureRepository : IRepository<long, CarPicture>
    {
        EditCarPicture GetDetails(long id);
        CarPicture Get(long id);
        List<CarPictureViewModel> Search(CarPictureSearchModel searchModel);
    }
}
