using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test2.Models
{
    public class Tarif_atribute
    {

        // ID атрибута тарифа
        public int Id_atribute_tarif { get; set; }
        // Id тарифа
        public int Id_tarif { get; set; }
        // Атрибут
        public int Id_atribute { get; set; }
        // Количество
        public int Number { get; set; }
        // мин количество
        public int Min_number { get; set; }
        // макс количество
        public int Max_number { get; set; }
        // порядковый номер
        public int Index_number { get; set; }
        // минимальный порядковый номер
        public int Min_index { get; set; }
        // Ограничение
        public int Limit_id { get; set; }
        // Срок действия
        public int Validity { get; set; }
        // Ед. времени срока
        public int Validity_unit_id { get; set; }
        // Дни ожидания
        public int Waiting_day { get; set; }
        


    }
}