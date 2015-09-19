using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Penyia.Models
{
    public class Message
    {
        // primary key
        public int MessageID { get; set; }

        public DateTime TimeStamp { get; set; }

        public String Text { get; set; }

        // navigation property
        public virtual ICollection<Attachment> Attachments { get; set; }

    }
}