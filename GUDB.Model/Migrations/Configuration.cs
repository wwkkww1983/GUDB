namespace GUDB.Model.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GUDB.Model.GUDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//�κ�Model Class���޸Č���ֱ�Ӹ���DB
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(GUDB.Model.GUDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
