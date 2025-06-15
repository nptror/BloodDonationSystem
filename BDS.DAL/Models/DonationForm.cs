using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace BDS.Web.Models;

[PrimaryKey("UserId", "RequestId")]
[Table("DonationForm")]
public partial class DonationForm
{
    [Key]
    [Column("userId")]
    public int UserId { get; set; }

    [Key]
    [Column("requestId")]
    public int RequestId { get; set; }

    [Column("everDonated")]
    public bool? EverDonated { get; set; }

    [Column("chronicDisease")]
    public bool? ChronicDisease { get; set; }

    [Column("treatedLast12Months")]
    public bool? TreatedLast12Months { get; set; }

    [Column("symptomsLast6Months")]
    public bool? SymptomsLast6Months { get; set; }

    [Column("bloodTransfusion")]
    public bool? BloodTransfusion { get; set; }

    [Column("dentalTreatment")]
    public bool? DentalTreatment { get; set; }

    [Column("minorSurgery")]
    public bool? MinorSurgery { get; set; }

    [Column("tattoosOrPiercings")]
    public bool? TattoosOrPiercings { get; set; }

    [Column("hivRiskContact")]
    public bool? HivRiskContact { get; set; }

    [Column("sexualContact")]
    public bool? SexualContact { get; set; }

    [Column("infectionLast6Months")]
    public bool? InfectionLast6Months { get; set; }

    [Column("vaccinatedRecently")]
    public bool? VaccinatedRecently { get; set; }

    [Column("travelToEpidemicArea")]
    public bool? TravelToEpidemicArea { get; set; }

    [Column("fluSymptoms")]
    public bool? FluSymptoms { get; set; }

    [Column("takingMedication")]
    public bool? TakingMedication { get; set; }

    [Column("pregnantOrBreastfeeding")]
    public bool? PregnantOrBreastfeeding { get; set; }

    [Column("menstruation")]
    public bool? Menstruation { get; set; }

    [Column("hivTestConsent")]
    public bool? HivTestConsent { get; set; }

    [Column("reasonForPostpone")]
    [StringLength(255)]
    [Unicode(false)]
    public string? ReasonForPostpone { get; set; }

    [Column("infoProvider")]
    [StringLength(100)]
    [Unicode(false)]
    public string? InfoProvider { get; set; }

    [Column("agreedToTerms")]
    public bool? AgreedToTerms { get; set; }

    [Column("formDate")]
    public DateOnly? FormDate { get; set; }

    [ForeignKey("RequestId")]
    [InverseProperty("DonationForms")]
    public virtual BloodRequest Request { get; set; } = null!;

    [ForeignKey("UserId")]
    [InverseProperty("DonationForms")]
    public virtual User User { get; set; } = null!;
}
