namespace LabDay1EFR.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("instructor")]
    public partial class instructor
    {
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string passowrd { get; set; }

        [StringLength(50)]
        public string cv { get; set; }

        [StringLength(50)]
        public string photo { get; set; }

        public int? age { get; set; }

        public int? dept_id { get; set; }

        public virtual department department { get; set; }
    }
}
