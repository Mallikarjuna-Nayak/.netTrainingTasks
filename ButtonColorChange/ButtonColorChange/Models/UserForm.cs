using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ButtonColorChange.Models
{
    public class UserForm
    {
        [Required(ErrorMessage = "Please enter Username")]
        [StringLength(100)]
        public string username { get; set; }
        [Required(ErrorMessage = "Please choose Payment type")]
        public string pay_mode { get; set; }
        [Required(ErrorMessage = "Please enter Card number")]
        [Display(Name = "Card Number")]
        [CreditCard]
        public string card_number { get; set; }
    }
    public class ClientUsingCookie
    {
        [Required(ErrorMessage = "Please enter Username")]
        [StringLength(100)]
        public string username { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string address { get; set; }
        [Required(ErrorMessage = "Please enter your dob")]
        public string dob { get; set; }
        [Required(ErrorMessage = "Please enter your Nationality")]
        public string nationality { get; set; }
        [Required(ErrorMessage = "Select your Country")]
        public string country { get; set; }
        [Required(ErrorMessage = "Please enter your Skill set")]
        public string skill { get; set; }
    }
    public class UniqueDigitNumber
    {
        [Required(ErrorMessage = "Please enter 9 digits field")]
        [StringLength(100)]
        public string mobile_number { get; set; }
    }
}
