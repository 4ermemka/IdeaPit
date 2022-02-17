namespace IdeaPit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IdeaTag")]
    public partial class IdeaTag
    {
        public int ID_idea { get; set; }

        public int TagNum { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_tag { get; set; }

        public virtual Idea Idea { get; set; }

        public virtual Tag Tag { get; set; }
    }
}
