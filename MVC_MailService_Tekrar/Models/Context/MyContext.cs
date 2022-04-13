using MVC_MailService_Tekrar.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC_MailService_Tekrar.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        public DbSet<AppUser> AppUsers { get; set; }


    }
}