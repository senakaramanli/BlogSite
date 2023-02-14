namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writertitles : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterPasswordt", c => c.String(maxLength: 200));
            AddColumn("dbo.Writers", "WriterTitles", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "WriterPassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "WriterTitles");
            DropColumn("dbo.Writers", "WriterPasswordt");
        }
    }
}
