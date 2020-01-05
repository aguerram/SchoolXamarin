using System;
using System.Threading.Tasks;
using GAb.dao;
using GAb.models;

namespace GAb.services
{
    class LessonService
    {
		LessonDAO lessonDAO;
        public LessonService()
        {
			lessonDAO = new LessonDAO();
        }
        public async Task<bool> AddLessonToDB(Lesson lesson)
        {
            int added = await lessonDAO.SaveAsync(lesson);
            if (added > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
