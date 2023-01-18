namespace EntityCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryName", c => c.String());
            Sql("Update Categories Set CategoryName=CategoryAd");
            DropColumn("dbo.Categories", "CategoryAd");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryAd", c => c.String());
            Sql("Update Categories Set CategoryAd=CategoryName");
            DropColumn("dbo.Categories", "CategoryName");
        }
    }
}
