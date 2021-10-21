namespace Экскурсионное_бюро
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Менеджеры
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDМенеджера { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(70)]
        public string ФИО { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string НомерТелефона { get; set; }
    }
}
