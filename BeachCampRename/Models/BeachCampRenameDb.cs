using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BeachCampRename.Models
{
    public class BeachCampRenameDb : DbContext
    {
        public DbSet<NewName> NewNames { get; set; }
        public BeachCampRenameDb() : base("name=DefaultConnection")
            {

        }

        public static BeachCampRenameDb Create()
        {
            return new BeachCampRenameDb();
        }
    }
}
