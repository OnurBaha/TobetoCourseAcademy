using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class CourseOfTeacher
    {
        public int Id;
        public int CourseId;
        public int TeacherId;


        public CourseOfTeacher(int id, int courseId, int teacherId)
        {
            Id = id;
            CourseId = courseId;
            TeacherId = teacherId;
        }

    }

}