﻿using System;
using System.Collections.Generic;

namespace DMS.DAL.Entities
{
    public partial class Student
    {
        public Student()
        {
            StudentUsers = new HashSet<StudentUser>();
        }

        public int Id { get; set; }
        public string? Picture { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public int Gender { get; set; }
        public DateTime DoB { get; set; }
        public int Age { get; set; }
        public string PrimaryPhoneNumber { get; set; } = null!;
        public string SecondaryPhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Grno { get; set; } = null!;
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual ICollection<StudentUser> StudentUsers { get; set; }
    }
}
