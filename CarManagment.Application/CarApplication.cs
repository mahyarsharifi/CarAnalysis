using _0_Framework.Application;
using _0_Freamwork.Application;
using CarManagment.Application.Contracts.Car;
using CarManagment.Domain.CarAgg;

namespace CarManagment.Application
{
    public class CarApplication : ICarApplication
    {
        private readonly ICarRepository _carRepository;

        public CarApplication(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        public OperationResult Create(CreateCar command)
        {
            var operation = new OperationResult();
            if (_carRepository.Exists(x => x.CarName == command.CarName))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }

            var car = new Car(command.CarName, command.ProducingCountry, command.BodyClass, command.Weight,
                command.PassengerSpaces, command.TheDimensionsAndTypeOfTiresOfTheFrontWheels, command.TheDimensionsAndTypeOfTiresOfTheRearWheels,
                command.EngineVolume, command.EngineType, command.Cylinders, command.Valves, command.ArrangementOfCylinders,
                command.FuelSystem, command.MaximumOutputPower, command.MaximumOutputTorque, command.TankCapacity, command.TypeOfGearbox,
                command.NumberOfGears, command.VehicleMotionSystem, command.FrontDiskType, command.RearDiskType, command.FrontShockAbsorbers,
                command.RearShockAbsorbers, command.TypeOfSteeringSystem, command.MaximumSpeed, command.AccelerationFrom0To100, command.UrbanFuelConsumption,
                command.RoadFuelConsumption, command.CombinedFuelConsumption, command.EmissionStandard, command.SafetyStar, command.Airbags,
                command.StabilityAndDriverAssistanceSystems, command.SecurityAndProtectionSystems, command.AirConditioningSystems, command.AudioAndVideoSystem,
                command.MultimediaSystems, command.FrontSeatSystem, command.RearSeatSystem, command.MirrorSystem, command.GlasssSystem, command.RoofSystems, command.FrontLightingSystem, command.RearLightingSystem,
                command.DrivingAssistanceSystems, command.Description, command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.Keywords,
                command.MetaDescription, command.CategoryId);

            _carRepository.Create(car);
            _carRepository.SaveChanges();
            return operation.Succedded();
        }

        public OperationResult Edit(EditCar command)
        {
            var operation = new OperationResult();
            var car = _carRepository.Get(command.Id);
            if (car == null)
            {
                operation.Failed(ApplicationMessage.RecordNotFound);
            }
            if (_carRepository.Exists(x => x.CarName == command.CarName && x.Id != command.Id))
            {
                return operation.Failed(ApplicationMessage.DuplicatedRecord);
            }

            car.Edit(command.CarName, command.ProducingCountry, command.BodyClass, command.Weight,
                command.PassengerSpaces, command.TheDimensionsAndTypeOfTiresOfTheFrontWheels, command.TheDimensionsAndTypeOfTiresOfTheRearWheels,
                command.EngineVolume, command.EngineType, command.Cylinders, command.Valves, command.ArrangementOfCylinders,
                command.FuelSystem, command.MaximumOutputPower, command.MaximumOutputTorque, command.TankCapacity, command.TypeOfGearbox,
                command.NumberOfGears, command.VehicleMotionSystem, command.FrontDiskType, command.RearDiskType, command.FrontShockAbsorbers,
                command.RearShockAbsorbers, command.TypeOfSteeringSystem, command.MaximumSpeed, command.AccelerationFrom0To100, command.UrbanFuelConsumption,
                command.RoadFuelConsumption, command.CombinedFuelConsumption, command.EmissionStandard, command.SafetyStar, command.Airbags,
                command.StabilityAndDriverAssistanceSystems, command.SecurityAndProtectionSystems, command.AirConditioningSystems, command.AudioAndVideoSystem,
                command.MultimediaSystems, command.FrontSeatSystem, command.RearSeatSystem, command.MirrorSystem, command.GlasssSystem, command.RoofSystems, command.FrontLightingSystem, command.RearLightingSystem,
                command.DrivingAssistanceSystems, command.Description, command.Picture, command.PictureAlt, command.PictureTitle, command.Slug, command.Keywords,
                command.MetaDescription, command.CategoryId);

            _carRepository.SaveChanges();
            return operation.Succedded();
        }

        public List<CarViewModel> GetCars()
        {
            return _carRepository.GetCars();
        }

        public List<CarViewModel> GetCarsByGroupId(long groupId)
        {
            return _carRepository.GetCarsByGroupId(groupId);
        }

        public EditCar GetDetails(long id)
        {
            return _carRepository.GetDetails(id);
        }

        public List<CarViewModel> Search(CarSearchModel searchModel)
        {
            return _carRepository.Serach(searchModel);
        }
    }
}
