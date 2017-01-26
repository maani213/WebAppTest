﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.IdentityStuff
{
    public class MyIdentityUser : IdentityUser
    {
        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }

        public string Bio { get; set; }
    }
}