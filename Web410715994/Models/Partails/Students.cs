using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web410715994.Models
{
    [MetadataType(typeof(StudentMetadate))]
    public partial class Students
    {
    }

    public class StudentMetadate
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="請填寫姓名")]
        [Display(Name = "姓名")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "請輸入5~10個字")]
        public string Name { get; set; }
        [Required(ErrorMessage = "請填寫學號")]
        [Display(Name = "學號")]
        [StringLength(10, MinimumLength = 5, ErrorMessage = "請輸入5~10個字")]
        public string Number { get; set; }
        [Required(ErrorMessage = "請填寫Email")]
        [Display(Name = "Email")]
        [EmailAddress()]
        public string Email { get; set; }

    }
}