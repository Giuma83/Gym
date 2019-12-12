namespace Gym.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Int(nullable: false, identity: true),
                        NameCourse = c.String(),
                    })
                .PrimaryKey(t => t.CourseId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        NameCustomer = c.String(),
                        SurnameCustomer = c.String(),
                        Age = c.Int(nullable: false),
                        Subscription_SubscriptionId = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Subscriptions", t => t.Subscription_SubscriptionId)
                .Index(t => t.Subscription_SubscriptionId);
            
            CreateTable(
                "dbo.Subscriptions",
                c => new
                    {
                        SubscriptionId = c.Int(nullable: false, identity: true),
                        NameSubscription = c.String(),
                    })
                .PrimaryKey(t => t.SubscriptionId);
            
            CreateTable(
                "dbo.CustomerCourses",
                c => new
                    {
                        Customer_CustomerId = c.Int(nullable: false),
                        Course_CourseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Customer_CustomerId, t.Course_CourseId })
                .ForeignKey("dbo.Customers", t => t.Customer_CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId, cascadeDelete: true)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Course_CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "Subscription_SubscriptionId", "dbo.Subscriptions");
            DropForeignKey("dbo.CustomerCourses", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.CustomerCourses", "Customer_CustomerId", "dbo.Customers");
            DropIndex("dbo.CustomerCourses", new[] { "Course_CourseId" });
            DropIndex("dbo.CustomerCourses", new[] { "Customer_CustomerId" });
            DropIndex("dbo.Customers", new[] { "Subscription_SubscriptionId" });
            DropTable("dbo.CustomerCourses");
            DropTable("dbo.Subscriptions");
            DropTable("dbo.Customers");
            DropTable("dbo.Courses");
        }
    }
}
