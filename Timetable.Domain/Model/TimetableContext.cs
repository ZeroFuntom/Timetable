using System;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace Timetable.Domain.Model
{
    public partial class TimetableEntities : ITimetableContext
    {
        public Type ProviderType { get; } = typeof(SqlProviderServices);
    }
}
