using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApplication.Models.Repositories
{
    public interface IStudentRepository
    {
        //Basic CRUD
        IEnumerable<Student> GetAll();
        Student Get(int id);
        void Delete(int id);
        void Update(Student student);
        void Save(Student student);
        
    }
}
