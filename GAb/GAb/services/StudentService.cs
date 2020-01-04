using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GAb.dao;

namespace GAb.services
{
    class StudentService
    {
        public OptionDAO optionDAO;
        public StudentService()
        {
            optionDAO = new OptionDAO();
        }
        public async Task<List<models.Option>> GetOptions()
        {
            return await optionDAO.ListAsync();
        }
    }
}
