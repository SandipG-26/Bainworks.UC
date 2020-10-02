using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Brainworks.UC.Data
{
    public class UCcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = "Server=DESKTOP-6N1BUO9;Database=SQLdatabase;UserId=SG_user;Password=sandip21";
            optionsBuilder.UseSqlServer(connectionstring);
        }
    }
}
