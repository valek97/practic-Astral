using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BooksStore.Models
{
    public class Book
    {


        // id книг
        public int id { get; set; }

        // наименование книги
        public string Name { get; set; }

        // Автор\ы
        public string Author { get; set; }

        // Стоимость
        public int Price { get; set; }
    }
}