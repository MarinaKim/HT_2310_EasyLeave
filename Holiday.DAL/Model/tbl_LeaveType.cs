namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_LeaveType
    {
        [Key]
        public int LeaveTypeId { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Desg { get; set; }

        public int? NoOfLeavePerYear { get; set; }
    }
}
