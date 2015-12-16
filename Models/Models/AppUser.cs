﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Models.Models
{
    public class AppUser : IdentityUser
    {
        public virtual UserData UserData { get; set; }
        public virtual Profile Profile { get; set; }
    }
}