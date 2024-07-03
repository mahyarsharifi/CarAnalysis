using _0_Freamwork.Application;

namespace CarManagment.Application.Contracts.CarPicture
{
    public interface ICarPictureApplication
    {
        OperationResult Create(CreateCarPicture command);
        OperationResult Edit(EditCarPicture command);
        OperationResult Removed(long id);
        OperationResult Restore(long id);
        EditCarPicture GetDetails(long id);
        List<CarPictureViewModel> GetCarPictures(int id);
        List<CarPictureViewModel> Search(CarPictureSearchModel searchModel);
    }
}
