using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penyia.Models
{
    public class DirectMessage : Message
    {
        // Navigation properties 
        public virtual User Sender { get; set; }
        
        public virtual User Receiver { get; set; }
       
    }
}



 

 
   