using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CodingClub.Models
{
    [Table("Memberdetails")] 
    public class Member
    {
        [Key]
        public int UserID { get; set; }

        public string FirstName { get; set;}

        public string LastName{ get; set;}
        
        [DisplayFormat(DataFormatString = "{0: yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }
        
        public string password { get; set; }

       
    }
}