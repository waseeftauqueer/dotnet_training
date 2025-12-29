using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFIrstDemo
{
    [Table("StudentsTable")]
    public class Student
    {
        [Key] // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // No Identity
        [Required(ErrorMessage = "Please Enter the Student ID")] // Must be inserted with data
        [Column("SId", TypeName = "int")]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "Please Enter the Student Name")]
        [RegularExpression("^[a-zA-Z]+$" ,ErrorMessage = "Only alphabets are allowed")]
        [Column("SName", TypeName = "varchar")]
        [MaxLength(30)]
        public string StudentName { get; set; }

        public DateTime DOBDate { get; set; }

        [Required(ErrorMessage = "Please Enter the Class")]
        [Range(1,12, ErrorMessage = "Please enter inside the range")]
        public int Class {  get; set; }

        [Column("SEmail", TypeName = "varchar")]
        [MaxLength(50)]
        [EmailAddress(ErrorMessage = "Please enter the Email Id")]
        public string Email { get; set; }
    }
}
