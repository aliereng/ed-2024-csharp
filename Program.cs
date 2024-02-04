
using intro.Entities;
using intro.Business;
CourseManager courseManager = new CourseManager();
Course[] courses = courseManager.GetAll();
foreach (var course in courses)
{
    Console.WriteLine($"{course.Id} - {course.Name}");    
}