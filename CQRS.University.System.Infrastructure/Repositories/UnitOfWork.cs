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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public IStudentRepository StudentRepository { get; private set; }
        public ICourseRepository CourseRepository { get; private set; }
        public IDepartmentRepository DepartmentRepository { get; private set; }


        public UnitOfWork(AppDbContext context,
            IStudentRepository studentRepository, 
            ICourseRepository courseRepository, 
            IDepartmentRepository departmentRepository)
        {
            _context = context;
            StudentRepository = studentRepository;
            CourseRepository = courseRepository;
            DepartmentRepository = departmentRepository;
        }


        public async Task<int> SaveChangesAsync(CancellationToken token)
        {
            return await _context.SaveChangesAsync(token);
        }


        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
