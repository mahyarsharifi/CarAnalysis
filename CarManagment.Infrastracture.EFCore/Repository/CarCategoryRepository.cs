using _0_Freamwork.Infrastrucure;
using CarManagment.Application.Contracts.CarCateory;
using CarManagment.Domain.CategoryAgg;

namespace CarManagment.Infrastracture.EFCore.Repository
{
    public class CarCategoryRepository : RepositoryBase<long, CarCategory>, ICarCategoryRepository
    {
        private readonly CarContext _context;

        public CarCategoryRepository(CarContext context) : base(context)
        {
            _context = context;
        }

        public CarCategory Get(long id)
        {
            return _context.CarCategories.Find(id);
        }

        public List<CarCategoryViewModel> GetCarCategories()
        {
            return _context.CarCategories.Select(x => new CarCategoryViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                Description = x.Description
            }).ToList();
        }

        public EditCarCategory GetDetails(long id)
        {
            return _context.CarCategories.Select(x => new EditCarCategory
            {
                Id = x.Id,
                Name = x.Name,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                Description = x.Description,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription,
                Slug = x.Slug
            }).FirstOrDefault(x => x.Id == id);
        }
    }
}
