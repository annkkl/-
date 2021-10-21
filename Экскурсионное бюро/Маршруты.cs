namespace Экскурсионное_бюро
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Маршруты
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDМаршрута { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string НазваниеМаршрута { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string НомерАвтобуса { get; set; }

        [Key]
        [Column(Order = 3)]
        public string ПланПоездки { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDВодителя { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDГида { get; set; }
    }
}
