using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("BloodCompatibility")]
public partial class BloodCompatibility
{
    [Key]
    [Column("compatibilityId")]
    public int CompatibilityId { get; set; }

    [Column("donorBloodTypeId")]
    public int? DonorBloodTypeId { get; set; }

    [Column("recipientBloodTypeId")]
    public int? RecipientBloodTypeId { get; set; }

    [Column("componentTypeId")]
    public int? ComponentTypeId { get; set; }

    [Column("isCompatible")]
    public bool? IsCompatible { get; set; }

    [ForeignKey("ComponentTypeId")]
    [InverseProperty("BloodCompatibilities")]
    public virtual BloodComponentType? ComponentType { get; set; }

    [ForeignKey("DonorBloodTypeId")]
    [InverseProperty("BloodCompatibilityDonorBloodTypes")]
    public virtual BloodType? DonorBloodType { get; set; }

    [ForeignKey("RecipientBloodTypeId")]
    [InverseProperty("BloodCompatibilityRecipientBloodTypes")]
    public virtual BloodType? RecipientBloodType { get; set; }
}
