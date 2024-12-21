using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalManagementSystemNew.Models
{
    public class Patient
    {
        public int Id { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
        public string ApplicationUserId { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get; set; }

        [EmailAddress]
        [Display(Name = "Email Id")]
        public string EmailAddress { get; set; }
        [Display(Name = "Phone No")]
        public string PhoneNo { get; set; }
        public string Contact { get; set; }
        [Display(Name = "Blood Group")]
        public string BloodGroup { get; set; }
        public string Gender { get; set; }
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }

        public PatientOPD PaitentOPD { get; set; }
        public List<PatientOPD> PaitentOPDDetails { get; set; }
    }

    public class PatientOPD
    {
        public DateTime? VisitDate { get; set; }
        public string Diagnosis { get; set; }
        public string Prescription { get; set; }
        public double Ht { get; set; }
        public double Wt { get; set; }
    }
}