using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem
{
    public class CategoriesSetup
    {
        public List<Categories> categoriesList = new List<Categories>();
        public Categories Electronics = new Categories("Electronics", "Devices and gadgets like smartphones, laptops, and cameras.");
        public Categories Clothing = new Categories("Clothing", "Apparel items including shirts, pants, and accessories.");
        public Categories HomeAppliances = new Categories("Home Appliances", "Household appliances like refrigerators, microwaves, and washing machines.");
        public Categories Books = new("Books", "Various genres of books, including fiction, non-fiction, and academic.");
        public Categories SportsAndFitness = new Categories("Sports & Fitness", "Equipment and accessories for sports and fitness activities.");
        public Categories Groceries = new Categories("Groceries", "Everyday items including food, beverages, and household essentials.");
        public Categories HealthAndBeauty = new Categories("Health & Beauty", "Products for personal care, wellness, and beauty.");
        public Categories ToysAndGames = new Categories("Toys & Games", "Children’s toys and games for all ages.");
        public Categories Automotive = new Categories("Automotive", "Automobile accessories and car care products.");
        
       
        public void AddCategoriesToList()
        {
            categoriesList.Add(Electronics);   
            categoriesList.Add(Clothing);   
            categoriesList.Add(HomeAppliances);   
            categoriesList.Add(Books);   
            categoriesList.Add(SportsAndFitness);   
            categoriesList.Add(Groceries);   
            categoriesList.Add(HealthAndBeauty);   
            categoriesList.Add(ToysAndGames);   
            categoriesList.Add(Automotive);   

        }

        public void insertIntoCategories(SqlConnection sqlConnection)
        {
            var insertQuery = "INSERT INTO dbo.Categories(Name,Description) Values(@Name,@Description)";

            foreach(var category in categoriesList)
            {
                sqlConnection.Execute(insertQuery,category);
            }
        }
    }
}
