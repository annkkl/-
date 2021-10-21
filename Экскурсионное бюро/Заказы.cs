namespace Экскурсионное_бюро
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Заказы
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_Заказа { get; set; }

        public int КодМаршрута { get; set; }

        [Column(TypeName = "date")]
        public DateTime ДатаПоездки { get; set; }

        [Column(TypeName = "money")]
        public decimal Стоимость { get; set; }

        public int IDМенеджера { get; set; }

        public int IDКлиента { get; set; }
    }
}
