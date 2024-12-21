using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagementSystemNew.Models;

namespace HospitalManagementSystemNew.CollectionViewModels
{
    public class DoctorCollection
    {
        public RegisterViewModel ApplicationUser { get; set; }
        public Doctor Doctor { get; set; }
        public IEnumerable<Department> Departments { get; set; }
    }
}