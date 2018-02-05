using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;




namespace CodingClub.Models
{
    [Table ("OfficerDetails")]
    public class Officer
    {
       [Key]
        public string FirstName { get; set;}

        public string LastName{ get; set;}   

        public string position { get; set;}
        public string Duty { get; set;}
    }
}
