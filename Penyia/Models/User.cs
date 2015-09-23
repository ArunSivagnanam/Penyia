using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Penyia.Models
{

    public enum Status
    {
        Online, 
        Ofline, 
        Busy
    };


    public class User
    {

        // primary key
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        [NotMapped]
        public Status? UserState { get; set; }

        // Navigation property
        public virtual ICollection<Message> MessageHistory { get; set; } 


    }
}