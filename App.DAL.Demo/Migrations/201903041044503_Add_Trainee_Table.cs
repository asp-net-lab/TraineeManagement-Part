namespace App.DAL.Context.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Trainee_Table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Trainees",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Trainees");
        }
    }
}
