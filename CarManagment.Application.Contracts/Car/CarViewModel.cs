using CarManagment.Application.Contracts.CarCateory;

namespace CarManagment.Application.Contracts.Car
{
    public class CarViewModel
    {
        public long Id { get; set; }
        public string CarName { get; set; }
        public string ProducingCountry { get; set; }
        public string BodyClass { get; set; }
        public string EngineVolume { get; set; }
        public int Cylinders { get; set; }
        public string MaximumOutputPower { get; set; }
        public string TypeOfGearbox { get; set; }
        public string CombinedFuelConsumption { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public long CarCategoryId { get; set; }
    }
}
