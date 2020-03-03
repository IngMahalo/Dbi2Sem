﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchulDb.Model
{
    [Table("Schuljahr")]
    public partial class Schuljahr
    {
        [Key]
        [Column("Sja_Nr")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  // Für SQL Server, sonst glaubt EF Core es ist ein Autowert.
        public int SjaNr { get; set; }
        [Required]
        [Column("Sja_Bezeichnung")]
        [StringLength(255)]
        public string SjaBezeichnung { get; set; }
        [Column("Sja_Datumvon")]
        public DateTime SjaDatumvon { get; set; }
        [Column("Sja_Datumbis")]
        public DateTime SjaDatumbis { get; set; }
        [Column("Sja_Wintersemester")]
        public bool Wintersemester { get; set; }
        [Column("Sja_Sommersemester")]
        public bool Sommersemester { get; set; }
        [InverseProperty(nameof(Klasse.KSchuljahrNavigation))]
        public virtual ICollection<Klasse> Klassens { get; set; }
    }
}