﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_DAL.Models
{
    [Table("Persons", Schema = "dbó")]
   public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "UserPassword")]
        public string UserPassword { get; set; }

        [Required]
        [Display(Name = "UserEmail")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "CreatedOn")]
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        [Display(Name = "IsDeleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
