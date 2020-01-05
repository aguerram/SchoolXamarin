using GAb.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAb.services
{
	class AuthService
	{
		private dao.TeacherDAO teacherDAO = new dao.TeacherDAO();
		public async Task<bool> checkCredentials(String username,String password)
		{
			bool ok = false;

			Teacher teacher = new Teacher(username,password);
			Teacher res = await teacherDAO.LoginAsync(teacher);

			ok =  res != null ? true:false;

			return ok;
		}

        private async Task<bool> findByUsername(String username)
        {
            bool ok = false;
            Teacher res = await teacherDAO.GetByUsernameAsync(username);

            ok = res != null ? true : false;

            return ok;
        }
        public async Task<Teacher> getCurrentTeacher(String username, String password)
        {
            bool ok = false;
            Teacher teacher = new Teacher(username, password);
            Teacher res = await teacherDAO.LoginAsync(teacher);
            return res;
        }

        public async Task<bool> createTeacher(String username, String password)
        {
            bool ok = false;
            bool exists = await findByUsername(username);
            if (exists) {
               return false;
            }
            int addedSuccussefully = await teacherDAO.SaveAsync(new Teacher(username, password));
            if (addedSuccussefully > 0)
            {
                return true;
            }
              
            return false;
        }
    }
}
