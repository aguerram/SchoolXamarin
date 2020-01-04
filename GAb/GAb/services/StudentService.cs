using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GAb.dao;

namespace GAb.services
{
    class StudentService
    {
        StudentDAO studentDAO;
        public StudentService()
        {
            studentDAO = new StudentDAO();
        }
        public Task<List<models.Option>> GetOptions()
        {
            return studentDAO.ListAsync();
        }
    }
}
