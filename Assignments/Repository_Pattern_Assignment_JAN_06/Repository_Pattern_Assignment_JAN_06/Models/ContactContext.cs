using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace Repository_Pattern_Assignment_JAN_06.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("name=connectstr") { }
        public DbSet<Contact> Contacts { get; set; }
    }
}