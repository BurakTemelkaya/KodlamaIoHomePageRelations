// See https://aka.ms/new-console-template for more information


using Business.Abstracts;
using Business.Concretes;
using DataAccess.Concretes;
using Entitities.Concretes;

ICategoryService categoryService = new CategoryService(new CategoryDal());

categoryService.Insert(new Category
{
    Id = 4,
    Name = "Ruby"
});

var category = categoryService.GetById(4);
Console.WriteLine(category.Name);
category.Name = "RUBY";
categoryService.Update(category);
categoryService.List();
categoryService.Delete(category);

ICourseService courseService = new CourseService(new CourseDal());

courseService.Insert(new Course
{
    Id = 3,
    CategoryId = 1,
    InstructorId = 1,
    Name = "Yetiştirme Kursu"
});

var course = courseService.GetById(3);
Console.WriteLine(course.Name);
course.Name = "Yetiştirme Kampı";
courseService.Update(course);
courseService.Delete(course);

IInstructorService instructorService = new InstructorService(new InstructorDal());

instructorService.Insert(new Instructor
{
    Id = 3,
    Email = "engindemirog@mail.com",
    FirstName = "Engin",
    LastName = "Demirog"
});

var instructor = instructorService.GetById(3);
Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
instructor.FirstName = "Test";
instructorService.Update(instructor);
instructorService.Delete(instructor);

//ÖDEV
//Kodlama.io ana sayfasında bulunan Course, Category, Instructor nesnelerini modelleyiniz.
//İlişkileri kurunuz.
//Tüm CRUD operasyonlarını katmanlı yapıda simüle ediniz. Github kodlarınızı paylaşınız.


