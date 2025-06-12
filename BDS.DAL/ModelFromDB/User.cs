using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.DAL.ModelFromDB;

[Table("User")]
[Index("PhoneNumber", Name = "UQ__User__A1936A6B0EF38C33", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("user_id")]
    public int UserId { get; set; }

    [Column("phone_number")]
    [StringLength(20)]
    [Unicode(false)]
    public string PhoneNumber { get; set; } = null!;

    [Column("password")]
    [StringLength(100)]
    [Unicode(false)]
    public string Password { get; set; } = null!;

    [Column("full_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [Column("dob")]
    public DateOnly? Dob { get; set; }

    [Column("gender")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("address")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("role")]
    [StringLength(10)]
    [Unicode(false)]
    public string Role { get; set; } = null!;

    [Column("blood_type_id")]
    public int? BloodTypeId { get; set; }

    [InverseProperty("User")]
    public virtual ICollection<DonationRegistration> DonationRegistrations { get; set; } = new List<DonationRegistration>();
}
