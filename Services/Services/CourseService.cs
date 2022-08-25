using Domain.Models ; 
namespace Services.Services;

public class CourseService
{
    List<Course> courses = new List<Course>();
     public List<Course> GetCourses() 
     {
        return courses;
     }
     public void AddCourse(Course course)
     {
        courses.Add(course) ; 
     } 
      public void Updait(Course course , int Id)
     {
        for(int i = 0 ; i < courses.ToArray().Length ; i ++)
        { 
            if( courses[i].Id == Id )
            {
                courses[i] = course ; 
                break ; 
            }
        }
     } 
      public Course GetCoursesById(int Id)
     {
        Course course = new Course() ;   
        for(int i = 0 ; i < courses.ToArray().Length ; i ++)
        { 
            if( courses[i].Id == Id )
            {
                course = courses[i] ; 
            }
        }
        return course ; 
     }
       public void DeleteCourses(int Id)
     {   
        for(int i = 0 ; i < courses.ToArray().Length ; i ++)
        { 
            if( courses[i].Id == Id )
            {
                courses.RemoveAt(i) ;  
            }
        }
     }
      public int CountCourses()
     {
        return courses.Count() ; 
     }
}
