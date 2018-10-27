namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_ApplicationData
    {
        [Key]
        public int Application_No { get; set; }

        [Required]
        public string UserName { get; set; }

        public int LeaveTypeId { get; set; }

        public DateTime StartingDate { get; set; }

        public DateTime EndingDate { get; set; }

        public DateTime? ApplyingDate { get; set; }

        public int NoOfDays { get; set; }

        public string LeavePurpose { get; set; }

        public string ApplicationDescription { get; set; }
    }
}
