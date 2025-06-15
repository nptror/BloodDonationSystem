using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("BloodDonationRegister")]
public partial class BloodDonationRegister
{
    [Key]
    [Column("registerId")]
    public int RegisterId { get; set; }

    [Column("userId")]
    public int? UserId { get; set; }

    [Column("registerDate")]
    public DateOnly? RegisterDate { get; set; }

    [Column("availableDate")]
    public DateOnly? AvailableDate { get; set; }

    [Column("status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("notes", TypeName = "text")]
    public string? Notes { get; set; }

    [Column("donationAddress")]
    [StringLength(255)]
    [Unicode(false)]
    public string? DonationAddress { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("BloodDonationRegisters")]
    public virtual User? User { get; set; }
}
