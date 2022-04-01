using SchoolApp.Domain.Entities;
using SchoolApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Domain.Factories
{
    public class StudentBuilder
    {
        private Student _student { get; set; }

        public StudentBuilder Create(string cpf, string email, string name, string registration)
        {
            _student = new Student
            (
                new Cpf(cpf),
                new Email(email),
                name,
                registration
            );
            return this;
        }

        public StudentBuilder AddCourse(Course course)
        {
            _student.Course = course;
            return this;
        }

        public Student Build()
        {
            return _student;
        }
    }
}
