using System;

namespace ServiceApp.Models
{
    public class StudentModel
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string About { get; set; }
        public bool isDeleted { get; set; } = false;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
    }
}