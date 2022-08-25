using Domain.Models ; 
namespace Services.Services;

public class TeacherService
{
    List<Teachers> teachers = new List<Teachers>();
    public List<Teachers> GetTeachers() 
     {
        return teachers;
     }
     public void AddTeachers(Teachers teacher)
     {
        teachers.Add(teacher) ; 
     } 
      public void Updait(Teachers teacher , int Id)
     {
        for(int i = 0 ; i < teachers.ToArray().Length ; i ++)
        { 
            if( teachers[i].Id == Id )
            {
                teachers[i] = teacher ; 
                break ; 
            }
        }
     } 
       public Teachers GetTeacherById(int Id)
     {
        Teachers teacher = new Teachers() ;   
        for(int i = 0 ; i < teachers.ToArray().Length ; i ++)
        { 
            if( teachers[i].Id == Id )
            {
                teacher = teachers[i] ; 
            }
        }
        return teacher ; 
     }
        public void DeleteTeacher(int Id)
     {   
        for(int i = 0 ; i < teachers.ToArray().Length ; i ++)
        { 
            if( teachers[i].Id == Id )
            {
                teachers.RemoveAt(i) ;  
            }
        }
     }
    public int CountStudents()
     {
        return teachers.Count() ; 
     }
    }

