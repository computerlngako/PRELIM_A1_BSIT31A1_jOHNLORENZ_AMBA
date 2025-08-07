using System;

namespace PRELIM_A1_BSIT31A1_jOHNLORENZ_AMBA.Models
{
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Student
    {
        private string firstName;
        private string lastName;

        public string FirstName => firstName;
        public string LastName => lastName;

        public string Title { get; set; }
        public string Course { get; set; }
        public string Section { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; private set; } = Gender.Unknown;

        // Computed Properties
        public string FullName => $"{Title} {FirstName} {LastName}";
        public int Age
        {
            get
            {
                var today = DateTime.Today;
                int age = today.Year - Birthday.Year;
                if (Birthday > today.AddYears(-age)) age--;
                return age;
            }
        }

        // Constructors
        public Student()
        {
            Title = "Mr./Ms.";
            firstName = "Default";
            lastName = "Student";
            Course = "BSIT";
            Section = "Unknown";
            Birthday = DateTime.Today;
        }

        public Student(string firstName, string lastName)
        {
            SetFirstName(firstName);
            SetLastName(lastName);
        }

        // Methods to set data
        public void SetFirstName(string fname) => firstName = fname;
        public void SetLastName(string lname) => lastName = lname;
        public void SetGender(Gender gender) => Gender = gender;
    }
}
