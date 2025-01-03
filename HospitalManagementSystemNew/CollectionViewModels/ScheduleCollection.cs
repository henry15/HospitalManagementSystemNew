﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagementSystemNew.Models;

namespace HospitalManagementSystemNew.CollectionViewModels
{
    public class ScheduleCollection
    {
        public Schedule Schedule { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}