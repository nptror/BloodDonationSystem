using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("BloodInventory")]
public partial class BloodInventory
{
    [Key]
    [Column("bloodBagId")]
    public int BloodBagId { get; set; }

    [Column("bloodTypeId")]
    public int BloodTypeId { get; set; }

    [Column("componentTypeId")]
    public int ComponentTypeId { get; set; }

    [Column("volume")]
    public int Volume { get; set; }

    [Column("collectionDate")]
    public DateOnly CollectionDate { get; set; }

    [Column("expiryDate")]
    public DateOnly ExpiryDate { get; set; }

    [Column("source")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Source { get; set; }

    [Column("status")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("updateBy")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UpdateBy { get; set; }

    public bool? IsWholeBloodAvailable { get; set; }

    [ForeignKey("BloodTypeId")]
    [InverseProperty("BloodInventories")]
    public virtual BloodType BloodType { get; set; } = null!;

    [ForeignKey("ComponentTypeId")]
    [InverseProperty("BloodInventories")]
    public virtual BloodComponentType ComponentType { get; set; } = null!;
}
