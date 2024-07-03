using _0_Freamwork.Infrastrucure;
using CarManagment.Application.Contracts.CarPicture;
using CarManagment.Domain.CarPictureAgg;
using Microsoft.EntityFrameworkCore;

namespace CarManagment.Infrastracture.EFCore.Repository
{
    public class CarPictureRepository : RepositoryBase<long, CarPicture>, ICarPictureRepository
    {
        private readonly CarContext _context;
        public CarPictureRepository(CarContext context) : base(context)
        {
            _context = context;
        }
        public CarPicture Get(long id)
        {
            return _context.CarPictures.Find(id);
        }

        public EditCarPicture GetDetails(long id)
        {
            return _context.CarPictures.Select(x => new EditCarPicture
            {
                Id = x.Id,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                CarId = x.CarId,
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CarPictureViewModel> Search(CarPictureSearchModel searchModel)
        {
            var query = _context.CarPictures.Include(x => x.Car).Select(x => new CarPictureViewModel
            {
                Id = x.Id,
                Car = x.Car.CarName,
                Picture = x.Picture,
                CarId = x.CarId,
                IsRemoved = x.IsRemoved
            });

            if (searchModel.CarId != 0)
            {
                query = query.Where(x => x.CarId == searchModel.CarId);
            }

            return query.OrderByDescending(x => x.Id).ToList();
        }

        public List<CarPictureViewModel> GetCarPictures(int id)
        {
            return _context.CarPictures.Select(x => new CarPictureViewModel
            {
                Id = x.Id,
                CarId = x.CarId,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).Where(x => x.CarId == id).ToList();
        }
    }
}
