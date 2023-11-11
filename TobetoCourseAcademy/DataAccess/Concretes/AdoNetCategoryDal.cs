using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataAccess.Concretes
{
    public class AdoNetCategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine("Ado .Net ile veri tabanına kaydedildi");
        }

        public void Update(Category category)
        {
            Console.WriteLine("Ado .Net ile veri tabanı güncellendi");
        }

        public void Delete(Category category)
        {
            Console.WriteLine("Ado .Net ile veri tabanından silindi");
        }

    }
    public class AdoNetCourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine("Ado .Net ile Course Eklendi");
        }

        public void Update(Course course)
        {
            Console.WriteLine("Ado .Net ile Course Güncellendi");
        }

        public void Delete(Course course)
        {
            Console.WriteLine("Ado .Net ile Course silindi");
        }
    }


}