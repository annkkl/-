namespace Экскурсионное_бюро
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model11")
        {
        }

        public virtual DbSet<Заказы> Заказы { get; set; }
        public virtual DbSet<Клиенты> Клиенты { get; set; }
        public virtual DbSet<Водители> Водители { get; set; }
        public virtual DbSet<Гиды> Гиды { get; set; }
        public virtual DbSet<Маршруты> Маршруты { get; set; }
        public virtual DbSet<Менеджеры> Менеджеры { get; set; }
        public virtual DbSet<Транспорт> Транспорт { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Заказы>()
                .Property(e => e.Стоимость)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Клиенты>()
                .Property(e => e.НомерТелефона)
                .IsFixedLength();

            modelBuilder.Entity<Водители>()
                .Property(e => e.ФИО)
                .IsFixedLength();

            modelBuilder.Entity<Маршруты>()
                .Property(e => e.НомерАвтобуса)
                .IsFixedLength();

            modelBuilder.Entity<Менеджеры>()
                .Property(e => e.НомерТелефона)
                .IsFixedLength();

            modelBuilder.Entity<Транспорт>()
                .Property(e => e.НомерАвтобуса)
                .IsFixedLength();

            modelBuilder.Entity<Транспорт>()
                .Property(e => e.Марка)
                .IsFixedLength();
        }
    }
}
