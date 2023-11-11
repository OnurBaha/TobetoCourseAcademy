using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Course
    {
        public int Id;
        public string Title;
        public string Description;
        public string Teacher;
        public string Price;
        public string ImagePath;

        public Course(int id, string title, string description, string teacher, string price, string imagePath)
        {
            Id = id;
            Title = title;
            Description = description;
            Teacher = teacher;
            Price = price;
            ImagePath = imagePath;
        }
    }
}