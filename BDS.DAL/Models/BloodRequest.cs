using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("BloodRequest")]
public partial class BloodRequest
{
    [Key]
    [Column("requestId")]
    public int RequestId { get; set; }

    [Column("userId")]
    public int? UserId { get; set; }

    [Column("bloodTypeId")]
    public int? BloodTypeId { get; set; }

    [Column("componentType")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ComponentType { get; set; }

    [Column("quantity")]
    public double? Quantity { get; set; }

    [Column("status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("requestDate")]
    public DateOnly? RequestDate { get; set; }

    [Column("staffId")]
    public int? StaffId { get; set; }

    [ForeignKey("BloodTypeId")]
    [InverseProperty("BloodRequests")]
    public virtual BloodType? BloodType { get; set; }

    [InverseProperty("Request")]
    public virtual ICollection<DonationForm> DonationForms { get; set; } = new List<DonationForm>();

    [ForeignKey("StaffId")]
    [InverseProperty("BloodRequestStaffs")]
    public virtual User? Staff { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("BloodRequestUsers")]
    public virtual User? User { get; set; }
}
