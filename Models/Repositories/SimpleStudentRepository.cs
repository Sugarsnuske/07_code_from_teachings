using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
//using ConsoleApplication.Models.Repositories;

namespace ConsoleApplication.Models.Repositories{
    public class SimpleStudentRepository : IStudentRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}