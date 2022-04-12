namespace FnetMvcUniversity.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int id { get; set; }

        public string StudLRN { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string StudCourse { get; set; }

        public int StudYear { get; set; }

        [Required]
        public string StudSection { get; set; }
    }
}
