using CarManagment.Application.Contracts.Car;
using CarManagment.Domain.CarAgg;

namespace CarManagment.Domain.CategoryAgg
{
    public class CarCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public DateTime CreationDate { get; set; }
        public string Keywords { get; set; }
        public string MetaDescription { get; set; }
        public string Slug { get; set; }
        public List<Car> Cars { get; set; }

        public CarCategory(string name, string description, string picture, string pictureAlt, string pictureTitle,
            string keywords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            CreationDate = DateTime.Now;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }

        public void Edit(string name, string description, string picture, string pictureAlt, string pictureTitle,
            string keywords, string metaDescription, string slug)
        {
            Name = name;
            Description = description;
            Picture = picture;
            PictureAlt = pictureAlt;
            PictureTitle = pictureTitle;
            Keywords = keywords;
            MetaDescription = metaDescription;
            Slug = slug;
        }
    }
}
