using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager
    {

        public void Add(Category category)
        {
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Add(category);

        }

        public void Update(Category category)
        {
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Update(category);
        }

        public void Delete(Category category)
        {
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Delete(category);
        }

        public void courseAdd(Course course)
        {
            AdoNetCourseDal courseDal = new AdoNetCourseDal();
            courseDal.Add(course);

        }

        public void courseUpdate(Course course)
        {
            AdoNetCourseDal courseDal = new AdoNetCourseDal();
            courseDal.Update(course);
        }

        public void courseDelete(Course course)
        {
            AdoNetCourseDal courseDal = new AdoNetCourseDal();
            courseDal.Delete(course);
        }


    }
}