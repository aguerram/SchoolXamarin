using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GAb.dao;

namespace GAb.services
{
    class StudentService
    {
        public StudentDAO studentDAO;
        public StudentService()
        {
            studentDAO = new StudentDAO();
        }
        public Task<List<models.Student>> GetOptions()
        {
            return studentDAO.ListAsync();
        }
    }
}
