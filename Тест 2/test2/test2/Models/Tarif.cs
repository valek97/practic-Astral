using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class Tarif
    {

        // ID тарифа
        public int Id { get; set; }
        // название книги
        public string Guid { get; set; }
        // наименование тарифа
        public string Name { get; set; }
        // Тип тарифа
        public int Type { get; set; }
        // Группа
        public int Groupe { get; set; }
        // Дата создания
        public DateTime Datecreate { get; set; }
        // Артикул
        public string Article { get; set; }


    }
}