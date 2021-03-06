﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GATE.Models;

namespace GATE.ViewModels {

    public class LoginViewModel {
        public string Message { get; set; }

        [Required]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [DataType(dataType: DataType.Password)]
        public string Password { get; set; }

        public bool BePersistence { get; set; }
    }

    public class RegisterStudentViewModel {
        [Required]
        [MaxLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [MaxLength(50)]
        [DisplayName("Nike Name")]
        public string NickName { get; set; }

        [DisplayName("Family Name")]
        [MaxLength(50)]
        [Required(ErrorMessage = "The field Family Name is Required")]
        public string FamilyName { get; set; }

        [Key]
        [DisplayName("National Code")]
        // TODO: Add Regular Expression
        //[RegularExpression("0{1,2}.........",
        //  ErrorMessage = "The national code is not valid, Consider entering the national code without hyphen")]
        public int NationalCode { get; set; }

        [MaxLength(50)]
        [DisplayName("Father's Name")]
        public string FathersName { get; set; }

        // ToDo: Add Regular Expression for Birthday
        [Column(TypeName = "DateTime2")]
        public DateTime Birthday { get; set; }

        [MaxLength(50)]
        [DisplayName("Born In")]
        public string BornCity { get; set; }

        // ToDo: Add Regular Expression for TelephoneNumber
        public int? Telephone { get; set; }

        [RegularExpression("\\d{10}",
            ErrorMessage = "The national code is not valid, Consider entering the Postal Code without hyphen")]
        [DisplayName("Postal Code")]
        public int? PostalCode { get; set; }

        public string Address { get; set; }

        [Range(1, 999)]
        public int? Plaque { get; set; }
    }

    public class RegisterUserViewModel {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [Key]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [Key]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        public string Phone { get; set; }
    }

    public class UserTypeViewModel {
        [Required]
        [DisplayName("User Type")]
        public UserTypes UserTypes { get; set; }
    }

    public class RegisterUserViaManagerViewModel {
        [Required]
        [Key]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [Key]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Key]
        public int Id { get; set; }

        public UserTypes UserTypes { get; set; }

        public string Phone { get; set; }

        public string ErrorMessage { get; set; }
    }

    public class RegisterStaffViaManagerViewModel {
        public Staff Staff { get; set; }
        public UserTypes UserTypes { get; set; }
        //public string Type { get; set; }
        
    }

    public class StudentDetailsViewModel {
        public int Id { get; set; }
        public Student Student { get; set; }

        public IEnumerable<Level> Levels { get; set; }
        [DisplayName("User Name")]
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}