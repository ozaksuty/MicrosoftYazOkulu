using SQLite.Net.Attributes;
using System;

namespace yazokulu1.Models
{
    public class Students
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
        public string School { get; set; }
    }
}
