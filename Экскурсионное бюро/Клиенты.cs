namespace Экскурсионное_бюро
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Клиенты
    {
        [Key]
        public int IDКлиента { get; set; }

        [Required]
        [StringLength(70)]
        public string ФИО { get; set; }

        public int Возраст { get; set; }

        [Required]
        [StringLength(15)]
        public string НомерТелефона { get; set; }
    }
}
