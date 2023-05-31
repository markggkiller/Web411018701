using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web411018701.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    public class StudentMetadata
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "請輸入姓名")]
        [Display(Name = "姓名")]
        [StringLength(10, ErrorMessage = "姓名長度不可超過10個字元")]
        public string Username { get; set; }

        [Required(ErrorMessage = "請輸入學號")]
        [Display(Name = "學號")]
        [StringLength(10, ErrorMessage = "學號長度不可超過10個字元")]
        public string Number { get; set; }

        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "請輸入正確的電子郵件格式")]
        public string Email { get; set; }

        [Required(ErrorMessage = "請選擇是否註冊")]
        [Display(Name = "是否註冊")]
        public bool IsActive { get; set; }
    }

}