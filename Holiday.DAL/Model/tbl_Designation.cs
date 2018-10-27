namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Designation
    {
        [Key]
        public int DesigId { get; set; }

        [StringLength(50)]
        public string DesigType { get; set; }

        [Required]
        [StringLength(500)]
        public string DesigDesc { get; set; }
    }
}
