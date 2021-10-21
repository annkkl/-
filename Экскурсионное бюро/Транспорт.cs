namespace Экскурсионное_бюро
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Транспорт
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string НомерАвтобуса { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string Марка { get; set; }
    }
}
