using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;


namespace Models
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext():base("BasetPajoohNovin")
        {

        }

        static DataBaseContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DataBaseContext,Models.Migrations.Configuration>());
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Device> devices { get; set; }
        public DbSet<DeviceParameter> deviceParameters { get; set; }
        public DbSet<DeviceAttribute> DeviceAttributes { get; set; }

    }
}
