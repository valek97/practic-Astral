using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class Price_trend
    {
        // Секция прайса
        public char Section_id { get; set; }
        // Услуга
        public char Tariff_id { get; set; }
        // Время начала
        public char Initial_time { get; set; }
        // Время окончания
        public char End_time { get; set; }
        // Цена
        public char Price { get; set; }
        // Затраты
        public char Cost { get; set; }

    }
}