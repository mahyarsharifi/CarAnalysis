using _01_LampshadeQuery.Contracts.Comment;

namespace _01_CarAnalysisQuery.Contracts.Car
{
    public class CarQueryModel
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
        public string CarCategory { get; set; }
        public List<CarPictureQueryModel> CarPictures { get; set; }
        public List<CommentQueryModel> Comments { get; set; }
    }
    public class CarPictureQueryModel
    {
        public long CarId { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
    }
}
