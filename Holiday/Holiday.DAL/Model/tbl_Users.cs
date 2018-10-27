namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_Users
    {
        [Key]
        public int UserId { get; set; }

        [StringLength(500)]
        public string UserName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        public int? Role { get; set; }
    }
}
