using System.Collections.Generic;
using Timetable.Domain.Model;

namespace Timetable.BusinessLogic.Lesson
{
    public interface ILessonService
    {
        IEnumerable<Domain.Model.Lesson> GetLessons();
        void CreateLesson(Domain.Model.Lesson lesson);
    }
}
