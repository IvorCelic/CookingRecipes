namespace CookingRecipes.Models
{
    public static class CategoriesRepository
    {
        private static List<Category> _categories = new List<Category>()
        {
            new Category { CategoryId = 1, Name = "Meso", Description = "Meso"},
            new Category { CategoryId = 2, Name = "Torte", Description = "Torte"},
            new Category { CategoryId = 3, Name = "Kolači", Description = "Kolači"}
        };

        public static List<Category> GetCategories() => _categories;

    }
}
