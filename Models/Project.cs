using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace cmpg323project2.Models
{
    [Table("Project", Schema = "Config")]
    public partial class Project
    {
        [Key]
        [Column("ProjectID")]
        public Guid ProjectId { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ProjectName { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ProjectDescription { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ProjectCreationDate { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string? ProjectStatus { get; set; }
        [Column("ClientID")]
        public Guid? ClientId { get; set; }
    }
}
