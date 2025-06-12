using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.DAL.ModelFromDB;

[Table("DonationRegistration")]
public partial class DonationRegistration
{
    [Key]
    [Column("donation_id")]
    public int DonationId { get; set; }

    [Column("user_id")]
    public int UserId { get; set; }

    [Column("registered_date")]
    public DateOnly RegisteredDate { get; set; }

    [Column("available_date")]
    public DateOnly? AvailableDate { get; set; }

    [Column("status")]
    [StringLength(20)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [Column("notes", TypeName = "text")]
    public string? Notes { get; set; }

    [Column("donation_address")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DonationAddress { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("DonationRegistrations")]
    public virtual User User { get; set; } = null!;
}
