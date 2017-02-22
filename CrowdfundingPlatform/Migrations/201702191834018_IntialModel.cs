namespace CrowdfundingPlatform.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AttachmentDtoes",
                c => new
                    {
                        AttachmentId = c.Long(nullable: false, identity: true),
                        CreatedAt = c.DateTime(),
                        FilePath = c.String(),
                        Name = c.String(),
                        HtmlCode = c.String(),
                        OrderNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AttachmentId);
            
            CreateTable(
                "dbo.ProjectCategoryDtoes",
                c => new
                    {
                        CategoryId = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.FundingPackageDtoes",
                c => new
                    {
                        FundingPackageId = c.Long(nullable: false, identity: true),
                        ProjectId = c.Long(nullable: false),
                        AttachmentId = c.Long(),
                        Title = c.String(),
                        PledgeAmount = c.Decimal(precision: 18, scale: 2),
                        Description = c.String(),
                        WhenDateTime = c.DateTime(nullable: false),
                        EstimatedDeliveryDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FundingPackageId);
            
            CreateTable(
                "dbo.ProjectDTOes",
                c => new
                    {
                        ProjectId = c.Long(nullable: false, identity: true),
                        Id = c.Long(nullable: false),
                        CategoryId = c.Long(nullable: false),
                        ProjectCategoryDesc = c.String(),
                        AttachmentId = c.Long(),
                        Title = c.String(),
                        Description = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        UpdatedDate = c.DateTime(nullable: false),
                        FundingEndDate = c.DateTime(nullable: false),
                        FundingGoal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.String(),
                        OwnerName = c.String(),
                        OwnerId = c.Long(),
                        MainPhoto = c.String(),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.ProjectCommentDtoes",
                c => new
                    {
                        CommentId = c.Long(nullable: false, identity: true),
                        ProjectId = c.Long(nullable: false),
                        Name = c.String(),
                        Id = c.Long(nullable: false),
                        AttachmentSetId = c.Long(),
                        WhenDateTime = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CommentId);
            
            CreateTable(
                "dbo.ProjectStatsDtoes",
                c => new
                    {
                        ProjectStatsId = c.Long(nullable: false, identity: true),
                        ProjectId = c.Long(nullable: false),
                        BackersNo = c.Long(nullable: false),
                        MoneyPledged = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SharesNo = c.Int(nullable: false),
                        CommentsNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectStatsId);
            
            CreateTable(
                "dbo.ProjectUpdateDtoes",
                c => new
                    {
                        ProjectUpdateId = c.Long(nullable: false, identity: true),
                        IsDeleted = c.Boolean(nullable: false),
                        ProjectId = c.Long(nullable: false),
                        AttachmentId = c.Long(),
                        Title = c.String(),
                        Description = c.String(),
                        WhenDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectUpdateId);
            
            CreateTable(
                "dbo.UserFundingDTOes",
                c => new
                    {
                        UserFundingId = c.Long(nullable: false, identity: true),
                        FundingPackageId = c.Long(nullable: false),
                        Id = c.Long(nullable: false),
                        Username = c.String(),
                        WhenDateTime = c.DateTime(nullable: false),
                        AmountPaid = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TransactionId = c.String(),
                    })
                .PrimaryKey(t => t.UserFundingId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserFundingDTOes");
            DropTable("dbo.ProjectUpdateDtoes");
            DropTable("dbo.ProjectStatsDtoes");
            DropTable("dbo.ProjectCommentDtoes");
            DropTable("dbo.ProjectDTOes");
            DropTable("dbo.FundingPackageDtoes");
            DropTable("dbo.ProjectCategoryDtoes");
            DropTable("dbo.AttachmentDtoes");
        }
    }
}
