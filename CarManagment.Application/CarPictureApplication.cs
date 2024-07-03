using _0_Freamwork.Application;
using CarManagment.Application.Contracts.CarPicture;
using CarManagment.Domain.CarPictureAgg;

namespace CarManagment.Application
{
    public class CarPictureApplication : ICarPictureApplication
    {
        private readonly ICarPictureRepository _carPictureRepository;
        public CarPictureApplication(ICarPictureRepository carPictureRepository)
        {
            _carPictureRepository = carPictureRepository;
        }

        public OperationResult Create(CreateCarPicture command)
        {
            var operation = new OperationResult();
            if (_carPictureRepository.Exists(x => x.Picture == command.Picture && x.CarId == command.CarId))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }

            var carPicture = new CarPicture(command.Picture, command.PictureAlt, command.PictureTitle, command.CarId);
            _carPictureRepository.Create(carPicture);
            _carPictureRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditCarPicture command)
        {
            var operation = new OperationResult();
            var carPicture = _carPictureRepository.Get(command.Id);
            if (carPicture == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            if (carPicture == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }
            if (_carPictureRepository.Exists(x => x.Picture == command.Picture && x.CarId == command.CarId && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }
            carPicture.Edit(command.Picture, command.PictureAlt, command.PictureTitle, command.CarId);
            _carPictureRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<CarPictureViewModel> GetCarPictures(int id)
        {
            return _carPictureRepository.GetCarPictures(id);
        }

        public EditCarPicture GetDetails(long id)
        {
            return _carPictureRepository.GetDetails(id);
        }

        public OperationResult Removed(long id)
        {
            var operation = new OperationResult();
            var carPicture = _carPictureRepository.Get(id);

            if (carPicture == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }

            carPicture.Removed();
            _carPictureRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Restore(long id)
        {
            var operation = new OperationResult();
            var carPicture = _carPictureRepository.Get(id);

            if (carPicture == null)
            {
                return operation.Failed(ApplicationMessage.RecordNotFound);
            }

            carPicture.Restore();
            _carPictureRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<CarPictureViewModel> Search(CarPictureSearchModel searchModel)
        {
            return _carPictureRepository.Search(searchModel);
        }
    }
}
