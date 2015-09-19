using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penyia.Models
{
    public class Channel
    {
        public int ChannelID { get; set; }

        // Foreign key 
        public int UserID { get; set; }

        // Navigation properties 
        public virtual User Owner { get; set; }

        public virtual ICollection<Message> ChannelMessages { get; set; } 

    }
}