/*using System;
using System.Data.SQLite;
using System.IO;
using ServiceStack.DataAnnotations;
//using ServiceStack.OrmLite;


namespace ToDo.DataAccess.Models
{
    [Alias("categories")]
    internal class Category
    {
        [PrimaryKey]
        [AutoIncrement]
        public int Id { get; set; }
        public string CategoryName { get; set; } = string.Empty;


        //METHODS
        public static Category GetCategoryByName(string name)
        {
            return DbContext.GetInstance()
                .Single<Category>(r => r.CategoryName.ToLower().Trim() == name.ToLower().Trim());
        }
    }
}
*/