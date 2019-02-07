using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetable.Domain.Model;

namespace Timetable.Domain.Services
{
    public class LessonRepository : ILessonRepository
    {
        private readonly ITimetableContext _timetableContext;

        public IQueryable<Lesson> GetAll()
        {
            return _timetableContext.Lessons;
        }

        public void CreateLesson(Lesson lesson)
        {
            throw new NotImplementedException();
        }
    }
}
