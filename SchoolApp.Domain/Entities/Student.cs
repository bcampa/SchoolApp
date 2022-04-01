using SchoolApp.Domain.ValueObjects;
using System;

namespace SchoolApp.Domain.Entities
{
    public class Student
    {
        public Course Course { get; set; }
        public Cpf Cpf { get; set; }
        public Email Email { get; set; }
        public string Name { get; set; }
        public string Registration { get; set; }

        public Student(Cpf cpf, Email email, string name, string registration)
        {
            Cpf = cpf;
            Email = email;
            Name = name;
            Registration = registration;
        }
    }
}
