namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Sanction
    {
        [Key]
        public int SanctionNo { get; set; }

        public DateTime SanctionDate { get; set; }

        [StringLength(50)]
        public string SanctionSatus { get; set; }

        [StringLength(50)]
        public string USERNAME { get; set; }
    }
}
