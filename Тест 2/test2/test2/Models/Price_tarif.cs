using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class Price_tarif
    {
        // ID услуги
        public int Tariff_id { get; set; }
        // Состояние
        public int Step_ip { get; set; }
        // Пользователь
        public int User_id { get; set; }
        // Время окончания
        public TimeSpan End_time { get; set; }
        // Наименование
        public char Registered_name { get; set; }
        // Секция прайса
        public int Section_price { get; set; }
        // Показывать
        public Boolean Displayed { get; set; }
        // Артикул
        public char Article { get; set; }
        // Идентификатор позиции в прайсе
        public string Price_tariff_id { get; set; }
        // Доп информация
        public char Note { get; set; }
        



    }
}