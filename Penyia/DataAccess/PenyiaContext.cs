using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Penyia.Models;

namespace Penyia.DataAccess
{
    public class PenyiaContext : DbContext
    {
        public PenyiaContext()
            : base("PenyiaContext")
        {

        }

        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Channel> Channels { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

        
    }
}