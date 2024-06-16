using CarManagment.Domain.CarPictureAgg;
using CarManagment.Domain.CategoryAgg;
using System;

namespace CarManagment.Domain.CarAgg
{
    public class Car
    {
        public long Id { get; set; }
        public string CarName { get; set; }
        public string ProducingCountry { get; set; }
        public string BodyClass { get; set; }
        public string Weight { get; set; }
        public int PassengerSpaces { get; set; }
        public string TheDimensionsAndTypeOfTiresOfTheFrontWheels { get; set; }
        public string TheDimensionsAndTypeOfTiresOfTheRearWheels { get; set; }
        public string EngineVolume { get; set; }
        public string EngineType { get; set; }
        public int Cylinders { get; set; }
        public int Valves { get; set; }
        public string ArrangementOfCylinders { get; set; }
        public string FuelSystem { get; set; }
        public string MaximumOutputPower { get; set; }
        public string MaximumOutputTorque { get; set; }
        public int TankCapacity { get; set; }
        public string TypeOfGearbox { get; set; }
        public string NumberOfGears { get; set; }
        public string VehicleMotionSystem { get; set; }
        public string FrontDiskType { get; set; }
        public string RearDiskType { get; set; }
        public string FrontShockAbsorbers { get; set; }
        public string RearShockAbsorbers { get; set; }
        public string TypeOfSteeringSystem { get; set; }
        public int MaximumSpeed { get; set; }
        public string AccelerationFrom0To100 { get; set; }
        public string UrbanFuelConsumption { get; set; }
        public string RoadFuelConsumption { get; set; }
        public string CombinedFuelConsumption { get; set; }
        public string EmissionStandard { get; set; }
        public string SafetyStar { get; set; }
        public string Airbags { get; set; }
        public string StabilityAndDriverAssistanceSystems { get; set; }
        public string SecurityAndProtectionSystems { get; set; }
        public string AirConditioningSystems { get; set; }
        public string AudioAndVideoSystem { get; set; }
        public string MultimediaSystems { get; set; }
        public string FrontSeatSystem { get; set; }
        public string RearSeatSystem { get; set; }
        public string MirrorSystem { get; set; }
        public string GlasssSystem { get; set; }
        public string RoofSystems { get; set; }
        public string FrontLightingSystem { get; set; }
        public string RearLightingSystem { get; set; }
        public string DrivingAssistanceSystems { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public DateTime CreationDate { get; set; }
        public string Slug { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public long CarCategoryId { get; set; }
        public CarCategory CarCategory { get; set; }
        public List<CarPicture> CarPictures { get; set; }

        public Car(string carName, string producingCountry, string bodyClass, string weight, int passengerSpaces,
            string theDimensionsAndTypeOfTiresOfTheFrontWheels, string theDimensionsAndTypeOfTiresOfTheRearWheels,
            string engineVolume, string engineType, int cylinders, int valves, string arrangementOfCylinders, string fuelSystem,
            string maximumOutputPower, string maximumOutputTorque, int tankCapacity, string typeOfGearbox, string numberOfGears,
            string vehicleMotionSystem, string frontDiskType, string rearDiskType, string frontShockAbsorbers, string rearShockAbsorbers,
            string typeOfSteeringSystem, int maximumSpeed, string accelerationFrom0To100, string urbanFuelConsumption, string roadFuelConsumption,
            string combinedFuelConsumption, string emissionStandard, string safetyStar, string airbags, string stabilityAndDriverAssistanceSystems,
            string securityAndProtectionSystems, string airConditioningSystems, string audioAndVideoSystem, string multimediaSystems,
            string frontSeatSystem, string rearSeatSystem, string mirrorSystem, string glasssSystem, string roofSystems, string frontLightingSystem,
            string rearLightingSystem, string drivingAssistanceSystems, string description, string picture, string pictureAlt, string pictureTitle,
            string slug, string keywords, string metaDescription, long carCategoryId)
        {
            CarName = carName;
            ProducingCountry = producingCountry;
            BodyClass = bodyClass;
            Weight = weight;
            PassengerSpaces = passengerSpaces;
            TheDimensionsAndTypeOfTiresOfTheFrontWheels = theDimensionsAndTypeOfTiresOfTheFrontWheels;
            TheDimensionsAndTypeOfTiresOfTheRearWheels = theDimensionsAndTypeOfTiresOfTheRearWheels;
            EngineVolume = engineVolume;
            EngineType = engineType;
            Cylinders = cylinders;
            Valves = valves;
            ArrangementOfCylinders = arrangementOfCylinders;
            FuelSystem = fuelSystem;
            MaximumOutputPower = maximumOutputPower;
            MaximumOutputTorque = maximumOutputTorque;
            TankCapacity = tankCapacity;
            TypeOfGearbox = typeOfGearbox;
            NumberOfGears = numberOfGears;
            VehicleMotionSystem = vehicleMotionSystem;
            FrontDiskType = frontDiskType;
            RearDiskType = rearDiskType;
            FrontShockAbsorbers = frontShockAbsorbers;
            RearShockAbsorbers = rearShockAbsorbers;
            TypeOfSteeringSystem = typeOfSteeringSystem;
            MaximumSpeed = maximumSpeed;
            AccelerationFrom0To100 = accelerationFrom0To100;
            UrbanFuelConsumption = urbanFuelConsumption;
            RoadFuelConsumption = roadFuelConsumption;
            CombinedFuelConsumption = combinedFuelConsumption;
            EmissionStandard = emissionStandard;
            SafetyStar = safetyStar;
            Airbags = airbags;
            StabilityAndDriverAssistanceSystems = stabilityAndDriverAssistanceSystems;
            SecurityAndProtectionSystems = securityAndProtectionSystems;
            AirConditioningSystems = airConditioningSystems;
            AudioAndVideoSystem = audioAndVideoSystem;
            MultimediaSystems = multimediaSystems;
            FrontSeatSystem = frontSeatSystem;
            RearSeatSystem = rearSeatSystem;
            MirrorSystem = mirrorSystem;
            GlasssSystem = glasssSystem;
            RoofSystems = roofSystems;
            FrontLightingSystem = frontLightingSystem;
            RearLightingSystem = rearLightingSystem;
            DrivingAssistanceSystems = drivingAssistanceSystems;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CreationDate = DateTime.Now;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CarCategoryId = carCategoryId;
        }

        public void Edit(string carName, string producingCountry, string bodyClass, string weight, int passengerSpaces,
            string theDimensionsAndTypeOfTiresOfTheFrontWheels, string theDimensionsAndTypeOfTiresOfTheRearWheels,
            string engineVolume, string engineType, int cylinders, int valves, string arrangementOfCylinders, string fuelSystem,
            string maximumOutputPower, string maximumOutputTorque, int tankCapacity, string typeOfGearbox, string numberOfGears,
            string vehicleMotionSystem, string frontDiskType, string rearDiskType, string frontShockAbsorbers, string rearShockAbsorbers,
            string typeOfSteeringSystem, int maximumSpeed, string accelerationFrom0To100, string urbanFuelConsumption, string roadFuelConsumption,
            string combinedFuelConsumption, string emissionStandard, string safetyStar, string airbags, string stabilityAndDriverAssistanceSystems,
            string securityAndProtectionSystems, string airConditioningSystems, string audioAndVideoSystem, string multimediaSystems,
            string frontSeatSystem, string rearSeatSystem, string mirrorSystem, string glasssSystem, string roofSystems, string frontLightingSystem,
            string rearLightingSystem, string drivingAssistanceSystems, string description, string picture, string pictureAlt, string pictureTitle,
            string slug, string keywords, string metaDescription, long carCategoryId)
        {
            CarName = carName;
            ProducingCountry = producingCountry;
            BodyClass = bodyClass;
            Weight = weight;
            PassengerSpaces = passengerSpaces;
            TheDimensionsAndTypeOfTiresOfTheFrontWheels = theDimensionsAndTypeOfTiresOfTheFrontWheels;
            TheDimensionsAndTypeOfTiresOfTheRearWheels = theDimensionsAndTypeOfTiresOfTheRearWheels;
            EngineVolume = engineVolume;
            EngineType = engineType;
            Cylinders = cylinders;
            Valves = valves;
            ArrangementOfCylinders = arrangementOfCylinders;
            FuelSystem = fuelSystem;
            MaximumOutputPower = maximumOutputPower;
            MaximumOutputTorque = maximumOutputTorque;
            TankCapacity = tankCapacity;
            TypeOfGearbox = typeOfGearbox;
            NumberOfGears = numberOfGears;
            VehicleMotionSystem = vehicleMotionSystem;
            FrontDiskType = frontDiskType;
            RearDiskType = rearDiskType;
            FrontShockAbsorbers = frontShockAbsorbers;
            RearShockAbsorbers = rearShockAbsorbers;
            TypeOfSteeringSystem = typeOfSteeringSystem;
            MaximumSpeed = maximumSpeed;
            AccelerationFrom0To100 = accelerationFrom0To100;
            UrbanFuelConsumption = urbanFuelConsumption;
            RoadFuelConsumption = roadFuelConsumption;
            CombinedFuelConsumption = combinedFuelConsumption;
            EmissionStandard = emissionStandard;
            SafetyStar = safetyStar;
            Airbags = airbags;
            StabilityAndDriverAssistanceSystems = stabilityAndDriverAssistanceSystems;
            SecurityAndProtectionSystems = securityAndProtectionSystems;
            AirConditioningSystems = airConditioningSystems;
            AudioAndVideoSystem = audioAndVideoSystem;
            MultimediaSystems = multimediaSystems;
            FrontSeatSystem = frontSeatSystem;
            RearSeatSystem = rearSeatSystem;
            MirrorSystem = mirrorSystem;
            GlasssSystem = glasssSystem;
            RoofSystems = roofSystems;
            FrontLightingSystem = frontLightingSystem;
            RearLightingSystem = rearLightingSystem;
            DrivingAssistanceSystems = drivingAssistanceSystems;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Slug = slug;
            Keywords = keywords;
            MetaDescription = metaDescription;
            CarCategoryId = carCategoryId;
        }
    }
}