namespace Holiday.DAL.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_CityDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }

        [Required]
        [StringLength(50)]
        public string CityName { get; set; }

        [StringLength(255)]
        public string CityDescription { get; set; }

        public int StateID { get; set; }

        public int CountryId { get; set; }

        public int StatusID { get; set; }
    }
}
