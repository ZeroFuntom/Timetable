using System.Data.Entity;

namespace Timetable.Domain.Model
{
    public interface ITimetableContext
    {
        DbSet<Lesson> Lessons { get; set; }
        int SaveChanges();
    }
}
