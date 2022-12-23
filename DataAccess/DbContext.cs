/*using System;
using System.Data;
using System.Windows.Forms;
using ServiceStack.DataAnnotations;
using ServiceStack.OrmLite;
using ToDo.DataAccess.Models;

namespace ToDo.DataAccess
{
    internal class DbContext
    {
        private static IDbConnection _db;
        public static Exception Exeption;

        public static IDbConnection GetInstance()
        {

            var dbFactory = new OrmLiteConnectionFactory(
                "Data Source=Database/my_bd.bd;Version=3;",
                SqliteDialect.Provider);

            try
            {
                if (_db == null)
                {
                    _db = dbFactory.Open();
                    Migrate();
                }

                if (_db.State == ConnectionState.Broken || _db.State == ConnectionState.Closed)
                    _db = dbFactory.Open();

                return _db;
            }
            catch (Exception err) {
                Exception Exception = err;
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        private static void Migrate()
        {
            var db = GetInstance();
            // table creation

            if (db.CreateTableIfNotExists<Category>())
            {
                db.Save(new Category() {
                    Id = 1,
                    CategoryName = "Сегодня"
                }) ;
                db.Save(new Category()
                {
                    Id = 2,
                    CategoryName = "Завтра"
                });
                db.Save(new Category()
                {
                    Id = 3,
                    CategoryName = "Новые"
                });
                db.Save(new Category()
                {
                    Id = 4,
                    CategoryName = "Важные"
                });
                db.Save(new Category()
                {
                    Id = 5,
                    CategoryName = "Невыполненные"
                });      
            }

            *//*if (db.CreateTableIfNotExists<ToDoItem>())
            {
                db.Save(new ToDoItem()
                {
                    CategoryId = 1,
                    Description = "Сделать зарядку"
                });

                db.Save(new ToDoItem()
                {
                    CategoryId = 1,
                    Description = "Почистить зубы"
                });

                db.Save(new ToDoItem()
                {
                    CategoryId = 1,
                    Description = "Сходить в магазин"
                });
            }*//*
        }

        
    }
}
*/