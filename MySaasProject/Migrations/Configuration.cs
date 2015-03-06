using SaasEcom.Core.Models;

namespace MySaasProject.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MySaasProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MySaasProject.Models.ApplicationDbContext";
        }

        protected override void Seed(MySaasProject.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.SubscriptionPlans.AddOrUpdate(
                sp => sp.Id,
                new SubscriptionPlan
                {
                    Id = "premium",
                    Name = "Premium",
                    Interval = SubscriptionPlan.SubscriptionInterval.Monthly,
                    TrialPeriodInDays = 30,
                    Price = 29.00,
                    Currency = "GBP"
                });
        }
    }
}
