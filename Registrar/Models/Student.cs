using System.Collections.Generic;

namespace Registrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string StudentName { get; set; }
    public string DateOfEnrollment { get; set; }
    public List<StudentCourse> JoinEntities { get; }
  }
}