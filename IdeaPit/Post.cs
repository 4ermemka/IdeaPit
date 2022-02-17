namespace IdeaPit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Post")]
    public partial class Post
    {
        [Column(TypeName = "date")]
        public DateTime PostDate { get; set; }

        public int ID_idea { get; set; }

        public int ID_user { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_post { get; set; }

        public virtual Idea Idea { get; set; }

        public virtual Users Users { get; set; }
    }
}
