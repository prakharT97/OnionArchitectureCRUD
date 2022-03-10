using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DomainLayer.Model
{
    public class User
    {
        [Key]
        public long userId { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "User Name is required")]
        public string userName { get; set; }
        [DisplayName("Phone number")]
        [Required(ErrorMessage = "Phone number is required")]
        public string userPhone { get; set; }
        [DisplayName("Email ID")]
        [Required(ErrorMessage = "Email id is required")]
        public string userEmailId { get; set; }
        [DisplayName("Street address")]
        [Required(ErrorMessage = "Address is required")]
        public string userAddress { get; set; }
        //public DateTime createDataTime { get; set; }
        //public DateTime updateDateTime { get; set; }
    }
}
