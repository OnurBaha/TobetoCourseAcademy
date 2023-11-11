using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class PurchasedCourse
    {
        public int Id;
        public int StudentId;
        public int CourseId;
        public int CourseProgress;

        public PurchasedCourse(int id, int studentId, int courseId, int courseProgress)
        {
            Id = id;
            StudentId = studentId;
            CourseId = courseId;
            CourseProgress = courseProgress;
        }
    }
}