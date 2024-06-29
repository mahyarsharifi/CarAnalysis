using _01_CarAnalysisQuery.Contracts.Car;
using CarManagment.Domain.CarPictureAgg;
using CarManagment.Infrastracture.EFCore;
using Microsoft.EntityFrameworkCore;

namespace _01_CarAnalysisQuery.Query
{
    public class CarQuery : ICarQuery
    {
        private readonly CarContext _context;
        public CarQuery(CarContext context)
        {
            _context = context;
        }

        public CarQueryModel GetCarDetails(int id)
        {
            var car = _context.Cars
                .Include(x => x.CarCategory)
                .Include(x => x.CarPictures)
                .Select(x => new CarQueryModel
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
                    MetaDescription = x.MetaDescription,
                    CreationDate = x.CreationDate,
                    CarPictures = MapProductPictures(x.CarPictures),
                    CarCategory = x.CarCategory.Name
                }).AsNoTracking().FirstOrDefault(x => x.Id == id);

            return car;
        }

        private static List<CarPictureQueryModel> MapProductPictures(List<CarPicture> carPictures)
        {
            return carPictures.Select(x => new CarPictureQueryModel
            {
                CarId = x.CarId,
                Picture = x.Picture,
                PictureAlt = x.PictureAlt,
                PictureTitle = x.PictureTitle
            }).ToList();
        }

        public CarQueryModel GetCar(int id)
        {
            return _context.Cars
            .Include(x => x.CarCategory)
            .Where(x => x.CarCategoryId == x.CarCategoryId)
            .Select(x => new CarQueryModel
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
                MetaDescription = x.MetaDescription,
                CreationDate = x.CreationDate,
                CarCategory = x.CarCategory.Name
            }).AsNoTracking().FirstOrDefault(x => x.Id == id);
        }
    }
}
