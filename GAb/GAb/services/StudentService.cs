using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GAb.dao;
using GAb.models;

namespace GAb.services
{
    class StudentService
    {
        public StudentDAO studentDAO;
        public StudentService()
        {
            studentDAO = new StudentDAO();
        }

        public async Task<bool> saveStudentToDB(Student student)
        {
            int rows = await studentDAO.SaveAsync(student);
            if (rows>0)
            {
                return true;
            }
            return false;
        }
    }
}
