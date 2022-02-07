namespace Driver
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("карточка водителя")]
    public partial class карточка_водителя
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [StringLength(50)]
        public string Passport { get; set; }

        [Column("Registration address")]
        [StringLength(50)]
        public string Registration_address { get; set; }

        [Column("Residential adress")]
        [StringLength(50)]
        public string Residential_adress { get; set; }

        [Column("Place of work")]
        [StringLength(50)]
        public string Place_of_work { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Photo { get; set; }

        public string Remarks { get; set; }
    }
}
