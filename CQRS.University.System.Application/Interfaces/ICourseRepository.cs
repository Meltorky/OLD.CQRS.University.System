using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.University.System.Domain.Entities;

namespace CQRS.University.System.Application.Interfaces
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
    }
}
