using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penyia.Models
{
    public class ChannelMessage : Message
    {
        // Foreign key 
        public int ChannelID { get; set; }

        // Navigation properties 
        public virtual Channel Channel { get; set; }

    }
}