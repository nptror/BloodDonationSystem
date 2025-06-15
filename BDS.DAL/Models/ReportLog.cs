using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("ReportLog")]
public partial class ReportLog
{
    [Key]
    [Column("reportId")]
    public int ReportId { get; set; }

    [Column("title")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Title { get; set; }

    [Column("createdBy")]
    public int? CreatedBy { get; set; }

    [Column("createdDate", TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column("filePath")]
    [StringLength(255)]
    [Unicode(false)]
    public string? FilePath { get; set; }

    [Column("note")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Note { get; set; }

    [ForeignKey("CreatedBy")]
    [InverseProperty("ReportLogs")]
    public virtual User? CreatedByNavigation { get; set; }
}
