namespace agenda
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class qsdfg_appointments
    {
        [Key]
        public int idAppointment { get; set; }

        public DateTime dateHour { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string subject { get; set; }

        public int idBroker { get; set; }

        public int idCustomer { get; set; }

        public virtual qsdfg__customers qsdfg__customers { get; set; }

        public virtual qsdfg_brokers qsdfg_brokers { get; set; }
    }
}
