using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.School
{
    /// <summary>
    /// Represents a school class
    /// </summary>
    public class Class
    {
        public string Id { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<Student> Students { get; private set; }

        public Class(string textId, List<Teacher> teachers = null, List<Student> students = null)
        {
            this.Id = textId;
            this.Teachers = (teachers == null) ? new List<Teacher>() : teachers;
            this.Students = (students == null) ? new List<Student>() : students;
        }
    }
}
