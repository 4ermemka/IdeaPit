namespace IdeaPit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Commentary")]
    public partial class Commentary
    {
        [Required]
        [StringLength(120)]
        public string Text { get; set; }

        [Column(TypeName = "date")]
        public DateTime PostTime { get; set; }

        public int ComRating { get; set; }

        public int ID_idea { get; set; }

        public int ID_user { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_comment { get; set; }

        public virtual Idea Idea { get; set; }

        public virtual Users Users { get; set; }
    }
}
