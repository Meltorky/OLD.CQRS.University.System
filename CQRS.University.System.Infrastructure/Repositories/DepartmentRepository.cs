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
    public class DepartmentRepository : BaseRepository<Department>, IDepartmentRepository
    {
        private readonly AppDbContext _context;
        public DepartmentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
