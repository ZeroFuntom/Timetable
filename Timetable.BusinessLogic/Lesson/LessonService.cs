using System.Collections.Generic;
using System.Linq;
using Timetable.Domain.Services;

namespace Timetable.BusinessLogic.Lesson
{
    public class LessonService : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonService(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }


        public IEnumerable<Domain.Model.Lesson> GetLessons()
        {
            return _lessonRepository.GetAll().OrderBy(lesson => lesson.LessonName);
        }

        public void CreateLesson(Domain.Model.Lesson lesson)
        {
            _lessonRepository.CreateLesson(lesson);
        }
    }
}
