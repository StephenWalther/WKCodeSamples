using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Day4.DomainModel;

namespace Day4.Services.Infrastructure {
    class DataContext : DbContext {

        internal DataContext() {
            //Database.SetInitializer(null);
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
