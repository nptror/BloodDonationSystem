using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("BloodType")]
[Index("BloodName", Name = "UQ__BloodTyp__20D759903E4CC03F", IsUnique = true)]
public partial class BloodType
{
    [Key]
    [Column("bloodTypeId")]
    public int BloodTypeId { get; set; }

    [Column("bloodName")]
    [StringLength(10)]
    [Unicode(false)]
    public string BloodName { get; set; } = null!;

    [InverseProperty("DonorBloodType")]
    public virtual ICollection<BloodCompatibility> BloodCompatibilityDonorBloodTypes { get; set; } = new List<BloodCompatibility>();

    [InverseProperty("RecipientBloodType")]
    public virtual ICollection<BloodCompatibility> BloodCompatibilityRecipientBloodTypes { get; set; } = new List<BloodCompatibility>();

    [InverseProperty("BloodType")]
    public virtual ICollection<BloodInventory> BloodInventories { get; set; } = new List<BloodInventory>();

    [InverseProperty("BloodType")]
    public virtual ICollection<BloodRequest> BloodRequests { get; set; } = new List<BloodRequest>();

    [InverseProperty("BloodType")]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
