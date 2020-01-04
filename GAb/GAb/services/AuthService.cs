using GAb.models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GAb.services
{
	class Authservice
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
    }
}
