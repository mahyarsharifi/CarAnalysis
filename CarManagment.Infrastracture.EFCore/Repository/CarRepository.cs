using _0_Freamwork.Infrastrucure;
using CarManagment.Application.Contracts.Car;
using CarManagment.Domain.CarAgg;


namespace CarManagment.Infrastracture.EFCore.Repository
{
    public class CarRepository : RepositoryBase<long, Car>, ICarRepository
    {
        private readonly CarContext _context;

        public CarRepository(CarContext context) : base(context)
        {
            _context = context;
        }

        public Car Get(long id)
        {
            return _context.Cars.Find(id);
        }

        public List<CarViewModel> GetCars()
        {
            return _context.Cars.Select(x => new CarViewModel
            {
                Id = x.Id,
                CarName = x.CarName
            }).ToList();
        }

        public List<CarViewModel> GetCarsByGroupId(long groupId)
        {
            return _context.Cars.Where(x => x.CarCategoryId == groupId).Select(x => new CarViewModel
            {
                Id = x.Id,
                CarName = x.CarName,
                BodyClass = x.BodyClass,
                CarCategoryId = x.CarCategoryId,
                Cylinders = x.Cylinders,
                CombinedFuelConsumption = x.CombinedFuelConsumption,
                EngineVolume = x.EngineVolume,
                MaximumOutputPower = x.MaximumOutputPower,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ProducingCountry = x.ProducingCountry,
                TypeOfGearbox = x.TypeOfGearbox,
            }).ToList();
        }

        public EditCar GetDetails(long id)
        {
            return _context.Cars.Select(x => new EditCar
            {
                Id = x.Id,
                CarName = x.CarName,
                ProducingCountry = x.ProducingCountry,
                BodyClass = x.BodyClass,
                Weight = x.Weight,
                PassengerSpaces = x.PassengerSpaces,
                TheDimensionsAndTypeOfTiresOfTheFrontWheels = x.TheDimensionsAndTypeOfTiresOfTheFrontWheels,
                TheDimensionsAndTypeOfTiresOfTheRearWheels = x.TheDimensionsAndTypeOfTiresOfTheRearWheels,
                EngineVolume = x.EngineVolume,
                EngineType = x.EngineType,
                Cylinders = x.Cylinders,
                Valves = x.Valves,
                ArrangementOfCylinders = x.ArrangementOfCylinders,
                FuelSystem = x.FuelSystem,
                MaximumOutputPower = x.MaximumOutputPower,
                MaximumOutputTorque = x.MaximumOutputTorque,
                TankCapacity = x.TankCapacity,
                NumberOfGears = x.NumberOfGears,
                VehicleMotionSystem = x.VehicleMotionSystem,
                FrontDiskType = x.FrontDiskType,
                RearDiskType = x.FrontDiskType,
                FrontShockAbsorbers = x.FrontShockAbsorbers,
                RearShockAbsorbers = x.RearShockAbsorbers,
                TypeOfSteeringSystem = x.TypeOfSteeringSystem,
                MaximumSpeed = x.MaximumSpeed,
                AccelerationFrom0To100 = x.AccelerationFrom0To100,
                UrbanFuelConsumption = x.UrbanFuelConsumption,
                RoadFuelConsumption = x.RoadFuelConsumption,
                CombinedFuelConsumption = x.CombinedFuelConsumption,
                EmissionStandard = x.EmissionStandard,
                SafetyStar = x.SafetyStar,
                Airbags = x.Airbags,
                StabilityAndDriverAssistanceSystems = x.StabilityAndDriverAssistanceSystems,
                SecurityAndProtectionSystems = x.SecurityAndProtectionSystems,
                AirConditioningSystems = x.AirConditioningSystems,
                AudioAndVideoSystem = x.AudioAndVideoSystem,
                MultimediaSystems = x.MultimediaSystems,
                FrontSeatSystem = x.FrontSeatSystem,
                RearSeatSystem = x.RearSeatSystem,
                MirrorSystem = x.MirrorSystem,
                GlasssSystem = x.GlasssSystem,
                RoofSystems = x.RoofSystems,
                FrontLightingSystem = x.FrontLightingSystem,
                RearLightingSystem = x.DrivingAssistanceSystems,
                DrivingAssistanceSystems = x.DrivingAssistanceSystems,
                Description = x.Description,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                CarCategoryId = x.CarCategoryId,
                Slug = x.Slug,
                Keywords = x.Keywords,
                MetaDescription = x.MetaDescription
            }).FirstOrDefault(x => x.Id == id);
        }

        public List<CarViewModel> Serach(CarSearchModel searchModel)
        {
            var query = _context.Cars.Select(x => new CarViewModel
            {
                Id = x.Id,
                CarName = x.CarName,
                BodyClass = x.BodyClass,
                CarCategoryId = x.CarCategoryId,
                Cylinders = x.Cylinders,
                CombinedFuelConsumption = x.CombinedFuelConsumption,
                EngineVolume = x.EngineVolume,
                MaximumOutputPower = x.MaximumOutputPower,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle,
                ProducingCountry = x.ProducingCountry,
                TypeOfGearbox = x.TypeOfGearbox
            });

            if (!string.IsNullOrWhiteSpace(searchModel.CarName))
                query = query.Where(x => x.CarName.Contains(searchModel.CarName));

            return query.OrderByDescending(x => x.Id).ToList();
        }
    }
}
