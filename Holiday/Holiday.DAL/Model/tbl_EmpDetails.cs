namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_EmpDetails
    {
        [Key]
        public int EmpId { get; set; }

        [StringLength(50)]
        public string EmpName { get; set; }

        [StringLength(50)]
        public string EmpDesigName { get; set; }

        public int? DeptId { get; set; }

        [StringLength(200)]
        public string Adress { get; set; }

        public int? CityId { get; set; }

        public int? StateId { get; set; }

        public int? CountryId { get; set; }

        [StringLength(50)]
        public string EmailId { get; set; }

        [StringLength(50)]
        public string ContactNo { get; set; }

        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
    }
}
