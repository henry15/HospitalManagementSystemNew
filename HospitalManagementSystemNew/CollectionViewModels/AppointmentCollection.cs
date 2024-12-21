using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HospitalManagementSystemNew.Models;

namespace HospitalManagementSystemNew.CollectionViewModels
{
    public class AppointmentCollection
    {
        public Appointment Appointment { get; set; }
        public IEnumerable<Patient> Patients { get; set; }
        public IEnumerable<Doctor> Doctors { get; set; }
    }
}