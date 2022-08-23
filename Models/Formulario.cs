using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace webapp.Models
{
    public class Formulario
    {
        [Display(Name = "First Name", Prompt ="Enter first name")]
        public string? Name {get; set; }

        [Display(Name = "Last name", Prompt ="Enter last name")]
        public string? Surname {get; set; }

        [Display(Name = "Job title", Prompt ="Enter your job title")]
        public string? Profession {get; set; }

        [Display(Name = "Highest level of education")]
        public string? Education {get; set; }


        [Display(Name = "Sex")]
        public string? Sex {get; set; }

        [Display(Name = "Years of experience")]
        public string? Experience {get; set; }

        [Display(Name = "Date")]
        public DateTime? Date  {get; set; }
    }
}