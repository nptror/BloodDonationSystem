using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[Table("User")]
[Microsoft.EntityFrameworkCore.Index("PhoneNumber", Name = "UQ__User__4849DA019B1B5F2D", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [Column("phoneNumber")]
    [StringLength(20)]
    [Unicode(false)]
    public string PhoneNumber { get; set; } = null!;

    [Column("password")]
    [StringLength(100)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("fullName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [Column("dayOfBirth")]
    public DateOnly? DayOfBirth { get; set; }

    [Column("gender")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("address")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("role")]
    [StringLength(20)]
    [Unicode(false)]
    public string Role { get; set; } = null!;

    [Column("bloodTypeId")]
    public int? BloodTypeId { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<BloodDonationRegister> BloodDonationRegisters { get; set; } = new List<BloodDonationRegister>();

    [InverseProperty("Staff")]
    public virtual ICollection<BloodRequest> BloodRequestStaffs { get; set; } = new List<BloodRequest>();

    [InverseProperty("User")]
    public virtual ICollection<BloodRequest> BloodRequestUsers { get; set; } = new List<BloodRequest>();

    [ForeignKey("BloodTypeId")]
    [InverseProperty("Users")]
    public virtual BloodType? BloodType { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<DonationForm> DonationForms { get; set; } = new List<DonationForm>();

    [InverseProperty("CreatedByNavigation")]
    public virtual ICollection<ReportLog> ReportLogs { get; set; } = new List<ReportLog>();
}
