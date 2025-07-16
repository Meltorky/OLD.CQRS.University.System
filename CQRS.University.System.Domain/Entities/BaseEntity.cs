﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.University.System.Domain.Entities
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;
    }
}
