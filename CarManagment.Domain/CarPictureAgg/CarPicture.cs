using CarManagment.Domain.CarAgg;

namespace CarManagment.Domain.CarPictureAgg
{
    public class CarPicture
    {
        public long Id { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public DateTime CreationDate { get; set; }
        public bool IsRemoved { get; set; }
        public long CarId { get; set; }
        public Car Car { get; set; }

        public CarPicture(string picture, string pictureAlt, string pictureTitle, long carId)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CarId = carId;
            IsRemoved = false;
            CreationDate = DateTime.Now;
        }
        public void Edit(string picture, string pictureAlt, string pictureTitle, long carId)
        {
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CarId = carId;
        }
        public void Removed()
        {
            IsRemoved = true;
        }
        public void Restore()
        {
            IsRemoved = false;
        }
    }
}
