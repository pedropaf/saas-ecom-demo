namespace MySaasProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSaasEcom113 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Invoices", "Tax", c => c.Int());
            AddColumn("dbo.Invoices", "TaxPercent", c => c.Decimal(precision: 18, scale: 2));
            AddColumn("dbo.Invoices", "BillingAddress_Name", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_AddressLine1", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_AddressLine2", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_City", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_State", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_ZipCode", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_Country", c => c.String());
            AddColumn("dbo.Invoices", "BillingAddress_Vat", c => c.String());
            AddColumn("dbo.Invoices", "Description", c => c.String());
            AddColumn("dbo.Invoices", "StatementDescriptor", c => c.String());
            AddColumn("dbo.Invoices", "ReceiptNumber", c => c.String());
            AddColumn("dbo.Invoices", "Forgiven", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "RegistrationDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "LastLoginTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "Delinquent", c => c.Boolean(nullable: false));
            AddColumn("dbo.AspNetUsers", "LifetimeValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Subscriptions", "TaxPercent", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Subscriptions", "ReasonToCancel", c => c.String());
            AddColumn("dbo.LineItems", "Plan_StatementDescriptor", c => c.String());
            DropColumn("dbo.CreditCards", "StripeToken");
            DropColumn("dbo.Invoices", "Charge");
            DropColumn("dbo.Invoices", "Discount");
            DropColumn("dbo.AspNetUsers", "Address");
            DropColumn("dbo.AspNetUsers", "City");
            DropColumn("dbo.AspNetUsers", "CreatedAt");
            DropColumn("dbo.LineItems", "Plan_StatementDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LineItems", "Plan_StatementDescription", c => c.String());
            AddColumn("dbo.AspNetUsers", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.AspNetUsers", "City", c => c.String());
            AddColumn("dbo.AspNetUsers", "Address", c => c.String());
            AddColumn("dbo.Invoices", "Discount", c => c.Int());
            AddColumn("dbo.Invoices", "Charge", c => c.Int());
            AddColumn("dbo.CreditCards", "StripeToken", c => c.String());
            DropColumn("dbo.LineItems", "Plan_StatementDescriptor");
            DropColumn("dbo.Subscriptions", "ReasonToCancel");
            DropColumn("dbo.Subscriptions", "TaxPercent");
            DropColumn("dbo.AspNetUsers", "LifetimeValue");
            DropColumn("dbo.AspNetUsers", "Delinquent");
            DropColumn("dbo.AspNetUsers", "LastLoginTime");
            DropColumn("dbo.AspNetUsers", "RegistrationDate");
            DropColumn("dbo.Invoices", "Forgiven");
            DropColumn("dbo.Invoices", "ReceiptNumber");
            DropColumn("dbo.Invoices", "StatementDescriptor");
            DropColumn("dbo.Invoices", "Description");
            DropColumn("dbo.Invoices", "BillingAddress_Vat");
            DropColumn("dbo.Invoices", "BillingAddress_Country");
            DropColumn("dbo.Invoices", "BillingAddress_ZipCode");
            DropColumn("dbo.Invoices", "BillingAddress_State");
            DropColumn("dbo.Invoices", "BillingAddress_City");
            DropColumn("dbo.Invoices", "BillingAddress_AddressLine2");
            DropColumn("dbo.Invoices", "BillingAddress_AddressLine1");
            DropColumn("dbo.Invoices", "BillingAddress_Name");
            DropColumn("dbo.Invoices", "TaxPercent");
            DropColumn("dbo.Invoices", "Tax");
        }
    }
}
