namespace WebAppsFromStart2End
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Course
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int? AvailableSlots { get; set; }

        public DateTime? CourseDate { get; set; }

        public double? Price { get; set; }
    }
}
