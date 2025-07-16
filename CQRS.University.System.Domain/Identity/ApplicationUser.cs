using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS.University.System.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace CQRS.University.System.Domain.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public int StudentId { get; set; }
        public bool IsStudent => StudentId != 0;
    }
}
