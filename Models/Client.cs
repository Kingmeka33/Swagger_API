using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace cmpg323project2.Models
{
    [Table("Client", Schema = "Config")]
    public partial class Client
    {
        [Key]
        [Column("ClientID")]
        public Guid ClientId { get; set; }
        public string? ClientName { get; set; }
        public string? PrimaryContactEmail { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DateOnboarded { get; set; }

    }
    public class SavingsResult
    {
        public double TotalTimeSaved { get; set; }
        public decimal TotalCostSaved { get; set; }
    }
}
