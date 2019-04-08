namespace WeeklyMealGeneratorV2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fruits",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        NumberOfTimesPicked = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingLists",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FoodType = c.String(),
                        AveragePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MiscItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        MiscItemId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MiscItemTypes", t => t.MiscItemId, cascadeDelete: true)
                .Index(t => t.MiscItemId);
            
            CreateTable(
                "dbo.MiscItemTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ShoppingListFruits",
                c => new
                    {
                        ShoppingList_Id = c.Int(nullable: false),
                        Fruit_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ShoppingList_Id, t.Fruit_Id })
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingList_Id, cascadeDelete: true)
                .ForeignKey("dbo.Fruits", t => t.Fruit_Id, cascadeDelete: true)
                .Index(t => t.ShoppingList_Id)
                .Index(t => t.Fruit_Id);
            
            CreateTable(
                "dbo.IngredientMeals",
                c => new
                    {
                        Ingredient_Id = c.Int(nullable: false),
                        Meal_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingredient_Id, t.Meal_Id })
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Meals", t => t.Meal_Id, cascadeDelete: true)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Meal_Id);
            
            CreateTable(
                "dbo.MealShoppingLists",
                c => new
                    {
                        Meal_Id = c.Int(nullable: false),
                        ShoppingList_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Meal_Id, t.ShoppingList_Id })
                .ForeignKey("dbo.Meals", t => t.Meal_Id, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingList_Id, cascadeDelete: true)
                .Index(t => t.Meal_Id)
                .Index(t => t.ShoppingList_Id);
            
            CreateTable(
                "dbo.MiscItemShoppingLists",
                c => new
                    {
                        MiscItem_Id = c.Int(nullable: false),
                        ShoppingList_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MiscItem_Id, t.ShoppingList_Id })
                .ForeignKey("dbo.MiscItems", t => t.MiscItem_Id, cascadeDelete: true)
                .ForeignKey("dbo.ShoppingLists", t => t.ShoppingList_Id, cascadeDelete: true)
                .Index(t => t.MiscItem_Id)
                .Index(t => t.ShoppingList_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MiscItemShoppingLists", "ShoppingList_Id", "dbo.ShoppingLists");
            DropForeignKey("dbo.MiscItemShoppingLists", "MiscItem_Id", "dbo.MiscItems");
            DropForeignKey("dbo.MiscItems", "MiscItemId", "dbo.MiscItemTypes");
            DropForeignKey("dbo.MealShoppingLists", "ShoppingList_Id", "dbo.ShoppingLists");
            DropForeignKey("dbo.MealShoppingLists", "Meal_Id", "dbo.Meals");
            DropForeignKey("dbo.IngredientMeals", "Meal_Id", "dbo.Meals");
            DropForeignKey("dbo.IngredientMeals", "Ingredient_Id", "dbo.Ingredients");
            DropForeignKey("dbo.ShoppingListFruits", "Fruit_Id", "dbo.Fruits");
            DropForeignKey("dbo.ShoppingListFruits", "ShoppingList_Id", "dbo.ShoppingLists");
            DropIndex("dbo.MiscItemShoppingLists", new[] { "ShoppingList_Id" });
            DropIndex("dbo.MiscItemShoppingLists", new[] { "MiscItem_Id" });
            DropIndex("dbo.MealShoppingLists", new[] { "ShoppingList_Id" });
            DropIndex("dbo.MealShoppingLists", new[] { "Meal_Id" });
            DropIndex("dbo.IngredientMeals", new[] { "Meal_Id" });
            DropIndex("dbo.IngredientMeals", new[] { "Ingredient_Id" });
            DropIndex("dbo.ShoppingListFruits", new[] { "Fruit_Id" });
            DropIndex("dbo.ShoppingListFruits", new[] { "ShoppingList_Id" });
            DropIndex("dbo.MiscItems", new[] { "MiscItemId" });
            DropTable("dbo.MiscItemShoppingLists");
            DropTable("dbo.MealShoppingLists");
            DropTable("dbo.IngredientMeals");
            DropTable("dbo.ShoppingListFruits");
            DropTable("dbo.MiscItemTypes");
            DropTable("dbo.MiscItems");
            DropTable("dbo.Ingredients");
            DropTable("dbo.Meals");
            DropTable("dbo.ShoppingLists");
            DropTable("dbo.Fruits");
        }
    }
}
