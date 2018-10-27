namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Country
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CounryName { get; set; }

        [StringLength(255)]
        public string CountryDescription { get; set; }

        public int? StatusID { get; set; }
    }
}
