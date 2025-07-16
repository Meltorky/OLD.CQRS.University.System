using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.University.System.Application.Interfaces;
using CQRS.University.System.Domain.Entities;
using CQRS.University.System.Infrastructure.Data;

namespace CQRS.University.System.Infrastructure.Repositories
{
    public class CourseRepository : BaseRepository<Course> , ICourseRepository
    {
        private readonly AppDbContext _context;
        public CourseRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
