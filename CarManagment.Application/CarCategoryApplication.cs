using _0_Freamwork.Application;
using CarManagment.Application.Contracts.CarCateory;
using CarManagment.Domain.CategoryAgg;

namespace CarManagment.Application
{
    public class CarCategoryApplication : ICarCategoryApplication
    {
        private readonly ICarCategoryRepository _carCategoryRepository;

        public CarCategoryApplication(ICarCategoryRepository carCategoryRepository)
        {
            _carCategoryRepository = carCategoryRepository;
        }

        public OperationResult Create(CreateCarCategory command)
        {
            var operation = new OperationResult();
            if (_carCategoryRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            var carCategory = new CarCategory(command.Name, command.Description, command.Picture, command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, command.Slug);

            _carCategoryRepository.Create(carCategory);
            _carCategoryRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditCarCategory command)
        {
            var operation = new OperationResult();
            var carCategory = _carCategoryRepository.Get(command.Id);

            if (carCategory == null)
                return operation.Failed(ApplicationMessage.RecordNotFound);

            if (_carCategoryRepository.Exists(x => x.Name == command.Name))
                return operation.Failed(ApplicationMessage.DuplicatedRecord);

            carCategory.Edit(command.Name, command.Description, command.Picture, command.PictureAlt, command.PictureTitle, command.Keywords, command.MetaDescription, command.Slug);

            _carCategoryRepository.SaveChanges();
            return operation.Succedded();
        }

        public EditCarCategory GetDetails(long id)
        {
            return _carCategoryRepository.GetDetails(id);
        }

        public List<CarCategoryViewModel> GetCarCategories()
        {
            return _carCategoryRepository.GetCarCategories();
        }
    }
}
