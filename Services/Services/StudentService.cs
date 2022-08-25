using Domain.Models ; 
namespace Services.Services
{
    public class StudentService
    {
    List<Student> students = new List<Student>(); 
     public List<Student> GetStudents() 
     {
        return students;
     }
     public void AddStudent(Student student)
     {
        students.Add(student) ; 
     } 
      public void Updait(Student student , int Id)
     {
        for(int i = 0 ; i < students.ToArray().Length ; i ++)
        { 
            if( students[i].Id == Id )
            {
                students[i] = student ; 
                break ; 
            }
        }
     } 
       public Student GetStudentById(int Id)
     {
        Student student = new Student() ;   
        for(int i = 0 ; i < students.ToArray().Length ; i ++)
        { 
            if( students[i].Id == Id )
            {
                student = students[i] ; 
            }
        }
        return student ; 
     }
        public void DeleteStudent(int Id)
     {   
        for(int i = 0 ; i < students.ToArray().Length ; i ++)
        { 
            if( students[i].Id == Id )
            {
                students.RemoveAt(i) ;  
            }
        }
     }
    public int CountStudents()
     {
        return students.Count() ; 
     }
    }
}