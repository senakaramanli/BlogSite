namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_writertitles_1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "WriterPasswordt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Writers", "WriterPasswordt", c => c.String(maxLength: 200));
            DropColumn("dbo.Writers", "WriterPassword");
        }
    }
}
