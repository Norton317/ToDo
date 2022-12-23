using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;

namespace ToDo.DataAccess.Models
{
    [Alias("todo_list")]
    public class ToDoItem
    {
        [PrimaryKey]
        [AutoIncrement]

        public int Id { get; set; }

        public string Description { get; set; } = string.Empty;

        //[References(typeof(Category))]
        public int CategoryId { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndTime { get; set; } = DateTime.Today.AddDays(1); //expire tomorrow by default

        public DateTime Tomorrow1 { get; set; } = DateTime.Today.AddDays(1);
        public DateTime Tomorrow2 { get; set; } = DateTime.Today.AddDays(2);

        public bool Done { get; set; } = false;

        public string CategoryName { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty;


        //public Category GetCategory()
        //    => DbContext.GetInstance().SingleById<Category>(this.CategoryId);

        public string GetStatus()
        {
            if (this.Done) return "Выполнено";

            if (this.EndTime > DateTime.Now)
            {
                return "В процессе";
            }
            else
            {
                return "Невыполнено";
            }
        }

    }
}
