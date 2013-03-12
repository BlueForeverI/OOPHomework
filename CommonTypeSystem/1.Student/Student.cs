using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.Student
{
    /// <summary>
    /// Enumeration to hold information about universities
    /// </summary>
    public enum University
    {
        SofiaUniversity,
        UNNS,
        TUSofia,
        AmericanUniversity,
        MIT
    }

    /// <summary>
    /// Enumeration to hold information about faculties
    /// </summary>
    public enum Faculty
    {
        MathsAndInformatics,
        Economics,
        Administration,
        Law,
        Physics
    }

    /// <summary>
    /// Enumeration to hold information about specialties
    /// </summary>
    public enum Specialty
    {
        SoftwareEngineering,
        ComputerScience,
        ComputerSystems,
        BusinessAdministration,
        PublicAdministration,
        ForeignEconomics
    }

    /// <summary>
    /// Class that holds information about a student.
    /// </summary>
    class Student : ICloneable, IComparable<Student>
    {
        // public properties
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddress { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public Specialty Specialty { get; set; }
        public Faculty Faculty { get; set; }
        public University University { get; set; }

        // default constructor
        public Student()
        {
        }

        // constructor with property initializers
        public Student(string firstName, string middleName, string lastName,
            string ssn, string permananeAddress = "", string mobilePhone = "", string email = "",
            string course = "", Specialty specialty = Specialty.SoftwareEngineering, 
            Faculty faculty = Faculty.MathsAndInformatics,
            University university = University.SofiaUniversity)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddress = permananeAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Faculty = faculty;
            this.Specialty = specialty;
            this.University = university;
        }

        /// <summary>
        /// Ovverriding the default Equals method
        /// </summary>
        /// <param name="obj">Other object to test </param>
        /// <returns>Whether the two objects are equal</returns>
        public override bool Equals(object obj)
        {
            Student student = (Student) obj;

            if(this.FirstName == student.FirstName && this.MiddleName == student.MiddleName
                && this.LastName == student.LastName && this.SSN == student.SSN
                && this.PermanentAddress == student.PermanentAddress
                && this.MobilePhone == student.MobilePhone 
                && this.Email == student.Email && this.Course == student.Course
                && this.Faculty == student.Faculty && this.Specialty == student.Specialty
                && this.University == student.University)
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Overrides the default ToString method
        /// </summary>
        /// <returns>
        /// String representation of the students, with all properties displayed
        /// </returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("First Name: " + this.FirstName);
            sb.AppendLine("Middle Name: " + this.MiddleName);
            sb.AppendLine("Last Name: " + this.LastName);
            sb.AppendLine("SSN: " + this.SSN);
            sb.AppendLine("Permanend Address: " + this.PermanentAddress);
            sb.AppendLine("Mobile Phone: " + this.MobilePhone);
            sb.AppendLine("Email: " + this.Email);
            sb.AppendLine("Course: " + this.Course);
            sb.AppendLine("Specialty: " + this.Specialty);
            sb.AppendLine("Faculty: " + this.Faculty);
            sb.AppendLine("University: " + this.University);

            return sb.ToString();
        }

        /// <summary>
        /// Overrides the default GetHashCode method
        /// </summary>
        /// <returns>
        /// Hash code of the summ of all of the properties' hashcodes (smart, huh?)
        /// </returns>
        public override int GetHashCode()
        {
            return (
                this.FirstName.GetHashCode() +
                this.MiddleName.GetHashCode() +
                this.LastName.GetHashCode() +
                this.SSN.GetHashCode() +
                this.PermanentAddress.GetHashCode() +
                this.MobilePhone.GetHashCode() +
                this.Email.GetHashCode() +
                this.Course.GetHashCode() +
                this.Specialty.GetHashCode() +
                this.Faculty.GetHashCode() +
                this.University.GetHashCode() 
            ).GetHashCode();
        }

        /// <summary>
        /// Implements the comparison operator
        /// </summary>
        /// <param name="student1">First student</param>
        /// <param name="student2">Second student</param>
        /// <returns>Whether the two students are equal</returns>
        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        /// <summary>
        /// Implements the 'not equal' operator
        /// </summary>
        /// <param name="student1">First student</param>
        /// <param name="student2">Second student</param>
        /// <returns>Whether the students are NOT equal</returns>
        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }

        /// <summary>
        /// Implements the Clone method of the IClonableable
        /// </summary>
        /// <returns>A new Student object with the same properties</returns>
        public object Clone()
        {
            return new Student(
                this.FirstName, this.MiddleName, this.LastName,
                this.SSN, this.PermanentAddress, this.MobilePhone,
                this.Email, this.Course, this.Specialty, this.Faculty,
                this.University);
        }

        /// <summary>
        /// Compares the current student with another one
        /// </summary>
        /// <param name="other">The other student to compare to</param>
        /// <returns>
        ///  1 if the first student is "bigger" than the other,
        ///  0 if they are equal and 
        /// -1 otherwise
        /// </returns>
        public int CompareTo(Student other)
        {
            string fullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = other.FirstName + other.MiddleName + other.LastName;

            int result = fullName.CompareTo(otherFullName);

            if (result == 0)
            {
                return other.SSN.CompareTo(this.SSN);
            }

            return result;
        }
    }
}
