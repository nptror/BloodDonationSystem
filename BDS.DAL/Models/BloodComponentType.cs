using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("BloodComponentType")]
public partial class BloodComponentType
{
    [Key]
    [Column("componentTypeId")]
    public int ComponentTypeId { get; set; }

    [Column("componentName")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ComponentName { get; set; }

    [InverseProperty("ComponentType")]
    public virtual ICollection<BloodCompatibility> BloodCompatibilities { get; set; } = new List<BloodCompatibility>();

    [InverseProperty("ComponentType")]
    public virtual ICollection<BloodInventory> BloodInventories { get; set; } = new List<BloodInventory>();
}
