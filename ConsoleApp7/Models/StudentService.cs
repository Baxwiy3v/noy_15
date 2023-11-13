using ConsoleApp7.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal class StudentService
    {
        private static APPDpContext _context = new APPDpContext();


        public List<Student> GetAll()
        {
            return _context.Students.ToList();
        }


        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public void Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            Student student = GetById(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
        }

    }
}
