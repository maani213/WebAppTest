using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.IdentityStuff
{
    public class MyIdentityDbContext : IdentityDbContext<MyIdentityUser>
    {
        public MyIdentityDbContext() : base("connectionstring")
        {
        }
    }
}