using SchoolApp.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolApp.Domain.Interfaces
{
    public interface IPerson
    {
        public Cpf Cpf { get; set; }
        public Email Email { get; set; }
        public string Registration { get; set; }
        public string Name { get; set; }
    }
}
