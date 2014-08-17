using System;
using System.Text;

public class Student : ICloneable, IComparable<Student>
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public int SSN { get; set; }
    public string Address { get; set; }
    public int PhoneNumber { get; set; }
    public string Email { get; set; }
    public int Course { get; set; }
    public Specialty Specialty { get; set; }
    public University University { get; set; }
    public Faculty Faculty { get; set; }

    public Student(string firstName, string middleName, string lastName,
        int ssn, string address, int phoneNumber, string email, int course,
        University university, Faculty faculty, Specialty specialty)
    {
        this.FirstName = firstName;
        this.MiddleName = middleName;
        this.LastName = lastName;
        this.SSN = ssn;
        this.Address = address;
        this.PhoneNumber = phoneNumber;
        this.Email = email;
        this.Course = course;
        this.University = university;
        this.Faculty = faculty;
        this.Specialty = specialty;
    }

    public override bool Equals(object obj)
    {
        Student student = obj as Student;

        if ((object)student == null)
        {
            return false;
        }

        if (Object.Equals(this.FirstName, student.FirstName)&&
            Object.Equals(this.MiddleName, student.MiddleName)&&
            Object.Equals(this.LastName, student.LastName))
        {
            return true;
        }

        if (!Object.Equals(this.University, student.University))
        {
            return false;
        }

        if (!Object.Equals(this.Faculty, student.Faculty))
        {
            return false;
        }

        if (!Object.Equals(this.Specialty, student.Specialty))
        {
            return false;
        }
        
        if (this.Course != student.Course)
        {
            return false;
        }

        return true;
    }

    public static bool operator ==(Student studentOne, Student studentTwo)
    {
        //the Student class inherits the "Equals" method with two parameters from the Object class
        return Student.Equals(studentOne, studentTwo); 
    }

    public static bool operator !=(Student studentOne, Student studentTwo)
    {
        return !Student.Equals(studentOne, studentTwo);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() ^ MiddleName.GetHashCode() ^
            LastName.GetHashCode() ^ University.GetHashCode() ^
            Faculty.GetHashCode() ^ Specialty.GetHashCode() ^
            Course.GetHashCode();
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();
        result.AppendFormat("First name: {0}\n", this.FirstName);
        result.AppendFormat("Middle name: {0}\n", this.MiddleName);
        result.AppendFormat("Last name: {0}\n", this.LastName);
        result.AppendFormat("SSN: {0}\n", this.SSN);
        result.AppendFormat("Address: {0}\n", this.Address);
        result.AppendFormat("Phone number: {0}\n", this.PhoneNumber);
        result.AppendFormat("Email: {0}\n", this.Email);
        result.AppendFormat("Course: {0}\n", this.Course);
        result.AppendFormat("University: {0}\n", this.University);
        result.AppendFormat("Faculty: {0}\n", this.Faculty);
        result.AppendFormat("Specialty: {0}\n", this.Specialty);

        return result.ToString();
    }

    public Student Clone()
    {
        Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName,
            this.SSN, this.Address, this.PhoneNumber, this.Email, this.Course,
            this.University, this.Faculty, this.Specialty);

        return clonedStudent;
    }

    object ICloneable.Clone() 
    {
        return this.Clone();
    }

    public int CompareTo(Student student)
    {
        if (this.FirstName != student.FirstName)
        {
            return String.Compare(this.FirstName, student.FirstName);
        }
        
        if (this.LastName != this.LastName)
	    {
		    return String.Compare(this.LastName, student.LastName); 
	    }

        if (this.SSN != student.SSN)
	    {
		     return(this.SSN - student.SSN);
	    }
        return 0;
    }
}

