using System.Linq;
using Timetable.Domain.Model;

namespace Timetable.Domain.Services
{
    public interface ILessonRepository
    {
        IQueryable<Lesson> GetAll();
        void CreateLesson(Lesson lesson);
    }
}
