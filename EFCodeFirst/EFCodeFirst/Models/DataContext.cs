using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace EFCodeFirst.Models {
    public class DataContext : DbContext {


        public DataContext() {
            Database.SetInitializer( new MyInitializer());
        }


        public DbSet<Movie> Movies { get; set; }

    }
}