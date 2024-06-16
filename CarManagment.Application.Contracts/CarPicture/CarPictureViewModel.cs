namespace CarManagment.Application.Contracts.CarPicture
{
    public class CarPictureViewModel
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public long CarId { get; set; }
        public bool IsRemoved { get; set; }
        public string Car { get; set; }
    }
}
