﻿using DGSappSem2.Models.Staffs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DGSappSem2.Models.Subject
{
    public class Course_Material
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "Enter coursematerial id")]
        [Display(Name = " course material Id Number: ")]
        public int CourseMaterialID { get; set; }


        [Required(ErrorMessage = "Enter course title")]
        [Display(Name = "title: ")]
        [StringLength(50, ErrorMessage = "Title name cannot be longer than 50 characters.")]
        public string title { get; set; }

        public int SubjectID { get; set; }
        public _Subject Subjects { get; set; }

        public int StaffId { get; set; }
        public Staff Staffs { get; set; }

    }
}