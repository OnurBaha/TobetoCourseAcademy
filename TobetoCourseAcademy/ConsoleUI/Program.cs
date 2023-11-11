using Business.Concretes;
using Entities.Concretes;

//Category category = new Category();
//category.Id = 1;
//category.Name = "Programlama";

//CategoryManager categoryManager = new CategoryManager();

//categoryManager.Add(category);


Student student = new Student(1, "Ahmet Özkan", "ahmet@gmail.com", "123456", "Ankara", "ahmet.jpg", 1);
Console.WriteLine(student.Id + " " + student.FullName + " " + student.Email + " " + student.Password + " " + student.Address +
    " " + student.ImagePath + " " + student.CourseId);

Teacher teacher = new Teacher(1, "Engin Demiroğ", "engin@gmail.com", "123456", "Diyarbakır", "engin.jpg", 1);
Console.WriteLine("---------------------");
Console.WriteLine(teacher.Id + " " + teacher.FullName + " " + teacher.Email + " " + teacher.Password + " " +
    teacher.Address + " " + teacher.ImagePath + " " + teacher.CourseId);

Course course = new Course(1, "CSharp + Angular", "\n2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
"\nEngin Demiroğ", "Ücretsiz", "CSharp.jpg");
Console.WriteLine("---------------------");
Console.WriteLine(course.Id + " " + course.Title + " " + course.Description + " " + course.Teacher + " " + course.Price + " " + course.ImagePath);

CourseOfTeacher courseOfTeacher = new CourseOfTeacher(1, 1, 1);
Console.WriteLine("---------------------");
Console.WriteLine(courseOfTeacher.Id + " " + courseOfTeacher.CourseId + " " + courseOfTeacher.TeacherId);

Card card = new Card(1, "Visa-1", "1234-5678-9012-3456", "2024", "12", "987");
Console.WriteLine("---------------------");
Console.WriteLine(card.Id + " " + card.CardName + " " + card.CardNumber + " " + card.ExpireYear + " " + card.ExpireMonth + " " + card.Cvc);

Category category = new Category(1, "Tümü");
Console.WriteLine("---------------------");
Console.WriteLine(category.Id + " " + category.CategoryName);

PurchasedCourse purchasedCourse = new PurchasedCourse(1, 1, 1, 47);
Console.WriteLine("---------------------");
Console.WriteLine(purchasedCourse.Id + " " + purchasedCourse.StudentId + " " + purchasedCourse.CourseId + " " + "%" + purchasedCourse.CourseProgress);

UserManager userManager = new UserManager();
userManager.Add(category);
userManager.Update(category);
userManager.Delete(category);

Console.WriteLine("---------------------");

UserManager userManager2 = new UserManager();
userManager2.courseAdd(course);
userManager2.courseUpdate(course);
userManager2.courseDelete(course);